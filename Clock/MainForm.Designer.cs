namespace Clock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTechnicallyInsaneWidesemibold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrecrusherexpandital = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYawTaht = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMontrocital = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAutorun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
            this.checkBoxShowWeekDay = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonHideControls = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelControls = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(261, 51);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "CurrentTime";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.toolStripSeparator1,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator2,
            this.tsmiFont,
            this.tsmiColor,
            this.toolStripSeparator3,
            this.tsmiAlarms,
            this.toolStripSeparator4,
            this.tsmiAutorun,
            this.toolStripSeparator5,
            this.tsmiExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 254);
            // 
            // tsmiTopmost
            // 
            this.tsmiTopmost.CheckOnClick = true;
            this.tsmiTopmost.Name = "tsmiTopmost";
            this.tsmiTopmost.Size = new System.Drawing.Size(180, 22);
            this.tsmiTopmost.Text = "Topmost";
            this.tsmiTopmost.CheckedChanged += new System.EventHandler(this.tsmiTopmost_CheckedChanged);
            // 
            // tsmiShowControls
            // 
            this.tsmiShowControls.CheckOnClick = true;
            this.tsmiShowControls.Name = "tsmiShowControls";
            this.tsmiShowControls.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowControls.Text = "Show controls";
            this.tsmiShowControls.CheckedChanged += new System.EventHandler(this.tsmiShowControls_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiShowDate
            // 
            this.tsmiShowDate.CheckOnClick = true;
            this.tsmiShowDate.Name = "tsmiShowDate";
            this.tsmiShowDate.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowDate.Text = "Show date";
            this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);
            // 
            // tsmiShowWeekday
            // 
            this.tsmiShowWeekday.CheckOnClick = true;
            this.tsmiShowWeekday.Name = "tsmiShowWeekday";
            this.tsmiShowWeekday.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowWeekday.Text = "Show weekday";
            this.tsmiShowWeekday.CheckedChanged += new System.EventHandler(this.tsmiShowWeekday_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiFont
            // 
            this.tsmiFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTechnicallyInsaneWidesemibold,
            this.tsmiOrecrusherexpandital,
            this.tsmiYawTaht,
            this.tsmiMontrocital});
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(180, 22);
            this.tsmiFont.Text = "Font";
            // 
            // tsmiTechnicallyInsaneWidesemibold
            // 
            this.tsmiTechnicallyInsaneWidesemibold.Name = "tsmiTechnicallyInsaneWidesemibold";
            this.tsmiTechnicallyInsaneWidesemibold.Size = new System.Drawing.Size(243, 22);
            this.tsmiTechnicallyInsaneWidesemibold.Text = "TechnicallyInsaneWidesemibold";
            this.tsmiTechnicallyInsaneWidesemibold.Click += new System.EventHandler(this.tsmiTechnicallyInsaneWidesemibold_Click);
            // 
            // tsmiOrecrusherexpandital
            // 
            this.tsmiOrecrusherexpandital.Name = "tsmiOrecrusherexpandital";
            this.tsmiOrecrusherexpandital.Size = new System.Drawing.Size(243, 22);
            this.tsmiOrecrusherexpandital.Text = "Orecrusherexpandital";
            this.tsmiOrecrusherexpandital.Click += new System.EventHandler(this.tsmiOrecrusherexpandital_Click);
            // 
            // tsmiYawTaht
            // 
            this.tsmiYawTaht.Name = "tsmiYawTaht";
            this.tsmiYawTaht.Size = new System.Drawing.Size(243, 22);
            this.tsmiYawTaht.Text = "YawTaht";
            this.tsmiYawTaht.Click += new System.EventHandler(this.tsmiYawTaht_Click);
            // 
            // tsmiMontrocital
            // 
            this.tsmiMontrocital.Name = "tsmiMontrocital";
            this.tsmiMontrocital.Size = new System.Drawing.Size(243, 22);
            this.tsmiMontrocital.Text = "Montrocital";
            this.tsmiMontrocital.Click += new System.EventHandler(this.tsmiMontrocital_Click);
            // 
            // tsmiColor
            // 
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiColor.Text = "Color";
            // 
            // tsmiForegroundColor
            // 
            this.tsmiForegroundColor.Name = "tsmiForegroundColor";
            this.tsmiForegroundColor.Size = new System.Drawing.Size(168, 22);
            this.tsmiForegroundColor.Text = "Foreground color";
            this.tsmiForegroundColor.Click += new System.EventHandler(this.tsmiForegroundColor_Click);
            // 
            // tsmiBackgroundColor
            // 
            this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
            this.tsmiBackgroundColor.Size = new System.Drawing.Size(168, 22);
            this.tsmiBackgroundColor.Text = "Background color";
            this.tsmiBackgroundColor.Click += new System.EventHandler(this.tsmiBackgroundColor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiAlarms
            // 
            this.tsmiAlarms.Name = "tsmiAlarms";
            this.tsmiAlarms.Size = new System.Drawing.Size(180, 22);
            this.tsmiAlarms.Text = "Alarms";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiAutorun
            // 
            this.tsmiAutorun.CheckOnClick = true;
            this.tsmiAutorun.Name = "tsmiAutorun";
            this.tsmiAutorun.Size = new System.Drawing.Size(180, 22);
            this.tsmiAutorun.Text = "Autorun";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // checkBoxShowDate
            // 
            this.checkBoxShowDate.AutoSize = true;
            this.checkBoxShowDate.BackColor = System.Drawing.Color.Black;
            this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBoxShowDate.ForeColor = System.Drawing.Color.Red;
            this.checkBoxShowDate.Location = new System.Drawing.Point(21, 198);
            this.checkBoxShowDate.Name = "checkBoxShowDate";
            this.checkBoxShowDate.Size = new System.Drawing.Size(132, 30);
            this.checkBoxShowDate.TabIndex = 1;
            this.checkBoxShowDate.Text = "ShowDate";
            this.checkBoxShowDate.UseVisualStyleBackColor = false;
            this.checkBoxShowDate.CheckedChanged += new System.EventHandler(this.checkBoxShowDate_CheckedChanged);
            // 
            // checkBoxShowWeekDay
            // 
            this.checkBoxShowWeekDay.AutoSize = true;
            this.checkBoxShowWeekDay.BackColor = System.Drawing.Color.Black;
            this.checkBoxShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBoxShowWeekDay.ForeColor = System.Drawing.Color.Red;
            this.checkBoxShowWeekDay.Location = new System.Drawing.Point(21, 234);
            this.checkBoxShowWeekDay.Name = "checkBoxShowWeekDay";
            this.checkBoxShowWeekDay.Size = new System.Drawing.Size(181, 30);
            this.checkBoxShowWeekDay.TabIndex = 2;
            this.checkBoxShowWeekDay.Text = "ShowWeekDay";
            this.checkBoxShowWeekDay.UseVisualStyleBackColor = false;
            this.checkBoxShowWeekDay.CheckedChanged += new System.EventHandler(this.checkBoxShowWeekDay_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonHideControls
            // 
            this.buttonHideControls.BackColor = System.Drawing.Color.Black;
            this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonHideControls.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonHideControls.Location = new System.Drawing.Point(12, 279);
            this.buttonHideControls.Name = "buttonHideControls";
            this.buttonHideControls.Size = new System.Drawing.Size(309, 74);
            this.buttonHideControls.TabIndex = 3;
            this.buttonHideControls.UseVisualStyleBackColor = false;
            this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ClockPV_522";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // labelControls
            // 
            this.labelControls.AutoSize = true;
            this.labelControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.labelControls.Location = new System.Drawing.Point(25, 293);
            this.labelControls.Name = "labelControls";
            this.labelControls.Size = new System.Drawing.Size(283, 51);
            this.labelControls.TabIndex = 4;
            this.labelControls.Text = "Hide Controls";
            this.labelControls.Click += new System.EventHandler(this.labelControls_Click);
            this.labelControls.DoubleClick += new System.EventHandler(this.labelControls_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 365);
            this.Controls.Add(this.labelControls);
            this.Controls.Add(this.buttonHideControls);
            this.Controls.Add(this.checkBoxShowWeekDay);
            this.Controls.Add(this.checkBoxShowDate);
            this.Controls.Add(this.labelTime);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock";
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxShowDate;
        private System.Windows.Forms.CheckBox checkBoxShowWeekDay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutorun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Label labelControls;
        private System.Windows.Forms.ToolStripMenuItem tsmiTechnicallyInsaneWidesemibold;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrecrusherexpandital;
        private System.Windows.Forms.ToolStripMenuItem tsmiYawTaht;
        private System.Windows.Forms.ToolStripMenuItem tsmiMontrocital;
    }
}

