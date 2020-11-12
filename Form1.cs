using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace Hackers_vs_CyberCrime
{
    public partial class Form1 : Form
    {
        Game myGame = new Game(); // Initializing myGameClass
        PictureBox[] serverImage; // Declaring Global serverImage List
        Button[] btnActionList; // Declaring Global btnAction List

        public Form1()
        {
            InitializeComponent();
            // Initializing PictureBox List
            serverImage = new PictureBox[] { server1, server2, server3, server4, server5, server6 };
            // Initializing Button List
            btnActionList = new Button[] { btnPass, btnContinue };
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            // Disabling the btnPass button so it cant be spam clicked
            btnPass.Enabled = false;

            // Running Sound for the "Encryption"
            SoundPlayer encryptSound = new SoundPlayer(Properties.Resources.Encryption);
            encryptSound.Play();

            // Running NewEncrypt method in the myGame class
            myGame.NewEncrypt();

            // Gets the current uses left as a string then Displays it
            lblUsesLeft.Text = myGame.getUsesLeftString();

            // Checks if user is out of Encryptions/Passes
            // The method outOfPassCheck will return true if the User
            // Has used all of their Encryptions
            if (myGame.outOfPassCheck())
            {
                // If outOfPass is True, Set the button to Visible false.
                btnPass.Visible = false;
            } else
            {
                // If outOfPass is false, Re-Enable the Button and continue
                btnPass.Enabled = true;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Checks if users move is Safe. If their move is save it will return True
            // MoveSafe is a method of myGame class
            if (myGame.MoveSafe())
            {
                // Running Sound for the "Hack"
                SoundPlayer hackSound = new SoundPlayer(Properties.Resources.hacking);
                hackSound.Play();

                // If MoveSafe = True then set the serverImage of the current round
                // to the hacked image. 
                // myGame.CurrentRound is a method of the class myGame that will return
                // the int of the Current Round
                serverImage[myGame.CurrentRound].Image = Properties.Resources.hacked;

                if (myGame.WinGame())
                {
                    gameOver();
                } else
                {
                    // myGame.NextRound is a method of the myGame class, where it will
                    // take the Character to the next round, and set the variables
                    // Accordingly
                    myGame.NextRound();
                }
                
                
            } else
            {
                // Running Sound for the "Hack"
                SoundPlayer caughtSound = new SoundPlayer(Properties.Resources.Siren);
                caughtSound.Play();
                // if MoveSafe = false then set the image to Caught
                serverImage[myGame.CurrentRound].Image = Properties.Resources.caught;
                gameOver();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        // This method is run when the btnStart is clicked. It sets all of the Elements to the correct states
        private void StartGame()
        {
            // This runs a method in the myGame class, which sets all of the variables to Starting values
            myGame.StartGame();

            // Reset All the Images to Original State. The variable serverImage is a global variable of all of the images
            foreach (var server in serverImage)
            {
                server.Image = Properties.Resources.server;
                server.Visible = true;
            }

            // Make Game Buttons Visible and Enabled
            foreach (var button in btnActionList)
            {
                button.Visible = true;
                button.Enabled = true;
            }

            //Disable and hide start game button
            btnStart.Visible = false;
            btnStart.Enabled = false;

            // Resetting the Labels and Displaying Current Information
            lblUsesLeft.Text = myGame.getUsesLeftString();
            lblUsesLeft.Visible = true;
            lblCurrentState.Text = myGame.getCurrentState();
        }

        private void gameOver()
        {
            // Make Game Buttons No longer Visible and Disabled
            foreach (var button in btnActionList)
            {
                button.Visible = false;
                button.Enabled = false;
            }

            //Enable and show start game button
            btnStart.Visible = true;
            btnStart.Enabled = true;

            // Resetting the Labels and Displaying Current Information
            lblUsesLeft.Visible = false;
            lblCurrentState.Text = myGame.getCurrentState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
