namespace JoesAutomotiveHuffman
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalFeesLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ServiceandLaborLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PartsLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.LaborTextBox = new System.Windows.Forms.TextBox();
            this.PartsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MiscGroupBox = new System.Windows.Forms.GroupBox();
            this.TireCheckBox = new System.Windows.Forms.CheckBox();
            this.MufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.InspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.FlushesGroupBox = new System.Windows.Forms.GroupBox();
            this.TransmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.RadiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.OilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.LubeCheckBox = new System.Windows.Forms.CheckBox();
            this.OilCheckBox = new System.Windows.Forms.CheckBox();
            this.SummaryGroupBox.SuspendLayout();
            this.PartsLaborGroupBox.SuspendLayout();
            this.MiscGroupBox.SuspendLayout();
            this.FlushesGroupBox.SuspendLayout();
            this.OilLubeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(448, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 31;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(364, 383);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 30;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(279, 383);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 29;
            this.CalcButton.Text = "Calculate Total";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.TotalFeesLabel);
            this.SummaryGroupBox.Controls.Add(this.TaxLabel);
            this.SummaryGroupBox.Controls.Add(this.PartsLabel);
            this.SummaryGroupBox.Controls.Add(this.ServiceandLaborLabel);
            this.SummaryGroupBox.Controls.Add(this.label6);
            this.SummaryGroupBox.Controls.Add(this.label5);
            this.SummaryGroupBox.Controls.Add(this.label4);
            this.SummaryGroupBox.Controls.Add(this.label3);
            this.SummaryGroupBox.Location = new System.Drawing.Point(230, 230);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(340, 135);
            this.SummaryGroupBox.TabIndex = 28;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary";
            // 
            // TotalFeesLabel
            // 
            this.TotalFeesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalFeesLabel.Location = new System.Drawing.Point(109, 95);
            this.TotalFeesLabel.Name = "TotalFeesLabel";
            this.TotalFeesLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalFeesLabel.TabIndex = 6;
            this.TotalFeesLabel.Text = " ";
            // 
            // TaxLabel
            // 
            this.TaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaxLabel.Location = new System.Drawing.Point(109, 69);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(100, 23);
            this.TaxLabel.TabIndex = 5;
            this.TaxLabel.Text = " ";
            // 
            // PartsLabel
            // 
            this.PartsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PartsLabel.Location = new System.Drawing.Point(109, 42);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(100, 23);
            this.PartsLabel.TabIndex = 5;
            this.PartsLabel.Text = " ";
            // 
            // ServiceandLaborLabel
            // 
            this.ServiceandLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServiceandLaborLabel.Location = new System.Drawing.Point(109, 14);
            this.ServiceandLaborLabel.Name = "ServiceandLaborLabel";
            this.ServiceandLaborLabel.Size = new System.Drawing.Size(100, 23);
            this.ServiceandLaborLabel.TabIndex = 4;
            this.ServiceandLaborLabel.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on parts)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service and Labor";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // PartsLaborGroupBox
            // 
            this.PartsLaborGroupBox.Controls.Add(this.LaborTextBox);
            this.PartsLaborGroupBox.Controls.Add(this.PartsTextBox);
            this.PartsLaborGroupBox.Controls.Add(this.label2);
            this.PartsLaborGroupBox.Controls.Add(this.label1);
            this.PartsLaborGroupBox.Location = new System.Drawing.Point(397, 123);
            this.PartsLaborGroupBox.Name = "PartsLaborGroupBox";
            this.PartsLaborGroupBox.Size = new System.Drawing.Size(173, 100);
            this.PartsLaborGroupBox.TabIndex = 27;
            this.PartsLaborGroupBox.TabStop = false;
            this.PartsLaborGroupBox.Text = "Parts and Labor";
            // 
            // LaborTextBox
            // 
            this.LaborTextBox.Location = new System.Drawing.Point(77, 57);
            this.LaborTextBox.Name = "LaborTextBox";
            this.LaborTextBox.Size = new System.Drawing.Size(49, 20);
            this.LaborTextBox.TabIndex = 3;
            // 
            // PartsTextBox
            // 
            this.PartsTextBox.Location = new System.Drawing.Point(77, 24);
            this.PartsTextBox.Name = "PartsTextBox";
            this.PartsTextBox.Size = new System.Drawing.Size(49, 20);
            this.PartsTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // MiscGroupBox
            // 
            this.MiscGroupBox.Controls.Add(this.TireCheckBox);
            this.MiscGroupBox.Controls.Add(this.MufflerCheckBox);
            this.MiscGroupBox.Controls.Add(this.InspectionCheckBox);
            this.MiscGroupBox.Location = new System.Drawing.Point(230, 123);
            this.MiscGroupBox.Name = "MiscGroupBox";
            this.MiscGroupBox.Size = new System.Drawing.Size(160, 100);
            this.MiscGroupBox.TabIndex = 26;
            this.MiscGroupBox.TabStop = false;
            this.MiscGroupBox.Text = "Misc";
            // 
            // TireCheckBox
            // 
            this.TireCheckBox.AutoSize = true;
            this.TireCheckBox.Location = new System.Drawing.Point(7, 68);
            this.TireCheckBox.Name = "TireCheckBox";
            this.TireCheckBox.Size = new System.Drawing.Size(129, 17);
            this.TireCheckBox.TabIndex = 2;
            this.TireCheckBox.Text = "Tire Rotation ($20.00)";
            this.TireCheckBox.UseVisualStyleBackColor = true;
            // 
            // MufflerCheckBox
            // 
            this.MufflerCheckBox.AutoSize = true;
            this.MufflerCheckBox.Location = new System.Drawing.Point(7, 44);
            this.MufflerCheckBox.Name = "MufflerCheckBox";
            this.MufflerCheckBox.Size = new System.Drawing.Size(149, 17);
            this.MufflerCheckBox.TabIndex = 1;
            this.MufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.MufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // InspectionCheckBox
            // 
            this.InspectionCheckBox.AutoSize = true;
            this.InspectionCheckBox.Location = new System.Drawing.Point(7, 20);
            this.InspectionCheckBox.Name = "InspectionCheckBox";
            this.InspectionCheckBox.Size = new System.Drawing.Size(117, 17);
            this.InspectionCheckBox.TabIndex = 0;
            this.InspectionCheckBox.Text = "Inspection ($15.00)";
            this.InspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // FlushesGroupBox
            // 
            this.FlushesGroupBox.Controls.Add(this.TransmissionCheckBox);
            this.FlushesGroupBox.Controls.Add(this.RadiatorCheckBox);
            this.FlushesGroupBox.Location = new System.Drawing.Point(397, 44);
            this.FlushesGroupBox.Name = "FlushesGroupBox";
            this.FlushesGroupBox.Size = new System.Drawing.Size(173, 72);
            this.FlushesGroupBox.TabIndex = 25;
            this.FlushesGroupBox.TabStop = false;
            this.FlushesGroupBox.Text = "Flushes";
            // 
            // TransmissionCheckBox
            // 
            this.TransmissionCheckBox.AutoSize = true;
            this.TransmissionCheckBox.Location = new System.Drawing.Point(7, 43);
            this.TransmissionCheckBox.Name = "TransmissionCheckBox";
            this.TransmissionCheckBox.Size = new System.Drawing.Size(157, 17);
            this.TransmissionCheckBox.TabIndex = 1;
            this.TransmissionCheckBox.Text = "Transmission Flush ($80.00)";
            this.TransmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // RadiatorCheckBox
            // 
            this.RadiatorCheckBox.AutoSize = true;
            this.RadiatorCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RadiatorCheckBox.Name = "RadiatorCheckBox";
            this.RadiatorCheckBox.Size = new System.Drawing.Size(136, 17);
            this.RadiatorCheckBox.TabIndex = 0;
            this.RadiatorCheckBox.Text = "Radiator Flush ($30.00)";
            this.RadiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // OilLubeGroupBox
            // 
            this.OilLubeGroupBox.Controls.Add(this.LubeCheckBox);
            this.OilLubeGroupBox.Controls.Add(this.OilCheckBox);
            this.OilLubeGroupBox.Location = new System.Drawing.Point(230, 44);
            this.OilLubeGroupBox.Name = "OilLubeGroupBox";
            this.OilLubeGroupBox.Size = new System.Drawing.Size(160, 72);
            this.OilLubeGroupBox.TabIndex = 24;
            this.OilLubeGroupBox.TabStop = false;
            this.OilLubeGroupBox.Text = "Oil and Lube";
            // 
            // LubeCheckBox
            // 
            this.LubeCheckBox.AutoSize = true;
            this.LubeCheckBox.Location = new System.Drawing.Point(7, 43);
            this.LubeCheckBox.Name = "LubeCheckBox";
            this.LubeCheckBox.Size = new System.Drawing.Size(109, 17);
            this.LubeCheckBox.TabIndex = 1;
            this.LubeCheckBox.Text = "Lube job ($18.00)";
            this.LubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // OilCheckBox
            // 
            this.OilCheckBox.AutoSize = true;
            this.OilCheckBox.Location = new System.Drawing.Point(7, 20);
            this.OilCheckBox.Name = "OilCheckBox";
            this.OilCheckBox.Size = new System.Drawing.Size(120, 17);
            this.OilCheckBox.TabIndex = 0;
            this.OilCheckBox.Text = "Oil Change ($26.00)";
            this.OilCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.PartsLaborGroupBox);
            this.Controls.Add(this.MiscGroupBox);
            this.Controls.Add(this.FlushesGroupBox);
            this.Controls.Add(this.OilLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.PartsLaborGroupBox.ResumeLayout(false);
            this.PartsLaborGroupBox.PerformLayout();
            this.MiscGroupBox.ResumeLayout(false);
            this.MiscGroupBox.PerformLayout();
            this.FlushesGroupBox.ResumeLayout(false);
            this.FlushesGroupBox.PerformLayout();
            this.OilLubeGroupBox.ResumeLayout(false);
            this.OilLubeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label TotalFeesLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label ServiceandLaborLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox PartsLaborGroupBox;
        private System.Windows.Forms.TextBox LaborTextBox;
        private System.Windows.Forms.TextBox PartsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MiscGroupBox;
        private System.Windows.Forms.CheckBox TireCheckBox;
        private System.Windows.Forms.CheckBox MufflerCheckBox;
        private System.Windows.Forms.CheckBox InspectionCheckBox;
        private System.Windows.Forms.GroupBox FlushesGroupBox;
        private System.Windows.Forms.CheckBox TransmissionCheckBox;
        private System.Windows.Forms.CheckBox RadiatorCheckBox;
        private System.Windows.Forms.GroupBox OilLubeGroupBox;
        private System.Windows.Forms.CheckBox LubeCheckBox;
        private System.Windows.Forms.CheckBox OilCheckBox;
    }
}

