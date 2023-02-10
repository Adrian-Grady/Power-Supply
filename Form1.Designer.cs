namespace PowerSupplyReader
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
            this.tbWriteVolt = new System.Windows.Forms.TextBox();
            this.btnWriteVolt = new System.Windows.Forms.Button();
            this.tbWriteCurrent = new System.Windows.Forms.TextBox();
            this.tbResourceName = new System.Windows.Forms.TextBox();
            this.btnOpenConn = new System.Windows.Forms.Button();
            this.lblVolts = new System.Windows.Forms.Label();
            this.btnSetCurr = new System.Windows.Forms.Button();
            this.lblCurr = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbResources = new System.Windows.Forms.ListBox();
            this.lblResources = new System.Windows.Forms.Label();
            this.rbOut1 = new System.Windows.Forms.RadioButton();
            this.rbOut2 = new System.Windows.Forms.RadioButton();
            this.lblVolt2 = new System.Windows.Forms.Label();
            this.lblCurr2 = new System.Windows.Forms.Label();
            this.btnOutOff = new System.Windows.Forms.Button();
            this.btnOutOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWriteVolt
            // 
            this.tbWriteVolt.Location = new System.Drawing.Point(212, 214);
            this.tbWriteVolt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWriteVolt.Name = "tbWriteVolt";
            this.tbWriteVolt.Size = new System.Drawing.Size(148, 26);
            this.tbWriteVolt.TabIndex = 0;
            // 
            // btnWriteVolt
            // 
            this.btnWriteVolt.Enabled = false;
            this.btnWriteVolt.Location = new System.Drawing.Point(22, 214);
            this.btnWriteVolt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWriteVolt.Name = "btnWriteVolt";
            this.btnWriteVolt.Size = new System.Drawing.Size(160, 35);
            this.btnWriteVolt.TabIndex = 1;
            this.btnWriteVolt.Text = "Set Voltage";
            this.btnWriteVolt.UseVisualStyleBackColor = true;
            this.btnWriteVolt.Click += new System.EventHandler(this.btnWriteVolt_Click);
            // 
            // tbWriteCurrent
            // 
            this.tbWriteCurrent.Location = new System.Drawing.Point(212, 258);
            this.tbWriteCurrent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWriteCurrent.Name = "tbWriteCurrent";
            this.tbWriteCurrent.Size = new System.Drawing.Size(148, 26);
            this.tbWriteCurrent.TabIndex = 2;
            // 
            // tbResourceName
            // 
            this.tbResourceName.Location = new System.Drawing.Point(212, 58);
            this.tbResourceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResourceName.Name = "tbResourceName";
            this.tbResourceName.Size = new System.Drawing.Size(148, 26);
            this.tbResourceName.TabIndex = 3;
            // 
            // btnOpenConn
            // 
            this.btnOpenConn.Location = new System.Drawing.Point(18, 54);
            this.btnOpenConn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenConn.Name = "btnOpenConn";
            this.btnOpenConn.Size = new System.Drawing.Size(184, 35);
            this.btnOpenConn.TabIndex = 4;
            this.btnOpenConn.Text = "Open Connection";
            this.btnOpenConn.UseVisualStyleBackColor = true;
            this.btnOpenConn.Click += new System.EventHandler(this.btnOpenConn_Click);
            // 
            // lblVolts
            // 
            this.lblVolts.AutoSize = true;
            this.lblVolts.Location = new System.Drawing.Point(390, 214);
            this.lblVolts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolts.Name = "lblVolts";
            this.lblVolts.Size = new System.Drawing.Size(81, 20);
            this.lblVolts.TabIndex = 5;
            this.lblVolts.Text = "Voltage 1:";
            // 
            // btnSetCurr
            // 
            this.btnSetCurr.Enabled = false;
            this.btnSetCurr.Location = new System.Drawing.Point(22, 258);
            this.btnSetCurr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetCurr.Name = "btnSetCurr";
            this.btnSetCurr.Size = new System.Drawing.Size(160, 35);
            this.btnSetCurr.TabIndex = 6;
            this.btnSetCurr.Text = "Set Current Limits";
            this.btnSetCurr.UseVisualStyleBackColor = true;
            this.btnSetCurr.Click += new System.EventHandler(this.btnSetCurr_Click);
            // 
            // lblCurr
            // 
            this.lblCurr.AutoSize = true;
            this.lblCurr.Location = new System.Drawing.Point(393, 258);
            this.lblCurr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(79, 20);
            this.lblCurr.TabIndex = 7;
            this.lblCurr.Text = "Current 1:";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(18, 423);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(1003, 26);
            this.tbStatus.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 394);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // lbResources
            // 
            this.lbResources.FormattingEnabled = true;
            this.lbResources.ItemHeight = 20;
            this.lbResources.Location = new System.Drawing.Point(690, 58);
            this.lbResources.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbResources.Name = "lbResources";
            this.lbResources.Size = new System.Drawing.Size(336, 144);
            this.lbResources.TabIndex = 10;
            this.lbResources.DoubleClick += new System.EventHandler(this.lbResources_DoubleClick);
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Location = new System.Drawing.Point(686, 20);
            this.lblResources.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(86, 20);
            this.lblResources.TabIndex = 11;
            this.lblResources.Text = "Resources";
            // 
            // rbOut1
            // 
            this.rbOut1.AutoSize = true;
            this.rbOut1.Checked = true;
            this.rbOut1.Location = new System.Drawing.Point(50, 132);
            this.rbOut1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOut1.Name = "rbOut1";
            this.rbOut1.Size = new System.Drawing.Size(96, 24);
            this.rbOut1.TabIndex = 12;
            this.rbOut1.TabStop = true;
            this.rbOut1.Text = "Output 1";
            this.rbOut1.UseVisualStyleBackColor = true;
            this.rbOut1.CheckedChanged += new System.EventHandler(this.rbOut1_CheckedChanged);
            this.rbOut1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbOut1_MouseClick);
            // 
            // rbOut2
            // 
            this.rbOut2.AutoSize = true;
            this.rbOut2.Location = new System.Drawing.Point(212, 132);
            this.rbOut2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOut2.Name = "rbOut2";
            this.rbOut2.Size = new System.Drawing.Size(96, 24);
            this.rbOut2.TabIndex = 13;
            this.rbOut2.Text = "Output 2";
            this.rbOut2.UseVisualStyleBackColor = true;
            this.rbOut2.CheckedChanged += new System.EventHandler(this.rbOut2_CheckedChanged);
            this.rbOut2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbOut2_MouseClick);
            // 
            // lblVolt2
            // 
            this.lblVolt2.AutoSize = true;
            this.lblVolt2.Location = new System.Drawing.Point(560, 214);
            this.lblVolt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolt2.Name = "lblVolt2";
            this.lblVolt2.Size = new System.Drawing.Size(81, 20);
            this.lblVolt2.TabIndex = 14;
            this.lblVolt2.Text = "Voltage 2:";
            // 
            // lblCurr2
            // 
            this.lblCurr2.AutoSize = true;
            this.lblCurr2.Location = new System.Drawing.Point(562, 258);
            this.lblCurr2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurr2.Name = "lblCurr2";
            this.lblCurr2.Size = new System.Drawing.Size(79, 20);
            this.lblCurr2.TabIndex = 15;
            this.lblCurr2.Text = "Current 2:";
            // 
            // btnOutOff
            // 
            this.btnOutOff.Enabled = false;
            this.btnOutOff.Location = new System.Drawing.Point(22, 303);
            this.btnOutOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutOff.Name = "btnOutOff";
            this.btnOutOff.Size = new System.Drawing.Size(160, 35);
            this.btnOutOff.TabIndex = 18;
            this.btnOutOff.Text = "Turn Output Off";
            this.btnOutOff.UseVisualStyleBackColor = true;
            this.btnOutOff.Click += new System.EventHandler(this.btnOutOff_Click);
            // 
            // btnOutOn
            // 
            this.btnOutOn.Enabled = false;
            this.btnOutOn.Location = new System.Drawing.Point(22, 348);
            this.btnOutOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutOn.Name = "btnOutOn";
            this.btnOutOn.Size = new System.Drawing.Size(160, 35);
            this.btnOutOn.TabIndex = 19;
            this.btnOutOn.Text = "Turn Output On";
            this.btnOutOn.UseVisualStyleBackColor = true;
            this.btnOutOn.Click += new System.EventHandler(this.btnOutOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 491);
            this.Controls.Add(this.btnOutOn);
            this.Controls.Add(this.btnOutOff);
            this.Controls.Add(this.lblCurr2);
            this.Controls.Add(this.lblVolt2);
            this.Controls.Add(this.rbOut2);
            this.Controls.Add(this.rbOut1);
            this.Controls.Add(this.lblResources);
            this.Controls.Add(this.lbResources);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lblCurr);
            this.Controls.Add(this.btnSetCurr);
            this.Controls.Add(this.lblVolts);
            this.Controls.Add(this.btnOpenConn);
            this.Controls.Add(this.tbResourceName);
            this.Controls.Add(this.tbWriteCurrent);
            this.Controls.Add(this.btnWriteVolt);
            this.Controls.Add(this.tbWriteVolt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWriteVolt;
        private System.Windows.Forms.Button btnWriteVolt;
        private System.Windows.Forms.TextBox tbWriteCurrent;
        private System.Windows.Forms.TextBox tbResourceName;
        private System.Windows.Forms.Button btnOpenConn;
        private System.Windows.Forms.Label lblVolts;
        private System.Windows.Forms.Button btnSetCurr;
        private System.Windows.Forms.Label lblCurr;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lbResources;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.RadioButton rbOut1;
        private System.Windows.Forms.RadioButton rbOut2;
        private System.Windows.Forms.Label lblVolt2;
        private System.Windows.Forms.Label lblCurr2;
        private System.Windows.Forms.Button btnOutOff;
        private System.Windows.Forms.Button btnOutOn;
    }
}

