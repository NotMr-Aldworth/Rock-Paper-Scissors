namespace Rock_Paper_Scissors
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
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.grpUserchoice = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.grpUserchoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Rock_Paper_Scissors.Properties.Resources._2020_02_12_19_13_36;
            this.imgPlayer.Location = new System.Drawing.Point(21, 26);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(289, 172);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 0;
            this.imgPlayer.TabStop = false;
            this.imgPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Rock_Paper_Scissors.Properties.Resources._2020_02_12_19_13_36;
            this.imgOpponent.Location = new System.Drawing.Point(482, 26);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(289, 172);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 1;
            this.imgOpponent.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtUser.Location = new System.Drawing.Point(126, 201);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(61, 25);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(572, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opponent";
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.radRock.Location = new System.Drawing.Point(12, 12);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(73, 28);
            this.radRock.TabIndex = 4;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.ForeColor = System.Drawing.SystemColors.Window;
            this.radPaper.Location = new System.Drawing.Point(12, 46);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(104, 22);
            this.radPaper.TabIndex = 5;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged_1);
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Font = new System.Drawing.Font("MS Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radScissors.Location = new System.Drawing.Point(12, 74);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(98, 20);
            this.radScissors.TabIndex = 6;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // grpUserchoice
            // 
            this.grpUserchoice.Controls.Add(this.radPaper);
            this.grpUserchoice.Controls.Add(this.radScissors);
            this.grpUserchoice.Controls.Add(this.radRock);
            this.grpUserchoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grpUserchoice.Location = new System.Drawing.Point(64, 239);
            this.grpUserchoice.Name = "grpUserchoice";
            this.grpUserchoice.Size = new System.Drawing.Size(200, 100);
            this.grpUserchoice.TabIndex = 7;
            this.grpUserchoice.TabStop = false;
            this.grpUserchoice.Text = "Pick One!";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(492, 266);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(243, 100);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Play!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblVs.Location = new System.Drawing.Point(371, 109);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(48, 35);
            this.lblVs.TabIndex = 9;
            this.lblVs.Text = "VS";
            this.lblVs.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOutcome.Location = new System.Drawing.Point(87, 381);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(124, 24);
            this.lblOutcome.TabIndex = 10;
            this.lblOutcome.Text = "Who will win?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpUserchoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgPlayer);
            this.Name = "Form1";
            this.Text = "RPS Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.grpUserchoice.ResumeLayout(false);
            this.grpUserchoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.GroupBox grpUserchoice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblOutcome;
    }
}

