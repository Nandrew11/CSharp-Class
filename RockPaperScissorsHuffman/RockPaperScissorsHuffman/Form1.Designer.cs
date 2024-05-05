namespace RockPaperScissorsHuffman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.ScissorsBox = new System.Windows.Forms.PictureBox();
            this.PaperBox = new System.Windows.Forms.PictureBox();
            this.CPUBox = new System.Windows.Forms.PictureBox();
            this.RockBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WinnerLabel.Location = new System.Drawing.Point(205, 393);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(375, 23);
            this.WinnerLabel.TabIndex = 4;
            // 
            // ScissorsBox
            // 
            this.ScissorsBox.Image = global::RockPaperScissorsHuffman.Properties.Resources.scissors_4730862;
            this.ScissorsBox.Location = new System.Drawing.Point(531, 232);
            this.ScissorsBox.Name = "ScissorsBox";
            this.ScissorsBox.Size = new System.Drawing.Size(156, 95);
            this.ScissorsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScissorsBox.TabIndex = 3;
            this.ScissorsBox.TabStop = false;
            this.ScissorsBox.Click += new System.EventHandler(this.ScissorsBox_Click);
            // 
            // PaperBox
            // 
            this.PaperBox.Image = ((System.Drawing.Image)(resources.GetObject("PaperBox.Image")));
            this.PaperBox.Location = new System.Drawing.Point(311, 232);
            this.PaperBox.Name = "PaperBox";
            this.PaperBox.Size = new System.Drawing.Size(172, 95);
            this.PaperBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaperBox.TabIndex = 2;
            this.PaperBox.TabStop = false;
            this.PaperBox.Click += new System.EventHandler(this.PaperBox_Click);
            // 
            // CPUBox
            // 
            this.CPUBox.Location = new System.Drawing.Point(295, 26);
            this.CPUBox.Name = "CPUBox";
            this.CPUBox.Size = new System.Drawing.Size(203, 134);
            this.CPUBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CPUBox.TabIndex = 1;
            this.CPUBox.TabStop = false;
            // 
            // RockBox
            // 
            this.RockBox.Image = global::RockPaperScissorsHuffman.Properties.Resources.istockphoto_170215830_612x612;
            this.RockBox.Location = new System.Drawing.Point(104, 232);
            this.RockBox.Name = "RockBox";
            this.RockBox.Size = new System.Drawing.Size(155, 95);
            this.RockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RockBox.TabIndex = 0;
            this.RockBox.TabStop = false;
            this.RockBox.Click += new System.EventHandler(this.RockBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Computer   ---->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.ScissorsBox);
            this.Controls.Add(this.PaperBox);
            this.Controls.Add(this.CPUBox);
            this.Controls.Add(this.RockBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RockBox;
        private System.Windows.Forms.PictureBox CPUBox;
        private System.Windows.Forms.PictureBox PaperBox;
        private System.Windows.Forms.PictureBox ScissorsBox;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Label label1;
    }
}

