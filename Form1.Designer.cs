namespace MiniDiceGame
{
    partial class FrmMiniDiceGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            LblOpponentDiceNumOne = new Label();
            LblOpponentDiceNumTwo = new Label();
            LblPlayerDiceNumOne = new Label();
            LblPlayerDiceNumTwo = new Label();
            LblOpponentsDice = new Label();
            LblYourDice = new Label();
            LblPlayAgain = new Label();
            BtnStartGame = new Button();
            BtnYes = new Button();
            BtnNo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Location = new Point(72, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox2.Location = new Point(271, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 104);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox3.Location = new Point(72, 304);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 104);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox4.Location = new Point(271, 304);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 104);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // LblOpponentDiceNumOne
            // 
            LblOpponentDiceNumOne.AutoSize = true;
            LblOpponentDiceNumOne.Location = new Point(106, 72);
            LblOpponentDiceNumOne.Name = "LblOpponentDiceNumOne";
            LblOpponentDiceNumOne.Size = new Size(58, 15);
            LblOpponentDiceNumOne.TabIndex = 4;
            LblOpponentDiceNumOne.Text = "Unknown";
            // 
            // LblOpponentDiceNumTwo
            // 
            LblOpponentDiceNumTwo.AutoSize = true;
            LblOpponentDiceNumTwo.Location = new Point(304, 72);
            LblOpponentDiceNumTwo.Name = "LblOpponentDiceNumTwo";
            LblOpponentDiceNumTwo.Size = new Size(58, 15);
            LblOpponentDiceNumTwo.TabIndex = 5;
            LblOpponentDiceNumTwo.Text = "Unknown";
            // 
            // LblPlayerDiceNumOne
            // 
            LblPlayerDiceNumOne.AutoSize = true;
            LblPlayerDiceNumOne.Location = new Point(106, 350);
            LblPlayerDiceNumOne.Name = "LblPlayerDiceNumOne";
            LblPlayerDiceNumOne.Size = new Size(58, 15);
            LblPlayerDiceNumOne.TabIndex = 6;
            LblPlayerDiceNumOne.Text = "Unknown";
            // 
            // LblPlayerDiceNumTwo
            // 
            LblPlayerDiceNumTwo.AutoSize = true;
            LblPlayerDiceNumTwo.Location = new Point(304, 350);
            LblPlayerDiceNumTwo.Name = "LblPlayerDiceNumTwo";
            LblPlayerDiceNumTwo.Size = new Size(58, 15);
            LblPlayerDiceNumTwo.TabIndex = 7;
            LblPlayerDiceNumTwo.Text = "Unknown";
            // 
            // LblOpponentsDice
            // 
            LblOpponentsDice.Location = new Point(203, 72);
            LblOpponentsDice.Name = "LblOpponentsDice";
            LblOpponentsDice.Size = new Size(66, 39);
            LblOpponentsDice.TabIndex = 8;
            LblOpponentsDice.Text = "Opponents       dice";
            // 
            // LblYourDice
            // 
            LblYourDice.AutoSize = true;
            LblYourDice.Location = new Point(207, 350);
            LblYourDice.Name = "LblYourDice";
            LblYourDice.Size = new Size(56, 15);
            LblYourDice.TabIndex = 9;
            LblYourDice.Text = "Your dice";
            // 
            // LblPlayAgain
            // 
            LblPlayAgain.AutoSize = true;
            LblPlayAgain.Location = new Point(209, 176);
            LblPlayAgain.Name = "LblPlayAgain";
            LblPlayAgain.Size = new Size(66, 15);
            LblPlayAgain.TabIndex = 10;
            LblPlayAgain.Text = "Play again?";
            LblPlayAgain.Visible = false;
            // 
            // BtnStartGame
            // 
            BtnStartGame.Location = new Point(199, 203);
            BtnStartGame.Name = "BtnStartGame";
            BtnStartGame.Size = new Size(81, 41);
            BtnStartGame.TabIndex = 11;
            BtnStartGame.Text = "Start Game";
            BtnStartGame.UseVisualStyleBackColor = true;
            // 
            // BtnYes
            // 
            BtnYes.Location = new Point(101, 197);
            BtnYes.Name = "BtnYes";
            BtnYes.Size = new Size(92, 53);
            BtnYes.TabIndex = 12;
            BtnYes.Text = "Yes";
            BtnYes.UseVisualStyleBackColor = true;
            BtnYes.Visible = false;
            // 
            // BtnNo
            // 
            BtnNo.Location = new Point(286, 197);
            BtnNo.Name = "BtnNo";
            BtnNo.Size = new Size(92, 53);
            BtnNo.TabIndex = 13;
            BtnNo.Text = "No";
            BtnNo.UseVisualStyleBackColor = true;
            BtnNo.Visible = false;
            // 
            // FrmMiniDiceGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 477);
            Controls.Add(BtnNo);
            Controls.Add(BtnYes);
            Controls.Add(BtnStartGame);
            Controls.Add(LblPlayAgain);
            Controls.Add(LblYourDice);
            Controls.Add(LblOpponentsDice);
            Controls.Add(LblPlayerDiceNumTwo);
            Controls.Add(LblPlayerDiceNumOne);
            Controls.Add(LblOpponentDiceNumTwo);
            Controls.Add(LblOpponentDiceNumOne);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FrmMiniDiceGame";
            Text = "Mini Dice Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label LblOpponentDiceNumOne;
        private Label LblOpponentDiceNumTwo;
        private Label LblPlayerDiceNumOne;
        private Label LblPlayerDiceNumTwo;
        private Label LblOpponentsDice;
        private Label LblYourDice;
        private Label LblPlayAgain;
        private Button BtnStartGame;
        private Button BtnYes;
        private Button BtnNo;
    }
}
