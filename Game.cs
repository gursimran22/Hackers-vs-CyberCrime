using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackers_vs_CyberCrime
{
    public class Game
    {
        public int EncryptUses; // Stores the amount of Uses the player has left for the Skip
        public int CurrentRound; // Stores the Current Round Number
        public int CounterAttack; // Stores the round that the Police are going to Counter Hack (RNG)
        public string CurrentState; // The current state message for the game window
        public bool EncryptInUse; // The current state of the usage of the Encryption


        // The Start Game method setts all of the variables to a "New Game" state
        public void StartGame()
        {
            EncryptUses = 2; // Sets the amount of Encryptions the user has
            CurrentRound = 0; // Sets the round to 0
            Random dodgyboy = new Random(); // Initializes the Random Class
            CounterAttack = dodgyboy.Next(0, 6); // Sets CounterAttack to a random number from 1 - 5
            CurrentState = "So far you're safe"; // Sets the Current state to the "safe" message
            EncryptInUse = false; // sets the bool variable to false
        }

        // The method WinGame Returns the State True if the Current Round is == 5, this method is only run if the user is safe.
        // It will also set the Current State of the game.
        public bool WinGame()
        {
            bool returnState = (CurrentRound == 5) ? true : false;

            CurrentState = (returnState) ? "Well done, You have not been Caught!" : CurrentState;

            return returnState;
        }

        // The NewEncrypt Method removes 1 from the Encrypt Uses and sets EncryptInUse to = True;
        public void NewEncrypt()
        {
            EncryptInUse = true;
            EncryptUses -= 1;
        }

        // The MoveSafe Method checks if the Current move is "Safe". It will then return a bool of either True or False
        public bool MoveSafe()
        {
            // If the Encrypt is in Use, the user will always be "Safe" for that round, And if the currentround != the CounterAttack number than they are also safe.
            // Otherwise they are not safe and it will return false

            bool returnState = (EncryptInUse || CurrentRound != CounterAttack) ? true : false;
            EncryptInUse = false;

            CurrentState = (returnState) ? CurrentState : $"You have been Caught on Round {CurrentRound + 1}";

            return returnState;
        }

        // Adds 1 to the Current Round Variable
        public void NextRound()
        {
            CurrentRound += 1;
        }

        // The outOfPassCheck Method is returns a True or False depending on if the User has an Encryption Use left
        public bool outOfPassCheck()
        {
            bool returnState = (EncryptUses < 1) ? true : false;

            return returnState;
        }

        // The getUsesLeftString returns a string for the front end code containing the current Uses left
        public string getUsesLeftString()
        {
            return $"{EncryptUses.ToString()} Uses Left";
        }

        // The getCurrentState Method returns the Current State variable. This is a method because if there needs to be
        // Manipulation done to Current State before returning to front end, it will be easy to implement.
        public string getCurrentState()
        {
            return CurrentState;
        }
    }
}
