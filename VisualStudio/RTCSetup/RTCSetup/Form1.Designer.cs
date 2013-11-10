namespace RTCSetup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbSystemTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSetSystem = new System.Windows.Forms.Button();
            this.btGet = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.lbRTCTime = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btSetCustom = new System.Windows.Forms.Button();
            this.dtpCustom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Location = new System.Drawing.Point(6, 25);
            this.lbSystemTime.MinimumSize = new System.Drawing.Size(318, 40);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(318, 40);
            this.lbSystemTime.TabIndex = 0;
            this.lbSystemTime.Text = "12:35";
            this.lbSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSystemTime.UseCompatibleTextRendering = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSetSystem);
            this.groupBox1.Controls.Add(this.lbSystemTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btGet);
            this.groupBox2.Controls.Add(this.btConnect);
            this.groupBox2.Controls.Add(this.cbSerialPorts);
            this.groupBox2.Controls.Add(this.lbRTCTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RTC";
            // 
            // btSetSystem
            // 
            this.btSetSystem.Image = ((System.Drawing.Image)(resources.GetObject("btSetSystem.Image")));
            this.btSetSystem.Location = new System.Drawing.Point(330, 25);
            this.btSetSystem.Name = "btSetSystem";
            this.btSetSystem.Size = new System.Drawing.Size(40, 40);
            this.btSetSystem.TabIndex = 6;
            this.btSetSystem.UseVisualStyleBackColor = true;
            this.btSetSystem.Click += new System.EventHandler(this.btSetSystem_Click);
            // 
            // btGet
            // 
            this.btGet.Image = ((System.Drawing.Image)(resources.GetObject("btGet.Image")));
            this.btGet.Location = new System.Drawing.Point(330, 26);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(40, 40);
            this.btGet.TabIndex = 5;
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(249, 79);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(121, 23);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "CONNECT";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(6, 81);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(237, 21);
            this.cbSerialPorts.TabIndex = 3;
            // 
            // lbRTCTime
            // 
            this.lbRTCTime.AutoSize = true;
            this.lbRTCTime.Location = new System.Drawing.Point(6, 26);
            this.lbRTCTime.MinimumSize = new System.Drawing.Size(318, 40);
            this.lbRTCTime.Name = "lbRTCTime";
            this.lbRTCTime.Size = new System.Drawing.Size(318, 40);
            this.lbRTCTime.TabIndex = 1;
            this.lbRTCTime.Text = "12:35";
            this.lbRTCTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRTCTime.UseCompatibleTextRendering = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpCustom);
            this.groupBox3.Controls.Add(this.btSetCustom);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 90);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Time";
            // 
            // btSetCustom
            // 
            this.btSetCustom.Image = ((System.Drawing.Image)(resources.GetObject("btSetCustom.Image")));
            this.btSetCustom.Location = new System.Drawing.Point(330, 25);
            this.btSetCustom.Name = "btSetCustom";
            this.btSetCustom.Size = new System.Drawing.Size(40, 40);
            this.btSetCustom.TabIndex = 6;
            this.btSetCustom.UseVisualStyleBackColor = true;
            this.btSetCustom.Click += new System.EventHandler(this.btSetCustom_Click);
            // 
            // dtpCustom
            // 
            this.dtpCustom.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCustom.Location = new System.Drawing.Point(6, 25);
            this.dtpCustom.MinimumSize = new System.Drawing.Size(0, 40);
            this.dtpCustom.Name = "dtpCustom";
            this.dtpCustom.Size = new System.Drawing.Size(318, 40);
            this.dtpCustom.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTCSetup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSystemTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbRTCTime;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Button btSetSystem;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btSetCustom;
        private System.Windows.Forms.DateTimePicker dtpCustom;
    }
}

