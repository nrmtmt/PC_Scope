namespace test_dso
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnGetParam = new System.Windows.Forms.Button();
            this.chrt1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxHSens = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConnectionInfo = new System.Windows.Forms.Label();
            this.lblScopeType = new System.Windows.Forms.Label();
            this.cbxReadDelay = new System.Windows.Forms.ComboBox();
            this.cbxTrigSlope = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTrigType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxRecLength = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCouple = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxVSens = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuStartCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuStopCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuSaveAsCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuDebugWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltrig = new System.Windows.Forms.Label();
            this.btnAutoTrig = new System.Windows.Forms.Button();
            this.tbTrigg = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.gbbMeasure = new System.Windows.Forms.GroupBox();
            this.lblVpp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVRMS = new System.Windows.Forms.Label();
            this.lblVAvg = new System.Windows.Forms.Label();
            this.lblVmin = new System.Windows.Forms.Label();
            this.lblVmax = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPos = new System.Windows.Forms.TrackBar();
            this.tbVerticalPosition = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnAddCell = new System.Windows.Forms.Button();
            this.btnRemoveCell = new System.Windows.Forms.Button();
            this.lblCellCount = new System.Windows.Forms.Label();
            this.gpbChrtCtrl = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.gpbCursorMeasure = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDeltaValue = new System.Windows.Forms.Label();
            this.lblCursorRightValue = new System.Windows.Forms.Label();
            this.lblCursorLeftValue = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnCursorFunction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrt1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrigg)).BeginInit();
            this.gbbMeasure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerticalPosition)).BeginInit();
            this.gpbChrtCtrl.SuspendLayout();
            this.gpbCursorMeasure.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetParam
            // 
            this.btnGetParam.Location = new System.Drawing.Point(774, 3);
            this.btnGetParam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetParam.Name = "btnGetParam";
            this.btnGetParam.Size = new System.Drawing.Size(98, 25);
            this.btnGetParam.TabIndex = 8;
            this.btnGetParam.Text = "Refresh";
            this.btnGetParam.UseMnemonic = false;
            this.btnGetParam.UseVisualStyleBackColor = true;
            this.btnGetParam.Click += new System.EventHandler(this.btnGetParam_Click_1);
            // 
            // chrt1
            // 
            this.chrt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrt1.ChartAreas.Add(chartArea1);
            this.chrt1.Location = new System.Drawing.Point(0, 31);
            this.chrt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrt1.Name = "chrt1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chrt1.Series.Add(series1);
            this.chrt1.Size = new System.Drawing.Size(970, 434);
            this.chrt1.TabIndex = 10;
            this.chrt1.Text = "chrt1";
            // 
            // cbxHSens
            // 
            this.cbxHSens.FormattingEnabled = true;
            this.cbxHSens.Location = new System.Drawing.Point(6, 43);
            this.cbxHSens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxHSens.Name = "cbxHSens";
            this.cbxHSens.Size = new System.Drawing.Size(110, 24);
            this.cbxHSens.TabIndex = 11;
            this.cbxHSens.SelectedIndexChanged += new System.EventHandler(this.cbxHSens_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblConnectionInfo);
            this.groupBox1.Controls.Add(this.lblScopeType);
            this.groupBox1.Controls.Add(this.cbxReadDelay);
            this.groupBox1.Controls.Add(this.cbxTrigSlope);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxTrigType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxRecLength);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnGetParam);
            this.groupBox1.Controls.Add(this.cbxCouple);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxVSens);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxHSens);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(110, 484);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(872, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scope Parameters";
            // 
            // lblConnectionInfo
            // 
            this.lblConnectionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConnectionInfo.AutoSize = true;
            this.lblConnectionInfo.Location = new System.Drawing.Point(787, 34);
            this.lblConnectionInfo.Name = "lblConnectionInfo";
            this.lblConnectionInfo.Size = new System.Drawing.Size(13, 17);
            this.lblConnectionInfo.TabIndex = 25;
            this.lblConnectionInfo.Text = "-";
            // 
            // lblScopeType
            // 
            this.lblScopeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScopeType.AutoSize = true;
            this.lblScopeType.Location = new System.Drawing.Point(787, 51);
            this.lblScopeType.Name = "lblScopeType";
            this.lblScopeType.Size = new System.Drawing.Size(13, 17);
            this.lblScopeType.TabIndex = 24;
            this.lblScopeType.Text = "-";
            // 
            // cbxReadDelay
            // 
            this.cbxReadDelay.FormattingEnabled = true;
            this.cbxReadDelay.Location = new System.Drawing.Point(698, 43);
            this.cbxReadDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxReadDelay.Name = "cbxReadDelay";
            this.cbxReadDelay.Size = new System.Drawing.Size(75, 24);
            this.cbxReadDelay.TabIndex = 21;
            this.cbxReadDelay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxTrigSlope
            // 
            this.cbxTrigSlope.FormattingEnabled = true;
            this.cbxTrigSlope.Location = new System.Drawing.Point(336, 43);
            this.cbxTrigSlope.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTrigSlope.Name = "cbxTrigSlope";
            this.cbxTrigSlope.Size = new System.Drawing.Size(110, 24);
            this.cbxTrigSlope.TabIndex = 20;
            this.cbxTrigSlope.SelectedIndexChanged += new System.EventHandler(this.cbxTrigSlope_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Read Delay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Trigger Slope";
            // 
            // cbxTrigType
            // 
            this.cbxTrigType.FormattingEnabled = true;
            this.cbxTrigType.Location = new System.Drawing.Point(226, 43);
            this.cbxTrigType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTrigType.Name = "cbxTrigType";
            this.cbxTrigType.Size = new System.Drawing.Size(110, 24);
            this.cbxTrigType.TabIndex = 18;
            this.cbxTrigType.SelectedIndexChanged += new System.EventHandler(this.cbxTrigType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Trigger Mode";
            // 
            // cbxRecLength
            // 
            this.cbxRecLength.FormattingEnabled = true;
            this.cbxRecLength.Location = new System.Drawing.Point(556, 43);
            this.cbxRecLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRecLength.Name = "cbxRecLength";
            this.cbxRecLength.Size = new System.Drawing.Size(110, 24);
            this.cbxRecLength.TabIndex = 16;
            this.cbxRecLength.SelectedIndexChanged += new System.EventHandler(this.cbxRecLength_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Record Length";
            // 
            // cbxCouple
            // 
            this.cbxCouple.FormattingEnabled = true;
            this.cbxCouple.Location = new System.Drawing.Point(446, 43);
            this.cbxCouple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCouple.Name = "cbxCouple";
            this.cbxCouple.Size = new System.Drawing.Size(110, 24);
            this.cbxCouple.TabIndex = 14;
            this.cbxCouple.SelectedIndexChanged += new System.EventHandler(this.cbxCouple_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Couple";
            // 
            // cbxVSens
            // 
            this.cbxVSens.FormattingEnabled = true;
            this.cbxVSens.Location = new System.Drawing.Point(116, 43);
            this.cbxVSens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVSens.Name = "cbxVSens";
            this.cbxVSens.Size = new System.Drawing.Size(110, 24);
            this.cbxVSens.TabIndex = 12;
            this.cbxVSens.SelectedIndexChanged += new System.EventHandler(this.cbxVSens_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sensitivity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Timebase";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripMenuItem,
            this.tMenuConfig,
            this.tMenuAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(982, 28);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMenuConnect,
            this.tMenuDisconnect,
            this.tMenuStartCapture,
            this.tMenuStopCapture,
            this.tMenuSaveAsCSV,
            this.tMenuDebugWindow});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // tMenuConnect
            // 
            this.tMenuConnect.Name = "tMenuConnect";
            this.tMenuConnect.Size = new System.Drawing.Size(232, 26);
            this.tMenuConnect.Text = "Connect";
            this.tMenuConnect.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // tMenuDisconnect
            // 
            this.tMenuDisconnect.Name = "tMenuDisconnect";
            this.tMenuDisconnect.Size = new System.Drawing.Size(232, 26);
            this.tMenuDisconnect.Text = "Disconnect";
            this.tMenuDisconnect.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // tMenuStartCapture
            // 
            this.tMenuStartCapture.Name = "tMenuStartCapture";
            this.tMenuStartCapture.Size = new System.Drawing.Size(232, 26);
            this.tMenuStartCapture.Text = "Start Capture";
            this.tMenuStartCapture.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tMenuStopCapture
            // 
            this.tMenuStopCapture.Name = "tMenuStopCapture";
            this.tMenuStopCapture.Size = new System.Drawing.Size(232, 26);
            this.tMenuStopCapture.Text = "Stop Capture";
            this.tMenuStopCapture.Click += new System.EventHandler(this.stopCaptureToolStripMenuItem_Click);
            // 
            // tMenuSaveAsCSV
            // 
            this.tMenuSaveAsCSV.Name = "tMenuSaveAsCSV";
            this.tMenuSaveAsCSV.Size = new System.Drawing.Size(232, 26);
            this.tMenuSaveAsCSV.Text = "Save buffer to CSV file";
            this.tMenuSaveAsCSV.Click += new System.EventHandler(this.saveBufferToCSVFileToolStripMenuItem_Click);
            // 
            // tMenuDebugWindow
            // 
            this.tMenuDebugWindow.Name = "tMenuDebugWindow";
            this.tMenuDebugWindow.Size = new System.Drawing.Size(232, 26);
            this.tMenuDebugWindow.Text = "Debug window";
            this.tMenuDebugWindow.Click += new System.EventHandler(this.debugWindowToolStripMenuItem_Click);
            // 
            // tMenuConfig
            // 
            this.tMenuConfig.Name = "tMenuConfig";
            this.tMenuConfig.Size = new System.Drawing.Size(93, 24);
            this.tMenuConfig.Text = "Port config";
            this.tMenuConfig.Click += new System.EventHandler(this.portConfigToolStripMenuItem_Click);
            // 
            // tMenuAbout
            // 
            this.tMenuAbout.Name = "tMenuAbout";
            this.tMenuAbout.Size = new System.Drawing.Size(62, 24);
            this.tMenuAbout.Text = "About";
            this.tMenuAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbltrig
            // 
            this.lbltrig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltrig.AutoSize = true;
            this.lbltrig.Location = new System.Drawing.Point(874, 429);
            this.lbltrig.Name = "lbltrig";
            this.lbltrig.Size = new System.Drawing.Size(13, 17);
            this.lbltrig.TabIndex = 16;
            this.lbltrig.Text = "-";
            // 
            // btnAutoTrig
            // 
            this.btnAutoTrig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoTrig.Location = new System.Drawing.Point(926, 448);
            this.btnAutoTrig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutoTrig.Name = "btnAutoTrig";
            this.btnAutoTrig.Size = new System.Drawing.Size(56, 35);
            this.btnAutoTrig.TabIndex = 17;
            this.btnAutoTrig.Text = "Auto";
            this.btnAutoTrig.UseVisualStyleBackColor = true;
            this.btnAutoTrig.Click += new System.EventHandler(this.btnAutoTrig_Click);
            // 
            // tbTrigg
            // 
            this.tbTrigg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrigg.Location = new System.Drawing.Point(943, 31);
            this.tbTrigg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTrigg.Maximum = 255;
            this.tbTrigg.Name = "tbTrigg";
            this.tbTrigg.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbTrigg.Size = new System.Drawing.Size(56, 419);
            this.tbTrigg.TabIndex = 21;
            this.tbTrigg.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbTrigg.Scroll += new System.EventHandler(this.tbTrigg_Scroll);
            this.tbTrigg.MouseLeave += new System.EventHandler(this.tbTrigg_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Max";
            // 
            // gbbMeasure
            // 
            this.gbbMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbbMeasure.BackColor = System.Drawing.Color.Transparent;
            this.gbbMeasure.Controls.Add(this.lblVpp);
            this.gbbMeasure.Controls.Add(this.label12);
            this.gbbMeasure.Controls.Add(this.lblVRMS);
            this.gbbMeasure.Controls.Add(this.lblVAvg);
            this.gbbMeasure.Controls.Add(this.lblVmin);
            this.gbbMeasure.Controls.Add(this.lblVmax);
            this.gbbMeasure.Controls.Add(this.label11);
            this.gbbMeasure.Controls.Add(this.label10);
            this.gbbMeasure.Controls.Add(this.label9);
            this.gbbMeasure.Controls.Add(this.label2);
            this.gbbMeasure.Location = new System.Drawing.Point(674, 31);
            this.gbbMeasure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbbMeasure.Name = "gbbMeasure";
            this.gbbMeasure.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbbMeasure.Size = new System.Drawing.Size(271, 53);
            this.gbbMeasure.TabIndex = 26;
            this.gbbMeasure.TabStop = false;
            this.gbbMeasure.Text = "Measurements";
            // 
            // lblVpp
            // 
            this.lblVpp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVpp.AutoSize = true;
            this.lblVpp.Location = new System.Drawing.Point(231, 15);
            this.lblVpp.Name = "lblVpp";
            this.lblVpp.Size = new System.Drawing.Size(13, 17);
            this.lblVpp.TabIndex = 34;
            this.lblVpp.Text = "-";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "VPP";
            // 
            // lblVRMS
            // 
            this.lblVRMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVRMS.AutoSize = true;
            this.lblVRMS.Location = new System.Drawing.Point(139, 32);
            this.lblVRMS.Name = "lblVRMS";
            this.lblVRMS.Size = new System.Drawing.Size(13, 17);
            this.lblVRMS.TabIndex = 32;
            this.lblVRMS.Text = "-";
            // 
            // lblVAvg
            // 
            this.lblVAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVAvg.AutoSize = true;
            this.lblVAvg.Location = new System.Drawing.Point(139, 15);
            this.lblVAvg.Name = "lblVAvg";
            this.lblVAvg.Size = new System.Drawing.Size(13, 17);
            this.lblVAvg.TabIndex = 31;
            this.lblVAvg.Text = "-";
            // 
            // lblVmin
            // 
            this.lblVmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVmin.AutoSize = true;
            this.lblVmin.Location = new System.Drawing.Point(43, 33);
            this.lblVmin.Name = "lblVmin";
            this.lblVmin.Size = new System.Drawing.Size(13, 17);
            this.lblVmin.TabIndex = 30;
            this.lblVmin.Text = "-";
            // 
            // lblVmax
            // 
            this.lblVmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVmax.AutoSize = true;
            this.lblVmax.Location = new System.Drawing.Point(43, 15);
            this.lblVmax.Name = "lblVmax";
            this.lblVmax.Size = new System.Drawing.Size(13, 17);
            this.lblVmax.TabIndex = 29;
            this.lblVmax.Text = "-";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "RMS";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Avg";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Min";
            // 
            // tbPos
            // 
            this.tbPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPos.Location = new System.Drawing.Point(-17, 31);
            this.tbPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPos.Maximum = 127;
            this.tbPos.Minimum = -127;
            this.tbPos.Name = "tbPos";
            this.tbPos.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPos.RightToLeftLayout = true;
            this.tbPos.Size = new System.Drawing.Size(56, 419);
            this.tbPos.TabIndex = 22;
            this.tbPos.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbPos.Scroll += new System.EventHandler(this.tbPos_Scroll);
            // 
            // tbVerticalPosition
            // 
            this.tbVerticalPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVerticalPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbVerticalPosition.Location = new System.Drawing.Point(85, 450);
            this.tbVerticalPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerticalPosition.Maximum = 127;
            this.tbVerticalPosition.Minimum = -127;
            this.tbVerticalPosition.Name = "tbVerticalPosition";
            this.tbVerticalPosition.Size = new System.Drawing.Size(852, 56);
            this.tbVerticalPosition.TabIndex = 27;
            this.tbVerticalPosition.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbVerticalPosition.Scroll += new System.EventHandler(this.tbVerticalPosition_Scroll);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(850, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Trigger level";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.Location = new System.Drawing.Point(0, 448);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(52, 35);
            this.btnPlay.TabIndex = 30;
            this.btnPlay.Text = ">";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPause.Location = new System.Drawing.Point(48, 448);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(52, 35);
            this.btnPause.TabIndex = 31;
            this.btnPause.Text = "||";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnAddCell
            // 
            this.btnAddCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCell.Location = new System.Drawing.Point(0, 16);
            this.btnAddCell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCell.Name = "btnAddCell";
            this.btnAddCell.Size = new System.Drawing.Size(39, 22);
            this.btnAddCell.TabIndex = 32;
            this.btnAddCell.Text = "+";
            this.btnAddCell.UseVisualStyleBackColor = true;
            this.btnAddCell.Click += new System.EventHandler(this.btnAddCell_Click);
            // 
            // btnRemoveCell
            // 
            this.btnRemoveCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCell.Location = new System.Drawing.Point(62, 16);
            this.btnRemoveCell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveCell.Name = "btnRemoveCell";
            this.btnRemoveCell.Size = new System.Drawing.Size(38, 22);
            this.btnRemoveCell.TabIndex = 33;
            this.btnRemoveCell.Text = "-";
            this.btnRemoveCell.UseVisualStyleBackColor = true;
            this.btnRemoveCell.Click += new System.EventHandler(this.btnRemoveCell_Click);
            // 
            // lblCellCount
            // 
            this.lblCellCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCellCount.AutoSize = true;
            this.lblCellCount.Location = new System.Drawing.Point(59, 0);
            this.lblCellCount.Name = "lblCellCount";
            this.lblCellCount.Size = new System.Drawing.Size(13, 17);
            this.lblCellCount.TabIndex = 34;
            this.lblCellCount.Text = "-";
            // 
            // gpbChrtCtrl
            // 
            this.gpbChrtCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbChrtCtrl.Controls.Add(this.btnReset);
            this.gpbChrtCtrl.Controls.Add(this.btnAddCell);
            this.gpbChrtCtrl.Controls.Add(this.lblCellCount);
            this.gpbChrtCtrl.Controls.Add(this.btnRemoveCell);
            this.gpbChrtCtrl.Location = new System.Drawing.Point(0, 511);
            this.gpbChrtCtrl.Name = "gpbChrtCtrl";
            this.gpbChrtCtrl.Size = new System.Drawing.Size(100, 43);
            this.gpbChrtCtrl.TabIndex = 35;
            this.gpbChrtCtrl.TabStop = false;
            this.gpbChrtCtrl.Text = "Column";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(35, 16);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(29, 22);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "R";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(64, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 35;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(101, 433);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(13, 17);
            this.lblMode.TabIndex = 36;
            this.lblMode.Text = "-";
            // 
            // gpbCursorMeasure
            // 
            this.gpbCursorMeasure.BackColor = System.Drawing.Color.Transparent;
            this.gpbCursorMeasure.Controls.Add(this.label14);
            this.gpbCursorMeasure.Controls.Add(this.lblDeltaValue);
            this.gpbCursorMeasure.Controls.Add(this.lblCursorRightValue);
            this.gpbCursorMeasure.Controls.Add(this.lblCursorLeftValue);
            this.gpbCursorMeasure.Controls.Add(this.label22);
            this.gpbCursorMeasure.Controls.Add(this.label23);
            this.gpbCursorMeasure.Location = new System.Drawing.Point(35, 31);
            this.gpbCursorMeasure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCursorMeasure.Name = "gpbCursorMeasure";
            this.gpbCursorMeasure.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCursorMeasure.Size = new System.Drawing.Size(271, 53);
            this.gpbCursorMeasure.TabIndex = 35;
            this.gpbCursorMeasure.TabStop = false;
            this.gpbCursorMeasure.Text = "Cursor Measurements";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(163, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "deltaV";
            // 
            // lblDeltaValue
            // 
            this.lblDeltaValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDeltaValue.AutoSize = true;
            this.lblDeltaValue.Location = new System.Drawing.Point(217, 32);
            this.lblDeltaValue.Name = "lblDeltaValue";
            this.lblDeltaValue.Size = new System.Drawing.Size(13, 17);
            this.lblDeltaValue.TabIndex = 32;
            this.lblDeltaValue.Text = "-";
            // 
            // lblCursorRightValue
            // 
            this.lblCursorRightValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCursorRightValue.AutoSize = true;
            this.lblCursorRightValue.Location = new System.Drawing.Point(104, 34);
            this.lblCursorRightValue.Name = "lblCursorRightValue";
            this.lblCursorRightValue.Size = new System.Drawing.Size(13, 17);
            this.lblCursorRightValue.TabIndex = 30;
            this.lblCursorRightValue.Text = "-";
            // 
            // lblCursorLeftValue
            // 
            this.lblCursorLeftValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCursorLeftValue.AutoSize = true;
            this.lblCursorLeftValue.Location = new System.Drawing.Point(104, 15);
            this.lblCursorLeftValue.Name = "lblCursorLeftValue";
            this.lblCursorLeftValue.Size = new System.Drawing.Size(13, 17);
            this.lblCursorLeftValue.TabIndex = 29;
            this.lblCursorLeftValue.Text = "-";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 17);
            this.label22.TabIndex = 26;
            this.label22.Text = "Cursor right";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 17);
            this.label23.TabIndex = 25;
            this.label23.Text = "Cursor left";
            // 
            // btnCursorFunction
            // 
            this.btnCursorFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCursorFunction.Location = new System.Drawing.Point(0, 487);
            this.btnCursorFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCursorFunction.Name = "btnCursorFunction";
            this.btnCursorFunction.Size = new System.Drawing.Size(100, 25);
            this.btnCursorFunction.TabIndex = 37;
            this.btnCursorFunction.Text = "Measure";
            this.btnCursorFunction.UseVisualStyleBackColor = true;
            this.btnCursorFunction.Click += new System.EventHandler(this.btnCursorFunction_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCursorFunction);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.gpbCursorMeasure);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.gpbChrtCtrl);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAutoTrig);
            this.Controls.Add(this.tbVerticalPosition);
            this.Controls.Add(this.gbbMeasure);
            this.Controls.Add(this.tbPos);
            this.Controls.Add(this.tbTrigg);
            this.Controls.Add(this.lbltrig);
            this.Controls.Add(this.chrt1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Main";
            this.Text = "PC Scope";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrt1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrigg)).EndInit();
            this.gbbMeasure.ResumeLayout(false);
            this.gbbMeasure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerticalPosition)).EndInit();
            this.gpbChrtCtrl.ResumeLayout(false);
            this.gpbChrtCtrl.PerformLayout();
            this.gpbCursorMeasure.ResumeLayout(false);
            this.gpbCursorMeasure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetParam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt1;
        private System.Windows.Forms.ComboBox cbxHSens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMenuConnect;
        private System.Windows.Forms.ToolStripMenuItem tMenuDisconnect;
        private System.Windows.Forms.ToolStripMenuItem tMenuDebugWindow;
        private System.Windows.Forms.ToolStripMenuItem tMenuAbout;
        private System.Windows.Forms.ComboBox cbxCouple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxVSens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tMenuConfig;
        private System.Windows.Forms.ComboBox cbxRecLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTrigSlope;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTrigType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltrig;
        private System.Windows.Forms.Button btnAutoTrig;
        private System.Windows.Forms.TrackBar tbTrigg;
        private System.Windows.Forms.Label lblScopeType;
        private System.Windows.Forms.ComboBox cbxReadDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbbMeasure;
        private System.Windows.Forms.Label lblVRMS;
        private System.Windows.Forms.Label lblVAvg;
        private System.Windows.Forms.Label lblVmin;
        private System.Windows.Forms.Label lblVmax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVpp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem tMenuStartCapture;
        private System.Windows.Forms.ToolStripMenuItem tMenuStopCapture;
        private System.Windows.Forms.TrackBar tbPos;
        private System.Windows.Forms.TrackBar tbVerticalPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem tMenuSaveAsCSV;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnAddCell;
        private System.Windows.Forms.Button btnRemoveCell;
        private System.Windows.Forms.Label lblCellCount;
        private System.Windows.Forms.GroupBox gpbChrtCtrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.GroupBox gpbCursorMeasure;
        private System.Windows.Forms.Label lblDeltaValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCursorRightValue;
        private System.Windows.Forms.Label lblCursorLeftValue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnCursorFunction;
        private System.Windows.Forms.Label lblConnectionInfo;
    }
}

