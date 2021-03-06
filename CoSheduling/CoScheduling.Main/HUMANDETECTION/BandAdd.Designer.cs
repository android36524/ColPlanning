﻿namespace CoScheduling.Main.HUMANDETECTION
{
    partial class BandAdd
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
            this.txtSNR = new System.Windows.Forms.TextBox();
            this.comboBoxPolar = new System.Windows.Forms.ComboBox();
            this.txtBandWidth = new System.Windows.Forms.TextBox();
            this.txtBandCenter = new System.Windows.Forms.TextBox();
            this.txtSpeMax = new System.Windows.Forms.TextBox();
            this.txtSpeMin = new System.Windows.Forms.TextBox();
            this.comboBoxBandType = new System.Windows.Forms.ComboBox();
            this.txtBandSwathWidth = new System.Windows.Forms.TextBox();
            this.txtBandID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSensorID = new System.Windows.Forms.Label();
            this.txtHUMDETID = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSNR
            // 
            this.txtSNR.Location = new System.Drawing.Point(412, 197);
            this.txtSNR.Name = "txtSNR";
            this.txtSNR.Size = new System.Drawing.Size(123, 21);
            this.txtSNR.TabIndex = 167;
            // 
            // comboBoxPolar
            // 
            this.comboBoxPolar.FormattingEnabled = true;
            this.comboBoxPolar.Items.AddRange(new object[] {
            "V",
            "H",
            "VV",
            "HH",
            "HV",
            "VH",
            "V,H",
            "HH,VV",
            "HH,HV,VH,VV",
            "V,H,HH+HV+VH+VV",
            "HH,HV,VH,VV,HH+HV,VV+VH,V,H",
            "TBD"});
            this.comboBoxPolar.Location = new System.Drawing.Point(414, 44);
            this.comboBoxPolar.Name = "comboBoxPolar";
            this.comboBoxPolar.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPolar.TabIndex = 163;
            // 
            // txtBandWidth
            // 
            this.txtBandWidth.Location = new System.Drawing.Point(132, 194);
            this.txtBandWidth.Name = "txtBandWidth";
            this.txtBandWidth.Size = new System.Drawing.Size(143, 21);
            this.txtBandWidth.TabIndex = 162;
            // 
            // txtBandCenter
            // 
            this.txtBandCenter.Location = new System.Drawing.Point(132, 160);
            this.txtBandCenter.Name = "txtBandCenter";
            this.txtBandCenter.Size = new System.Drawing.Size(143, 21);
            this.txtBandCenter.TabIndex = 161;
            // 
            // txtSpeMax
            // 
            this.txtSpeMax.Location = new System.Drawing.Point(215, 120);
            this.txtSpeMax.Name = "txtSpeMax";
            this.txtSpeMax.Size = new System.Drawing.Size(60, 21);
            this.txtSpeMax.TabIndex = 160;
            // 
            // txtSpeMin
            // 
            this.txtSpeMin.Location = new System.Drawing.Point(132, 120);
            this.txtSpeMin.Name = "txtSpeMin";
            this.txtSpeMin.Size = new System.Drawing.Size(60, 21);
            this.txtSpeMin.TabIndex = 159;
            // 
            // comboBoxBandType
            // 
            this.comboBoxBandType.FormattingEnabled = true;
            this.comboBoxBandType.Location = new System.Drawing.Point(132, 81);
            this.comboBoxBandType.Name = "comboBoxBandType";
            this.comboBoxBandType.Size = new System.Drawing.Size(143, 20);
            this.comboBoxBandType.TabIndex = 158;
            // 
            // txtBandSwathWidth
            // 
            this.txtBandSwathWidth.Location = new System.Drawing.Point(132, 44);
            this.txtBandSwathWidth.Name = "txtBandSwathWidth";
            this.txtBandSwathWidth.Size = new System.Drawing.Size(143, 21);
            this.txtBandSwathWidth.TabIndex = 157;
            // 
            // txtBandID
            // 
            this.txtBandID.Location = new System.Drawing.Point(349, 7);
            this.txtBandID.Name = "txtBandID";
            this.txtBandID.Size = new System.Drawing.Size(150, 21);
            this.txtBandID.TabIndex = 156;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 155;
            this.label13.Text = "波段模式ID：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 154;
            this.label12.Text = "信噪比：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 150;
            this.label7.Text = "极化方式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 149;
            this.label6.Text = "频谱宽度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 148;
            this.label5.Text = "频谱中心：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 147;
            this.label4.Text = "频谱范围：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 146;
            this.label3.Text = "波段类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 145;
            this.label1.Text = "幅宽：";
            // 
            // txtSensorID
            // 
            this.txtSensorID.AutoSize = true;
            this.txtSensorID.Location = new System.Drawing.Point(139, 10);
            this.txtSensorID.Name = "txtSensorID";
            this.txtSensorID.Size = new System.Drawing.Size(53, 12);
            this.txtSensorID.TabIndex = 144;
            this.txtSensorID.Text = "载荷ID：";
            // 
            // txtHUMDETID
            // 
            this.txtHUMDETID.AutoSize = true;
            this.txtHUMDETID.Location = new System.Drawing.Point(23, 10);
            this.txtHUMDETID.Name = "txtHUMDETID";
            this.txtHUMDETID.Size = new System.Drawing.Size(95, 12);
            this.txtHUMDETID.TabIndex = 143;
            this.txtHUMDETID.Text = "志愿者设备ID ：";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(308, 227);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 169;
            this.ButtonReset.Text = "重置";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(200, 227);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 168;
            this.ButtonAdd.Text = "添加";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // BandAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 262);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.txtSNR);
            this.Controls.Add(this.comboBoxPolar);
            this.Controls.Add(this.txtBandWidth);
            this.Controls.Add(this.txtBandCenter);
            this.Controls.Add(this.txtSpeMax);
            this.Controls.Add(this.txtSpeMin);
            this.Controls.Add(this.comboBoxBandType);
            this.Controls.Add(this.txtBandSwathWidth);
            this.Controls.Add(this.txtBandID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSensorID);
            this.Controls.Add(this.txtHUMDETID);
            this.Name = "BandAdd";
            this.Text = "波段添加";
            this.Load += new System.EventHandler(this.BandAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSNR;
        private System.Windows.Forms.ComboBox comboBoxPolar;
        private System.Windows.Forms.TextBox txtBandWidth;
        private System.Windows.Forms.TextBox txtBandCenter;
        private System.Windows.Forms.TextBox txtSpeMax;
        private System.Windows.Forms.TextBox txtSpeMin;
        private System.Windows.Forms.ComboBox comboBoxBandType;
        private System.Windows.Forms.TextBox txtBandSwathWidth;
        private System.Windows.Forms.TextBox txtBandID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSensorID;
        private System.Windows.Forms.Label txtHUMDETID;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonAdd;
    }
}