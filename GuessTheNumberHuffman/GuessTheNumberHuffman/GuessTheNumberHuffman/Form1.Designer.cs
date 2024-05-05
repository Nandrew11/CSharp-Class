namespace GuessTheNumberHuffman
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
            this.label1 = new System.Windows.Forms.Label();
            this.TryButton = new System.Windows.Forms.Button();
            this.TellMeButton = new System.Windows.Forms.Button();
            this.NewNumberButton = new System.Windows.Forms.Button();
            this.GuessTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfGuessesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "The computer has chosen a number between 1 and 100. Enter your guess below and cl" +
    "ick Try until you guess correctly.";
            // 
            // TryButton
            // 
            this.TryButton.Location = new System.Drawing.Point(371, 248);
            this.TryButton.Name = "TryButton";
            this.TryButton.Size = new System.Drawing.Size(75, 23);
            this.TryButton.TabIndex = 1;
            this.TryButton.Text = "Try";
            this.TryButton.UseVisualStyleBackColor = true;
            this.TryButton.Click += new System.EventHandler(this.TryButton_Click);
            // 
            // TellMeButton
            // 
            this.TellMeButton.Location = new System.Drawing.Point(361, 288);
            this.TellMeButton.Name = "TellMeButton";
            this.TellMeButton.Size = new System.Drawing.Size(90, 23);
            this.TellMeButton.TabIndex = 2;
            this.TellMeButton.Text = "Just Tell ME!!!";
            this.TellMeButton.UseVisualStyleBackColor = true;
            this.TellMeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewNumberButton
            // 
            this.NewNumberButton.Location = new System.Drawing.Point(347, 317);
            this.NewNumberButton.Name = "NewNumberButton";
            this.NewNumberButton.Size = new System.Drawing.Size(124, 23);
            this.NewNumberButton.TabIndex = 3;
            this.NewNumberButton.Text = "New Number";
            this.NewNumberButton.UseVisualStyleBackColor = true;
            this.NewNumberButton.Click += new System.EventHandler(this.NewNumberButton_Click);
            // 
            // GuessTextbox
            // 
            this.GuessTextbox.Location = new System.Drawing.Point(361, 207);
            this.GuessTextbox.Name = "GuessTextbox";
            this.GuessTextbox.Size = new System.Drawing.Size(100, 20);
            this.GuessTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your guess:";
            // 
            // NumberOfGuessesLabel
            // 
            this.NumberOfGuessesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOfGuessesLabel.Location = new System.Drawing.Point(122, 418);
            this.NumberOfGuessesLabel.Name = "NumberOfGuessesLabel";
            this.NumberOfGuessesLabel.Size = new System.Drawing.Size(100, 23);
            this.NumberOfGuessesLabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Guesses:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberOfGuessesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuessTextbox);
            this.Controls.Add(this.NewNumberButton);
            this.Controls.Add(this.TellMeButton);
            this.Controls.Add(this.TryButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TryButton;
        private System.Windows.Forms.Button TellMeButton;
        private System.Windows.Forms.Button NewNumberButton;
        private System.Windows.Forms.TextBox GuessTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumberOfGuessesLabel;
        private System.Windows.Forms.Label label3;
    }
}

