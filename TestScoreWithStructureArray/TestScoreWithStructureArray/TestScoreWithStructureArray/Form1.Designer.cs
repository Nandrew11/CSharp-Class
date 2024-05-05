
namespace TestScoreWithStructureArray
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
            this.StudentNameCombobox = new System.Windows.Forms.ComboBox();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.UpdateScoresGroupbox = new System.Windows.Forms.GroupBox();
            this.UpdateFinalTextbox = new System.Windows.Forms.TextBox();
            this.UpdateMidtermTextbox = new System.Windows.Forms.TextBox();
            this.UpdateFinalBtn = new System.Windows.Forms.Button();
            this.UpdateMidtermBtn = new System.Windows.Forms.Button();
            this.UpdateFinalLabel = new System.Windows.Forms.Label();
            this.UpdateMidLabel = new System.Windows.Forms.Label();
            this.DisplayScoresGroupbox = new System.Windows.Forms.GroupBox();
            this.DisplaySelectedStudentBtn = new System.Windows.Forms.Button();
            this.FinalDisplayDataLabel = new System.Windows.Forms.Label();
            this.MidtermDisplayDataLabel = new System.Windows.Forms.Label();
            this.FinalDisplayLabel = new System.Windows.Forms.Label();
            this.MidtermDisplayLabel = new System.Windows.Forms.Label();
            this.DisplayTotalsBtn = new System.Windows.Forms.Button();
            this.MidtermLookupRadBtn = new System.Windows.Forms.RadioButton();
            this.FinalLookupRadBtn = new System.Windows.Forms.RadioButton();
            this.FinalsAvgRadBtn = new System.Windows.Forms.RadioButton();
            this.MidtermAvgRadBtn = new System.Windows.Forms.RadioButton();
            this.AllAverageRadBtn = new System.Windows.Forms.RadioButton();
            this.UpdateScoresGroupbox.SuspendLayout();
            this.DisplayScoresGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentNameCombobox
            // 
            this.StudentNameCombobox.FormattingEnabled = true;
            this.StudentNameCombobox.Location = new System.Drawing.Point(579, 99);
            this.StudentNameCombobox.Name = "StudentNameCombobox";
            this.StudentNameCombobox.Size = new System.Drawing.Size(121, 21);
            this.StudentNameCombobox.TabIndex = 19;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(486, 104);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(78, 13);
            this.StudentNameLabel.TabIndex = 18;
            this.StudentNameLabel.Text = "Student Name:";
            // 
            // UpdateScoresGroupbox
            // 
            this.UpdateScoresGroupbox.Controls.Add(this.UpdateFinalTextbox);
            this.UpdateScoresGroupbox.Controls.Add(this.UpdateMidtermTextbox);
            this.UpdateScoresGroupbox.Controls.Add(this.UpdateFinalBtn);
            this.UpdateScoresGroupbox.Controls.Add(this.UpdateMidtermBtn);
            this.UpdateScoresGroupbox.Controls.Add(this.UpdateFinalLabel);
            this.UpdateScoresGroupbox.Controls.Add(this.UpdateMidLabel);
            this.UpdateScoresGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateScoresGroupbox.Location = new System.Drawing.Point(116, 382);
            this.UpdateScoresGroupbox.Name = "UpdateScoresGroupbox";
            this.UpdateScoresGroupbox.Size = new System.Drawing.Size(326, 150);
            this.UpdateScoresGroupbox.TabIndex = 17;
            this.UpdateScoresGroupbox.TabStop = false;
            this.UpdateScoresGroupbox.Text = "Update Selected Student\'s Scores";
            // 
            // UpdateFinalTextbox
            // 
            this.UpdateFinalTextbox.Location = new System.Drawing.Point(184, 69);
            this.UpdateFinalTextbox.Name = "UpdateFinalTextbox";
            this.UpdateFinalTextbox.Size = new System.Drawing.Size(100, 21);
            this.UpdateFinalTextbox.TabIndex = 7;
            // 
            // UpdateMidtermTextbox
            // 
            this.UpdateMidtermTextbox.Location = new System.Drawing.Point(38, 69);
            this.UpdateMidtermTextbox.Name = "UpdateMidtermTextbox";
            this.UpdateMidtermTextbox.Size = new System.Drawing.Size(100, 21);
            this.UpdateMidtermTextbox.TabIndex = 6;
            // 
            // UpdateFinalBtn
            // 
            this.UpdateFinalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFinalBtn.Location = new System.Drawing.Point(175, 96);
            this.UpdateFinalBtn.Name = "UpdateFinalBtn";
            this.UpdateFinalBtn.Size = new System.Drawing.Size(119, 23);
            this.UpdateFinalBtn.TabIndex = 5;
            this.UpdateFinalBtn.Text = "Update Final";
            this.UpdateFinalBtn.UseVisualStyleBackColor = true;
            this.UpdateFinalBtn.Click += new System.EventHandler(this.UpdateFinalBtn_Click);
            // 
            // UpdateMidtermBtn
            // 
            this.UpdateMidtermBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMidtermBtn.Location = new System.Drawing.Point(28, 96);
            this.UpdateMidtermBtn.Name = "UpdateMidtermBtn";
            this.UpdateMidtermBtn.Size = new System.Drawing.Size(119, 23);
            this.UpdateMidtermBtn.TabIndex = 4;
            this.UpdateMidtermBtn.Text = "Update Midterm";
            this.UpdateMidtermBtn.UseVisualStyleBackColor = true;
            this.UpdateMidtermBtn.Click += new System.EventHandler(this.UpdateMidtermBtn_Click);
            // 
            // UpdateFinalLabel
            // 
            this.UpdateFinalLabel.AutoSize = true;
            this.UpdateFinalLabel.Location = new System.Drawing.Point(213, 42);
            this.UpdateFinalLabel.Name = "UpdateFinalLabel";
            this.UpdateFinalLabel.Size = new System.Drawing.Size(39, 15);
            this.UpdateFinalLabel.TabIndex = 1;
            this.UpdateFinalLabel.Text = "Final";
            // 
            // UpdateMidLabel
            // 
            this.UpdateMidLabel.AutoSize = true;
            this.UpdateMidLabel.Location = new System.Drawing.Point(52, 42);
            this.UpdateMidLabel.Name = "UpdateMidLabel";
            this.UpdateMidLabel.Size = new System.Drawing.Size(60, 15);
            this.UpdateMidLabel.TabIndex = 0;
            this.UpdateMidLabel.Text = "Midterm";
            // 
            // DisplayScoresGroupbox
            // 
            this.DisplayScoresGroupbox.Controls.Add(this.DisplaySelectedStudentBtn);
            this.DisplayScoresGroupbox.Controls.Add(this.FinalDisplayDataLabel);
            this.DisplayScoresGroupbox.Controls.Add(this.MidtermDisplayDataLabel);
            this.DisplayScoresGroupbox.Controls.Add(this.FinalDisplayLabel);
            this.DisplayScoresGroupbox.Controls.Add(this.MidtermDisplayLabel);
            this.DisplayScoresGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayScoresGroupbox.Location = new System.Drawing.Point(116, 211);
            this.DisplayScoresGroupbox.Name = "DisplayScoresGroupbox";
            this.DisplayScoresGroupbox.Size = new System.Drawing.Size(326, 150);
            this.DisplayScoresGroupbox.TabIndex = 16;
            this.DisplayScoresGroupbox.TabStop = false;
            this.DisplayScoresGroupbox.Text = "Display Selected Student\'s Scores";
            // 
            // DisplaySelectedStudentBtn
            // 
            this.DisplaySelectedStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaySelectedStudentBtn.Location = new System.Drawing.Point(120, 106);
            this.DisplaySelectedStudentBtn.Name = "DisplaySelectedStudentBtn";
            this.DisplaySelectedStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplaySelectedStudentBtn.TabIndex = 4;
            this.DisplaySelectedStudentBtn.Text = "Display";
            this.DisplaySelectedStudentBtn.UseVisualStyleBackColor = true;
            this.DisplaySelectedStudentBtn.Click += new System.EventHandler(this.DisplaySelectedStudentBtn_Click);
            // 
            // FinalDisplayDataLabel
            // 
            this.FinalDisplayDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalDisplayDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalDisplayDataLabel.Location = new System.Drawing.Point(190, 67);
            this.FinalDisplayDataLabel.Name = "FinalDisplayDataLabel";
            this.FinalDisplayDataLabel.Size = new System.Drawing.Size(87, 23);
            this.FinalDisplayDataLabel.TabIndex = 3;
            // 
            // MidtermDisplayDataLabel
            // 
            this.MidtermDisplayDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MidtermDisplayDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidtermDisplayDataLabel.Location = new System.Drawing.Point(41, 67);
            this.MidtermDisplayDataLabel.Name = "MidtermDisplayDataLabel";
            this.MidtermDisplayDataLabel.Size = new System.Drawing.Size(87, 23);
            this.MidtermDisplayDataLabel.TabIndex = 2;
            // 
            // FinalDisplayLabel
            // 
            this.FinalDisplayLabel.AutoSize = true;
            this.FinalDisplayLabel.Location = new System.Drawing.Point(213, 42);
            this.FinalDisplayLabel.Name = "FinalDisplayLabel";
            this.FinalDisplayLabel.Size = new System.Drawing.Size(39, 15);
            this.FinalDisplayLabel.TabIndex = 1;
            this.FinalDisplayLabel.Text = "Final";
            // 
            // MidtermDisplayLabel
            // 
            this.MidtermDisplayLabel.AutoSize = true;
            this.MidtermDisplayLabel.Location = new System.Drawing.Point(52, 42);
            this.MidtermDisplayLabel.Name = "MidtermDisplayLabel";
            this.MidtermDisplayLabel.Size = new System.Drawing.Size(60, 15);
            this.MidtermDisplayLabel.TabIndex = 0;
            this.MidtermDisplayLabel.Text = "Midterm";
            // 
            // DisplayTotalsBtn
            // 
            this.DisplayTotalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisplayTotalsBtn.Location = new System.Drawing.Point(269, 99);
            this.DisplayTotalsBtn.Name = "DisplayTotalsBtn";
            this.DisplayTotalsBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayTotalsBtn.TabIndex = 15;
            this.DisplayTotalsBtn.Text = "Display";
            this.DisplayTotalsBtn.UseVisualStyleBackColor = true;
            this.DisplayTotalsBtn.Click += new System.EventHandler(this.DisplayTotalsBtn_Click);
            // 
            // MidtermLookupRadBtn
            // 
            this.MidtermLookupRadBtn.AutoSize = true;
            this.MidtermLookupRadBtn.Location = new System.Drawing.Point(101, 131);
            this.MidtermLookupRadBtn.Name = "MidtermLookupRadBtn";
            this.MidtermLookupRadBtn.Size = new System.Drawing.Size(116, 17);
            this.MidtermLookupRadBtn.TabIndex = 14;
            this.MidtermLookupRadBtn.TabStop = true;
            this.MidtermLookupRadBtn.Text = "Find Midterm Score";
            this.MidtermLookupRadBtn.UseVisualStyleBackColor = true;
            // 
            // FinalLookupRadBtn
            // 
            this.FinalLookupRadBtn.AutoSize = true;
            this.FinalLookupRadBtn.Location = new System.Drawing.Point(101, 165);
            this.FinalLookupRadBtn.Name = "FinalLookupRadBtn";
            this.FinalLookupRadBtn.Size = new System.Drawing.Size(101, 17);
            this.FinalLookupRadBtn.TabIndex = 13;
            this.FinalLookupRadBtn.TabStop = true;
            this.FinalLookupRadBtn.Text = "Find Final Score";
            this.FinalLookupRadBtn.UseVisualStyleBackColor = true;
            // 
            // FinalsAvgRadBtn
            // 
            this.FinalsAvgRadBtn.AutoSize = true;
            this.FinalsAvgRadBtn.Location = new System.Drawing.Point(101, 99);
            this.FinalsAvgRadBtn.Name = "FinalsAvgRadBtn";
            this.FinalsAvgRadBtn.Size = new System.Drawing.Size(107, 17);
            this.FinalsAvgRadBtn.TabIndex = 12;
            this.FinalsAvgRadBtn.TabStop = true;
            this.FinalsAvgRadBtn.Text = "Average of Finals";
            this.FinalsAvgRadBtn.UseVisualStyleBackColor = true;
            // 
            // MidtermAvgRadBtn
            // 
            this.MidtermAvgRadBtn.AutoSize = true;
            this.MidtermAvgRadBtn.Location = new System.Drawing.Point(101, 64);
            this.MidtermAvgRadBtn.Name = "MidtermAvgRadBtn";
            this.MidtermAvgRadBtn.Size = new System.Drawing.Size(122, 17);
            this.MidtermAvgRadBtn.TabIndex = 11;
            this.MidtermAvgRadBtn.TabStop = true;
            this.MidtermAvgRadBtn.Text = "Average of Midterms";
            this.MidtermAvgRadBtn.UseVisualStyleBackColor = true;
            // 
            // AllAverageRadBtn
            // 
            this.AllAverageRadBtn.AutoSize = true;
            this.AllAverageRadBtn.Location = new System.Drawing.Point(101, 30);
            this.AllAverageRadBtn.Name = "AllAverageRadBtn";
            this.AllAverageRadBtn.Size = new System.Drawing.Size(115, 17);
            this.AllAverageRadBtn.TabIndex = 10;
            this.AllAverageRadBtn.TabStop = true;
            this.AllAverageRadBtn.Text = "Average of all tests";
            this.AllAverageRadBtn.UseVisualStyleBackColor = true;
            this.AllAverageRadBtn.CheckedChanged += new System.EventHandler(this.AllAverageRadBtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.StudentNameCombobox);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.UpdateScoresGroupbox);
            this.Controls.Add(this.DisplayScoresGroupbox);
            this.Controls.Add(this.DisplayTotalsBtn);
            this.Controls.Add(this.MidtermLookupRadBtn);
            this.Controls.Add(this.FinalLookupRadBtn);
            this.Controls.Add(this.FinalsAvgRadBtn);
            this.Controls.Add(this.MidtermAvgRadBtn);
            this.Controls.Add(this.AllAverageRadBtn);
            this.Name = "Form1";
            this.Text = "Student Test Score Lookup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UpdateScoresGroupbox.ResumeLayout(false);
            this.UpdateScoresGroupbox.PerformLayout();
            this.DisplayScoresGroupbox.ResumeLayout(false);
            this.DisplayScoresGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentNameCombobox;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.GroupBox UpdateScoresGroupbox;
        private System.Windows.Forms.TextBox UpdateFinalTextbox;
        private System.Windows.Forms.TextBox UpdateMidtermTextbox;
        private System.Windows.Forms.Button UpdateFinalBtn;
        private System.Windows.Forms.Button UpdateMidtermBtn;
        private System.Windows.Forms.Label UpdateFinalLabel;
        private System.Windows.Forms.Label UpdateMidLabel;
        private System.Windows.Forms.GroupBox DisplayScoresGroupbox;
        private System.Windows.Forms.Button DisplaySelectedStudentBtn;
        private System.Windows.Forms.Label FinalDisplayDataLabel;
        private System.Windows.Forms.Label MidtermDisplayDataLabel;
        private System.Windows.Forms.Label FinalDisplayLabel;
        private System.Windows.Forms.Label MidtermDisplayLabel;
        private System.Windows.Forms.Button DisplayTotalsBtn;
        private System.Windows.Forms.RadioButton MidtermLookupRadBtn;
        private System.Windows.Forms.RadioButton FinalLookupRadBtn;
        private System.Windows.Forms.RadioButton FinalsAvgRadBtn;
        private System.Windows.Forms.RadioButton MidtermAvgRadBtn;
        private System.Windows.Forms.RadioButton AllAverageRadBtn;
    }
}

