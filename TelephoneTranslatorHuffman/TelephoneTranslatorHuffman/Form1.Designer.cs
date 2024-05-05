namespace TelephoneTranslatorHuffman
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
            this.ConvertPhoneNumberButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.ConvertedNumberLabel = new System.Windows.Forms.Label();
            this.EnterNumberLabel = new System.Windows.Forms.Label();
            this.ClearScreenButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertPhoneNumberButton
            // 
            this.ConvertPhoneNumberButton.Location = new System.Drawing.Point(93, 153);
            this.ConvertPhoneNumberButton.Name = "ConvertPhoneNumberButton";
            this.ConvertPhoneNumberButton.Size = new System.Drawing.Size(129, 40);
            this.ConvertPhoneNumberButton.TabIndex = 6;
            this.ConvertPhoneNumberButton.Text = "Display Numeric Phone Number";
            this.ConvertPhoneNumberButton.UseVisualStyleBackColor = true;
            this.ConvertPhoneNumberButton.Click += new System.EventHandler(this.ConvertPhoneNumberButton_Click);
            // 
            // PhoneNumberTextbox
            // 
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(93, 108);
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(129, 20);
            this.PhoneNumberTextbox.TabIndex = 7;
            // 
            // ConvertedNumberLabel
            // 
            this.ConvertedNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConvertedNumberLabel.Location = new System.Drawing.Point(93, 223);
            this.ConvertedNumberLabel.Name = "ConvertedNumberLabel";
            this.ConvertedNumberLabel.Size = new System.Drawing.Size(129, 23);
            this.ConvertedNumberLabel.TabIndex = 8;
            // 
            // EnterNumberLabel
            // 
            this.EnterNumberLabel.Location = new System.Drawing.Point(120, 70);
            this.EnterNumberLabel.Name = "EnterNumberLabel";
            this.EnterNumberLabel.Size = new System.Drawing.Size(84, 35);
            this.EnterNumberLabel.TabIndex = 9;
            this.EnterNumberLabel.Text = "Enter Phone Number Below:";
            // 
            // ClearScreenButton
            // 
            this.ClearScreenButton.Location = new System.Drawing.Point(93, 270);
            this.ClearScreenButton.Name = "ClearScreenButton";
            this.ClearScreenButton.Size = new System.Drawing.Size(129, 34);
            this.ClearScreenButton.TabIndex = 10;
            this.ClearScreenButton.Text = "Clear screen for new entry.";
            this.ClearScreenButton.UseVisualStyleBackColor = true;
            this.ClearScreenButton.Click += new System.EventHandler(this.ClearScreenButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(123, 322);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearScreenButton);
            this.Controls.Add(this.EnterNumberLabel);
            this.Controls.Add(this.ConvertedNumberLabel);
            this.Controls.Add(this.PhoneNumberTextbox);
            this.Controls.Add(this.ConvertPhoneNumberButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertPhoneNumberButton;
        private System.Windows.Forms.TextBox PhoneNumberTextbox;
        private System.Windows.Forms.Label ConvertedNumberLabel;
        private System.Windows.Forms.Label EnterNumberLabel;
        private System.Windows.Forms.Button ClearScreenButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

