namespace Hackers_vs_CyberCrime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblUsesLeft = new System.Windows.Forms.Label();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.server1 = new System.Windows.Forms.PictureBox();
            this.server2 = new System.Windows.Forms.PictureBox();
            this.server3 = new System.Windows.Forms.PictureBox();
            this.server4 = new System.Windows.Forms.PictureBox();
            this.server5 = new System.Windows.Forms.PictureBox();
            this.server6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.server1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(29, 277);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 65);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "New Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPass
            // 
            this.btnPass.Enabled = false;
            this.btnPass.Location = new System.Drawing.Point(557, 421);
            this.btnPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(155, 65);
            this.btnPass.TabIndex = 2;
            this.btnPass.Text = "New Encryption";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Visible = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(359, 421);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(155, 65);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Hack";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblUsesLeft
            // 
            this.lblUsesLeft.AutoSize = true;
            this.lblUsesLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblUsesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsesLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsesLeft.Location = new System.Drawing.Point(737, 436);
            this.lblUsesLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsesLeft.Name = "lblUsesLeft";
            this.lblUsesLeft.Size = new System.Drawing.Size(188, 39);
            this.lblUsesLeft.TabIndex = 4;
            this.lblUsesLeft.Text = "2 Uses Left";
            this.lblUsesLeft.Visible = false;
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentState.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentState.Location = new System.Drawing.Point(40, 11);
            this.lblCurrentState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(920, 58);
            this.lblCurrentState.TabIndex = 5;
            this.lblCurrentState.Text = "Press New Game to start a New Game";
            this.lblCurrentState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // server1
            // 
            this.server1.Image = global::Hackers_vs_CyberCrime.Properties.Resources.server;
            this.server1.Location = new System.Drawing.Point(51, 117);
            this.server1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server1.Name = "server1";
            this.server1.Size = new System.Drawing.Size(133, 135);
            this.server1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.server1.TabIndex = 6;
            this.server1.TabStop = false;
            this.server1.Visible = false;
            // 
            // server2
            // 
            this.server2.Image = global::Hackers_vs_CyberCrime.Properties.Resources.server;
            this.server2.Location = new System.Drawing.Point(224, 117);
            this.server2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server2.Name = "server2";
            this.server2.Size = new System.Drawing.Size(133, 135);
            this.server2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.server2.TabIndex = 7;
            this.server2.TabStop = false;
            this.server2.Visible = false;
            // 
            // server3
            // 
            this.server3.Image = global::Hackers_vs_CyberCrime.Properties.Resources.server;
            this.server3.Location = new System.Drawing.Point(384, 117);
            this.server3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server3.Name = "server3";
            this.server3.Size = new System.Drawing.Size(133, 135);
            this.server3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.server3.TabIndex = 8;
            this.server3.TabStop = false;
            this.server3.Visible = false;
            // 
            // server4
            // 
            this.server4.Image = global::Hackers_vs_CyberCrime.Properties.Resources.server;
            this.server4.Location = new System.Drawing.Point(549, 117);
            this.server4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server4.Name = "server4";
            this.server4.Size = new System.Drawing.Size(133, 135);
            this.server4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.server4.TabIndex = 9;
            this.server4.TabStop = false;
            this.server4.Visible = false;
            // 
            // server5
            // 
            this.server5.Image = global::Hackers_vs_CyberCrime.Properties.Resources.server;
            this.server5.Location = new System.Drawing.Point(716, 117);
            this.server5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server5.Name = "server5";
            this.server5.Size = new System.Drawing.Size(133, 135);
            this.server5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.server5.TabIndex = 10;
            this.server5.TabStop = false;
            this.server5.Visible = false;
            // 
            // server6
            // 
            this.server6.Image = global::Hackers_vs_CyberCrime.Properties.Resources.server;
            this.server6.Location = new System.Drawing.Point(880, 117);
            this.server6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server6.Name = "server6";
            this.server6.Size = new System.Drawing.Size(133, 135);
            this.server6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.server6.TabIndex = 11;
            this.server6.TabStop = false;
            this.server6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.server6);
            this.Controls.Add(this.server5);
            this.Controls.Add(this.server4);
            this.Controls.Add(this.server3);
            this.Controls.Add(this.server2);
            this.Controls.Add(this.server1);
            this.Controls.Add(this.lblCurrentState);
            this.Controls.Add(this.lblUsesLeft);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.server1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblUsesLeft;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.PictureBox server1;
        private System.Windows.Forms.PictureBox server2;
        private System.Windows.Forms.PictureBox server3;
        private System.Windows.Forms.PictureBox server4;
        private System.Windows.Forms.PictureBox server5;
        private System.Windows.Forms.PictureBox server6;
    }
}

