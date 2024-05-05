namespace DistanceConverterHuffman
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
            this.DistanceTextbox = new System.Windows.Forms.TextBox();
            this.FromgroupBox1 = new System.Windows.Forms.GroupBox();
            this.TogroupBox2 = new System.Windows.Forms.GroupBox();
            this.FromlistBox = new System.Windows.Forms.ListBox();
            this.ToListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertedDistanceLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FromgroupBox1.SuspendLayout();
            this.TogroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // DistanceTextbox
            // 
            this.DistanceTextbox.Location = new System.Drawing.Point(203, 43);
            this.DistanceTextbox.Name = "DistanceTextbox";
            this.DistanceTextbox.Size = new System.Drawing.Size(100, 20);
            this.DistanceTextbox.TabIndex = 1;
            // 
            // FromgroupBox1
            // 
            this.FromgroupBox1.Controls.Add(this.FromlistBox);
            this.FromgroupBox1.Location = new System.Drawing.Point(41, 103);
            this.FromgroupBox1.Name = "FromgroupBox1";
            this.FromgroupBox1.Size = new System.Drawing.Size(200, 100);
            this.FromgroupBox1.TabIndex = 2;
            this.FromgroupBox1.TabStop = false;
            this.FromgroupBox1.Text = "From";
            // 
            // TogroupBox2
            // 
            this.TogroupBox2.Controls.Add(this.ToListbox);
            this.TogroupBox2.Location = new System.Drawing.Point(281, 103);
            this.TogroupBox2.Name = "TogroupBox2";
            this.TogroupBox2.Size = new System.Drawing.Size(200, 100);
            this.TogroupBox2.TabIndex = 3;
            this.TogroupBox2.TabStop = false;
            this.TogroupBox2.Text = "To";
            // 
            // FromlistBox
            // 
            this.FromlistBox.FormattingEnabled = true;
            this.FromlistBox.Location = new System.Drawing.Point(15, 19);
            this.FromlistBox.Name = "FromlistBox";
            this.FromlistBox.Size = new System.Drawing.Size(120, 56);
            this.FromlistBox.TabIndex = 0;
            // 
            // ToListbox
            // 
            this.ToListbox.FormattingEnabled = true;
            this.ToListbox.Location = new System.Drawing.Point(22, 19);
            this.ToListbox.Name = "ToListbox";
            this.ToListbox.Size = new System.Drawing.Size(120, 56);
            this.ToListbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted Distance:";
            // 
            // ConvertedDistanceLabel
            // 
            this.ConvertedDistanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConvertedDistanceLabel.Location = new System.Drawing.Point(166, 281);
            this.ConvertedDistanceLabel.Name = "ConvertedDistanceLabel";
            this.ConvertedDistanceLabel.Size = new System.Drawing.Size(100, 23);
            this.ConvertedDistanceLabel.TabIndex = 5;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(77, 339);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(166, 381);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(263, 338);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertedDistanceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TogroupBox2);
            this.Controls.Add(this.FromgroupBox1);
            this.Controls.Add(this.DistanceTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FromgroupBox1.ResumeLayout(false);
            this.TogroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DistanceTextbox;
        private System.Windows.Forms.GroupBox FromgroupBox1;
        private System.Windows.Forms.ListBox FromlistBox;
        private System.Windows.Forms.GroupBox TogroupBox2;
        private System.Windows.Forms.ListBox ToListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ConvertedDistanceLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

