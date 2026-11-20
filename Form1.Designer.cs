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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(72, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(271, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 104);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(72, 301);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 104);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(271, 301);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 104);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Unknown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 72);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Unknown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 350);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Unknown";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 350);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Unknown";
            // 
            // label5
            // 
            label5.Location = new Point(203, 72);
            label5.Name = "label5";
            label5.Size = new Size(66, 39);
            label5.TabIndex = 8;
            label5.Text = "Opponents       dice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 350);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "Your dice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 176);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 10;
            label7.Text = "Play again?";
            label7.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(199, 203);
            button1.Name = "button1";
            button1.Size = new Size(81, 41);
            button1.TabIndex = 11;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(101, 197);
            button2.Name = "button2";
            button2.Size = new Size(92, 53);
            button2.TabIndex = 12;
            button2.Text = "Yes";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(286, 197);
            button3.Name = "button3";
            button3.Size = new Size(92, 53);
            button3.TabIndex = 13;
            button3.Text = "No";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // FrmMiniDiceGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 477);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
