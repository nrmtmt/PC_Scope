namespace test_dso
{
    partial class DebugWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugWindow));
            this.cbxCommandSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.cbxComSpeed = new System.Windows.Forms.ComboBox();
            this.cbxComName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnForceDSO112 = new System.Windows.Forms.Button();
            this.btnForceDSO068 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxReadDelay = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCommandAck = new System.Windows.Forms.CheckBox();
            this.cbExitedScope = new System.Windows.Forms.CheckBox();
            this.cbDataSample = new System.Windows.Forms.CheckBox();
            this.cbCurrParam = new System.Windows.Forms.CheckBox();
            this.cbScopeReady = new System.Windows.Forms.CheckBox();
            this.cbDataBlock = new System.Windows.Forms.CheckBox();
            this.cbCurrConf = new System.Windows.Forms.CheckBox();
            this.txtBufferOutput = new System.Windows.Forms.TextBox();
            this.txtEditCommand = new System.Windows.Forms.TextBox();
            this.gpbParams = new System.Windows.Forms.GroupBox();
            this.VertPosition = new System.Windows.Forms.Label();
            this.cbxCouple = new System.Windows.Forms.ComboBox();
            this.cbxHSens = new System.Windows.Forms.ComboBox();
            this.cbxVpos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTrigType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTrigLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTrigSlope = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbxVSens = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRecLength = new System.Windows.Forms.ComboBox();
            this.cbxTrigPos = new System.Windows.Forms.ComboBox();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lblMinMaxRecLength = new System.Windows.Forms.Label();
            this.lblMinMaxTrigPos = new System.Windows.Forms.Label();
            this.lblMinMaxTrigLevel = new System.Windows.Forms.Label();
            this.lblMinMaxTrigSlope = new System.Windows.Forms.Label();
            this.lblMinMaxTrigMode = new System.Windows.Forms.Label();
            this.lblMinMaxTb = new System.Windows.Forms.Label();
            this.lblMinMaxCpl = new System.Windows.Forms.Label();
            this.lblMinMaxSens = new System.Windows.Forms.Label();
            this.lblCplChangeable = new System.Windows.Forms.Label();
            this.lblSensChangeable = new System.Windows.Forms.Label();
            this.lblNoOfChannels = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPopulateConfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbParams.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCommandSelect
            // 
            this.cbxCommandSelect.FormattingEnabled = true;
            this.cbxCommandSelect.Location = new System.Drawing.Point(6, 21);
            this.cbxCommandSelect.Name = "cbxCommandSelect";
            this.cbxCommandSelect.Size = new System.Drawing.Size(485, 24);
            this.cbxCommandSelect.TabIndex = 0;
            this.cbxCommandSelect.SelectedIndexChanged += new System.EventHandler(this.cbxCommandSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port Name";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(6, 109);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(485, 23);
            this.btnSendCommand.TabIndex = 9;
            this.btnSendCommand.Text = "Send";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbxComSpeed
            // 
            this.cbxComSpeed.FormattingEnabled = true;
            this.cbxComSpeed.Location = new System.Drawing.Point(118, 52);
            this.cbxComSpeed.Name = "cbxComSpeed";
            this.cbxComSpeed.Size = new System.Drawing.Size(121, 24);
            this.cbxComSpeed.TabIndex = 8;
            // 
            // cbxComName
            // 
            this.cbxComName.FormattingEnabled = true;
            this.cbxComName.Location = new System.Drawing.Point(118, 25);
            this.cbxComName.Name = "cbxComName";
            this.cbxComName.Size = new System.Drawing.Size(121, 24);
            this.cbxComName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnForceDSO112);
            this.groupBox1.Controls.Add(this.btnForceDSO068);
            this.groupBox1.Controls.Add(this.cbxComName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxReadDelay);
            this.groupBox1.Controls.Add(this.cbxComSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 120);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial config";
            // 
            // btnForceDSO112
            // 
            this.btnForceDSO112.Location = new System.Drawing.Point(245, 51);
            this.btnForceDSO112.Name = "btnForceDSO112";
            this.btnForceDSO112.Size = new System.Drawing.Size(246, 25);
            this.btnForceDSO112.TabIndex = 26;
            this.btnForceDSO112.Text = "Run app in force DSO112A mode";
            this.btnForceDSO112.UseVisualStyleBackColor = true;
            this.btnForceDSO112.Click += new System.EventHandler(this.btnForceDSO112_Click);
            // 
            // btnForceDSO068
            // 
            this.btnForceDSO068.Location = new System.Drawing.Point(245, 25);
            this.btnForceDSO068.Name = "btnForceDSO068";
            this.btnForceDSO068.Size = new System.Drawing.Size(246, 24);
            this.btnForceDSO068.TabIndex = 25;
            this.btnForceDSO068.Text = "Run app in force DSO068 mode";
            this.btnForceDSO068.UseVisualStyleBackColor = true;
            this.btnForceDSO068.Click += new System.EventHandler(this.btnForceDSO068_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Read delay (ms)";
            // 
            // cbxReadDelay
            // 
            this.cbxReadDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxReadDelay.FormattingEnabled = true;
            this.cbxReadDelay.Location = new System.Drawing.Point(118, 79);
            this.cbxReadDelay.Name = "cbxReadDelay";
            this.cbxReadDelay.Size = new System.Drawing.Size(121, 24);
            this.cbxReadDelay.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtEditCommand);
            this.groupBox2.Controls.Add(this.cbxCommandSelect);
            this.groupBox2.Controls.Add(this.btnSendCommand);
            this.groupBox2.Location = new System.Drawing.Point(6, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 469);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command debug 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtBufferOutput);
            this.groupBox3.Location = new System.Drawing.Point(0, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 291);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output (double click to change between dec and hex)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCommandAck);
            this.groupBox4.Controls.Add(this.cbExitedScope);
            this.groupBox4.Controls.Add(this.cbDataSample);
            this.groupBox4.Controls.Add(this.cbCurrParam);
            this.groupBox4.Controls.Add(this.cbScopeReady);
            this.groupBox4.Controls.Add(this.cbDataBlock);
            this.groupBox4.Controls.Add(this.cbCurrConf);
            this.groupBox4.Location = new System.Drawing.Point(6, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(491, 89);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detected response frame";
            // 
            // cbCommandAck
            // 
            this.cbCommandAck.AutoCheck = false;
            this.cbCommandAck.AutoSize = true;
            this.cbCommandAck.Location = new System.Drawing.Point(236, 42);
            this.cbCommandAck.Name = "cbCommandAck";
            this.cbCommandAck.Size = new System.Drawing.Size(116, 21);
            this.cbCommandAck.TabIndex = 6;
            this.cbCommandAck.Text = "CommandAck";
            this.cbCommandAck.UseVisualStyleBackColor = true;
            // 
            // cbExitedScope
            // 
            this.cbExitedScope.AutoCheck = false;
            this.cbExitedScope.AutoSize = true;
            this.cbExitedScope.Location = new System.Drawing.Point(353, 21);
            this.cbExitedScope.Name = "cbExitedScope";
            this.cbExitedScope.Size = new System.Drawing.Size(131, 21);
            this.cbExitedScope.TabIndex = 5;
            this.cbExitedScope.Text = "USBModeExited";
            this.cbExitedScope.UseVisualStyleBackColor = true;
            // 
            // cbDataSample
            // 
            this.cbDataSample.AutoCheck = false;
            this.cbDataSample.AutoSize = true;
            this.cbDataSample.Location = new System.Drawing.Point(129, 42);
            this.cbDataSample.Name = "cbDataSample";
            this.cbDataSample.Size = new System.Drawing.Size(107, 21);
            this.cbDataSample.TabIndex = 4;
            this.cbDataSample.Text = "DataSample";
            this.cbDataSample.UseVisualStyleBackColor = true;
            // 
            // cbCurrParam
            // 
            this.cbCurrParam.AutoCheck = false;
            this.cbCurrParam.AutoSize = true;
            this.cbCurrParam.Location = new System.Drawing.Point(6, 42);
            this.cbCurrParam.Name = "cbCurrParam";
            this.cbCurrParam.Size = new System.Drawing.Size(125, 21);
            this.cbCurrParam.TabIndex = 3;
            this.cbCurrParam.Text = "CurrentParams";
            this.cbCurrParam.UseVisualStyleBackColor = true;
            // 
            // cbScopeReady
            // 
            this.cbScopeReady.AutoCheck = false;
            this.cbScopeReady.AutoSize = true;
            this.cbScopeReady.Location = new System.Drawing.Point(236, 21);
            this.cbScopeReady.Name = "cbScopeReady";
            this.cbScopeReady.Size = new System.Drawing.Size(111, 21);
            this.cbScopeReady.TabIndex = 2;
            this.cbScopeReady.Text = "ScopeReady";
            this.cbScopeReady.UseVisualStyleBackColor = true;
            // 
            // cbDataBlock
            // 
            this.cbDataBlock.AutoCheck = false;
            this.cbDataBlock.AutoSize = true;
            this.cbDataBlock.Location = new System.Drawing.Point(129, 21);
            this.cbDataBlock.Name = "cbDataBlock";
            this.cbDataBlock.Size = new System.Drawing.Size(94, 21);
            this.cbDataBlock.TabIndex = 1;
            this.cbDataBlock.Text = "DataBlock";
            this.cbDataBlock.UseVisualStyleBackColor = true;
            // 
            // cbCurrConf
            // 
            this.cbCurrConf.AutoCheck = false;
            this.cbCurrConf.AutoSize = true;
            this.cbCurrConf.Location = new System.Drawing.Point(6, 21);
            this.cbCurrConf.Name = "cbCurrConf";
            this.cbCurrConf.Size = new System.Drawing.Size(117, 21);
            this.cbCurrConf.TabIndex = 0;
            this.cbCurrConf.Text = "CurrentConfig";
            this.cbCurrConf.UseVisualStyleBackColor = true;
            // 
            // txtBufferOutput
            // 
            this.txtBufferOutput.Location = new System.Drawing.Point(6, 21);
            this.txtBufferOutput.Multiline = true;
            this.txtBufferOutput.Name = "txtBufferOutput";
            this.txtBufferOutput.ReadOnly = true;
            this.txtBufferOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBufferOutput.Size = new System.Drawing.Size(485, 173);
            this.txtBufferOutput.TabIndex = 14;
            this.txtBufferOutput.DoubleClick += new System.EventHandler(this.txtBufferOutput_Click);
            // 
            // txtEditCommand
            // 
            this.txtEditCommand.Location = new System.Drawing.Point(6, 51);
            this.txtEditCommand.Multiline = true;
            this.txtEditCommand.Name = "txtEditCommand";
            this.txtEditCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditCommand.Size = new System.Drawing.Size(485, 54);
            this.txtEditCommand.TabIndex = 24;
            // 
            // gpbParams
            // 
            this.gpbParams.Controls.Add(this.VertPosition);
            this.gpbParams.Controls.Add(this.cbxCouple);
            this.gpbParams.Controls.Add(this.cbxHSens);
            this.gpbParams.Controls.Add(this.cbxVpos);
            this.gpbParams.Controls.Add(this.label8);
            this.gpbParams.Controls.Add(this.label23);
            this.gpbParams.Controls.Add(this.label4);
            this.gpbParams.Controls.Add(this.cbxTrigType);
            this.gpbParams.Controls.Add(this.label9);
            this.gpbParams.Controls.Add(this.cbxTrigLevel);
            this.gpbParams.Controls.Add(this.label7);
            this.gpbParams.Controls.Add(this.label6);
            this.gpbParams.Controls.Add(this.cbxTrigSlope);
            this.gpbParams.Controls.Add(this.label22);
            this.gpbParams.Controls.Add(this.cbxVSens);
            this.gpbParams.Controls.Add(this.label5);
            this.gpbParams.Controls.Add(this.cbxRecLength);
            this.gpbParams.Controls.Add(this.cbxTrigPos);
            this.gpbParams.Location = new System.Drawing.Point(509, 12);
            this.gpbParams.Name = "gpbParams";
            this.gpbParams.Size = new System.Drawing.Size(485, 120);
            this.gpbParams.TabIndex = 14;
            this.gpbParams.TabStop = false;
            this.gpbParams.Text = "Command debug 2";
            // 
            // VertPosition
            // 
            this.VertPosition.AutoSize = true;
            this.VertPosition.Location = new System.Drawing.Point(288, 65);
            this.VertPosition.Name = "VertPosition";
            this.VertPosition.Size = new System.Drawing.Size(58, 17);
            this.VertPosition.TabIndex = 54;
            this.VertPosition.Text = "VertPos";
            // 
            // cbxCouple
            // 
            this.cbxCouple.FormattingEnabled = true;
            this.cbxCouple.Location = new System.Drawing.Point(386, 38);
            this.cbxCouple.Name = "cbxCouple";
            this.cbxCouple.Size = new System.Drawing.Size(95, 24);
            this.cbxCouple.TabIndex = 42;
            // 
            // cbxHSens
            // 
            this.cbxHSens.FormattingEnabled = true;
            this.cbxHSens.Location = new System.Drawing.Point(6, 38);
            this.cbxHSens.Name = "cbxHSens";
            this.cbxHSens.Size = new System.Drawing.Size(95, 24);
            this.cbxHSens.TabIndex = 39;
            // 
            // cbxVpos
            // 
            this.cbxVpos.FormattingEnabled = true;
            this.cbxVpos.Location = new System.Drawing.Point(291, 84);
            this.cbxVpos.Name = "cbxVpos";
            this.cbxVpos.Size = new System.Drawing.Size(95, 24);
            this.cbxVpos.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "TrigSlope";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(195, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 17);
            this.label23.TabIndex = 52;
            this.label23.Text = "TrigLevel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "VSens";
            // 
            // cbxTrigType
            // 
            this.cbxTrigType.FormattingEnabled = true;
            this.cbxTrigType.Location = new System.Drawing.Point(196, 38);
            this.cbxTrigType.Name = "cbxTrigType";
            this.cbxTrigType.Size = new System.Drawing.Size(95, 24);
            this.cbxTrigType.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "HSens";
            // 
            // cbxTrigLevel
            // 
            this.cbxTrigLevel.FormattingEnabled = true;
            this.cbxTrigLevel.Location = new System.Drawing.Point(196, 84);
            this.cbxTrigLevel.Name = "cbxTrigLevel";
            this.cbxTrigLevel.Size = new System.Drawing.Size(95, 24);
            this.cbxTrigLevel.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "TrigType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "RecLength";
            // 
            // cbxTrigSlope
            // 
            this.cbxTrigSlope.FormattingEnabled = true;
            this.cbxTrigSlope.Location = new System.Drawing.Point(291, 38);
            this.cbxTrigSlope.Name = "cbxTrigSlope";
            this.cbxTrigSlope.Size = new System.Drawing.Size(95, 24);
            this.cbxTrigSlope.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(98, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 17);
            this.label22.TabIndex = 50;
            this.label22.Text = "TrigPos";
            // 
            // cbxVSens
            // 
            this.cbxVSens.FormattingEnabled = true;
            this.cbxVSens.Location = new System.Drawing.Point(101, 38);
            this.cbxVSens.Name = "cbxVSens";
            this.cbxVSens.Size = new System.Drawing.Size(95, 24);
            this.cbxVSens.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Couple";
            // 
            // cbxRecLength
            // 
            this.cbxRecLength.FormattingEnabled = true;
            this.cbxRecLength.Location = new System.Drawing.Point(6, 84);
            this.cbxRecLength.Name = "cbxRecLength";
            this.cbxRecLength.Size = new System.Drawing.Size(95, 24);
            this.cbxRecLength.TabIndex = 44;
            // 
            // cbxTrigPos
            // 
            this.cbxTrigPos.FormattingEnabled = true;
            this.cbxTrigPos.Location = new System.Drawing.Point(101, 84);
            this.cbxTrigPos.Name = "cbxTrigPos";
            this.cbxTrigPos.Size = new System.Drawing.Size(95, 24);
            this.cbxTrigPos.TabIndex = 49;
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lblMinMaxRecLength);
            this.gpbInfo.Controls.Add(this.lblMinMaxTrigPos);
            this.gpbInfo.Controls.Add(this.lblMinMaxTrigLevel);
            this.gpbInfo.Controls.Add(this.lblMinMaxTrigSlope);
            this.gpbInfo.Controls.Add(this.lblMinMaxTrigMode);
            this.gpbInfo.Controls.Add(this.lblMinMaxTb);
            this.gpbInfo.Controls.Add(this.lblMinMaxCpl);
            this.gpbInfo.Controls.Add(this.lblMinMaxSens);
            this.gpbInfo.Controls.Add(this.lblCplChangeable);
            this.gpbInfo.Controls.Add(this.lblSensChangeable);
            this.gpbInfo.Controls.Add(this.lblNoOfChannels);
            this.gpbInfo.Controls.Add(this.lblModel);
            this.gpbInfo.Controls.Add(this.label17);
            this.gpbInfo.Controls.Add(this.label18);
            this.gpbInfo.Controls.Add(this.label19);
            this.gpbInfo.Controls.Add(this.label20);
            this.gpbInfo.Controls.Add(this.label21);
            this.gpbInfo.Controls.Add(this.label16);
            this.gpbInfo.Controls.Add(this.label15);
            this.gpbInfo.Controls.Add(this.label14);
            this.gpbInfo.Controls.Add(this.label13);
            this.gpbInfo.Controls.Add(this.label12);
            this.gpbInfo.Controls.Add(this.label11);
            this.gpbInfo.Controls.Add(this.label10);
            this.gpbInfo.Controls.Add(this.lblPopulateConfig);
            this.gpbInfo.Location = new System.Drawing.Point(509, 135);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(485, 429);
            this.gpbInfo.TabIndex = 34;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Scope info (connect to scope and retrieve config)";
            // 
            // lblMinMaxRecLength
            // 
            this.lblMinMaxRecLength.AutoSize = true;
            this.lblMinMaxRecLength.Location = new System.Drawing.Point(225, 357);
            this.lblMinMaxRecLength.Name = "lblMinMaxRecLength";
            this.lblMinMaxRecLength.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxRecLength.TabIndex = 49;
            this.lblMinMaxRecLength.Text = "-";
            // 
            // lblMinMaxTrigPos
            // 
            this.lblMinMaxTrigPos.AutoSize = true;
            this.lblMinMaxTrigPos.Location = new System.Drawing.Point(225, 331);
            this.lblMinMaxTrigPos.Name = "lblMinMaxTrigPos";
            this.lblMinMaxTrigPos.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxTrigPos.TabIndex = 48;
            this.lblMinMaxTrigPos.Text = "-";
            // 
            // lblMinMaxTrigLevel
            // 
            this.lblMinMaxTrigLevel.AutoSize = true;
            this.lblMinMaxTrigLevel.Location = new System.Drawing.Point(225, 305);
            this.lblMinMaxTrigLevel.Name = "lblMinMaxTrigLevel";
            this.lblMinMaxTrigLevel.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxTrigLevel.TabIndex = 47;
            this.lblMinMaxTrigLevel.Text = "-";
            // 
            // lblMinMaxTrigSlope
            // 
            this.lblMinMaxTrigSlope.AutoSize = true;
            this.lblMinMaxTrigSlope.Location = new System.Drawing.Point(225, 279);
            this.lblMinMaxTrigSlope.Name = "lblMinMaxTrigSlope";
            this.lblMinMaxTrigSlope.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxTrigSlope.TabIndex = 46;
            this.lblMinMaxTrigSlope.Text = "-";
            // 
            // lblMinMaxTrigMode
            // 
            this.lblMinMaxTrigMode.AutoSize = true;
            this.lblMinMaxTrigMode.Location = new System.Drawing.Point(225, 253);
            this.lblMinMaxTrigMode.Name = "lblMinMaxTrigMode";
            this.lblMinMaxTrigMode.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxTrigMode.TabIndex = 45;
            this.lblMinMaxTrigMode.Text = "-";
            // 
            // lblMinMaxTb
            // 
            this.lblMinMaxTb.AutoSize = true;
            this.lblMinMaxTb.Location = new System.Drawing.Point(225, 227);
            this.lblMinMaxTb.Name = "lblMinMaxTb";
            this.lblMinMaxTb.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxTb.TabIndex = 44;
            this.lblMinMaxTb.Text = "-";
            // 
            // lblMinMaxCpl
            // 
            this.lblMinMaxCpl.AutoSize = true;
            this.lblMinMaxCpl.Location = new System.Drawing.Point(225, 201);
            this.lblMinMaxCpl.Name = "lblMinMaxCpl";
            this.lblMinMaxCpl.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxCpl.TabIndex = 43;
            this.lblMinMaxCpl.Text = "-";
            // 
            // lblMinMaxSens
            // 
            this.lblMinMaxSens.AutoSize = true;
            this.lblMinMaxSens.Location = new System.Drawing.Point(225, 175);
            this.lblMinMaxSens.Name = "lblMinMaxSens";
            this.lblMinMaxSens.Size = new System.Drawing.Size(13, 17);
            this.lblMinMaxSens.TabIndex = 42;
            this.lblMinMaxSens.Text = "-";
            // 
            // lblCplChangeable
            // 
            this.lblCplChangeable.AutoSize = true;
            this.lblCplChangeable.Location = new System.Drawing.Point(225, 149);
            this.lblCplChangeable.Name = "lblCplChangeable";
            this.lblCplChangeable.Size = new System.Drawing.Size(13, 17);
            this.lblCplChangeable.TabIndex = 41;
            this.lblCplChangeable.Text = "-";
            // 
            // lblSensChangeable
            // 
            this.lblSensChangeable.AutoSize = true;
            this.lblSensChangeable.Location = new System.Drawing.Point(225, 123);
            this.lblSensChangeable.Name = "lblSensChangeable";
            this.lblSensChangeable.Size = new System.Drawing.Size(13, 17);
            this.lblSensChangeable.TabIndex = 40;
            this.lblSensChangeable.Text = "-";
            // 
            // lblNoOfChannels
            // 
            this.lblNoOfChannels.AutoSize = true;
            this.lblNoOfChannels.Location = new System.Drawing.Point(225, 97);
            this.lblNoOfChannels.Name = "lblNoOfChannels";
            this.lblNoOfChannels.Size = new System.Drawing.Size(13, 17);
            this.lblNoOfChannels.TabIndex = 39;
            this.lblNoOfChannels.Text = "-";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(225, 55);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(13, 17);
            this.lblModel.TabIndex = 38;
            this.lblModel.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Min/max record length";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 331);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Min/max trigger position";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(183, 17);
            this.label19.TabIndex = 35;
            this.label19.Text = "Min/max trigger level setting";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(188, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "Min/max trigger slope setting";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 253);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(189, 17);
            this.label21.TabIndex = 33;
            this.label21.Text = "Min/max trigger mode setting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Min/max timebase setting";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Min/max couple seting";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Min/max sensitivity setting";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Couple changeable by host";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Sensitivity changeable by host";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "No. of channels";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Scope model";
            // 
            // lblPopulateConfig
            // 
            this.lblPopulateConfig.Location = new System.Drawing.Point(6, 21);
            this.lblPopulateConfig.Name = "lblPopulateConfig";
            this.lblPopulateConfig.Size = new System.Drawing.Size(475, 24);
            this.lblPopulateConfig.TabIndex = 25;
            this.lblPopulateConfig.Text = "Populate";
            this.lblPopulateConfig.UseVisualStyleBackColor = true;
            this.lblPopulateConfig.Click += new System.EventHandler(this.lblPopulateConfig_Click);
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.gpbParams);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DebugWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Debug window";
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gpbParams.ResumeLayout(false);
            this.gpbParams.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCommandSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.ComboBox cbxComSpeed;
        private System.Windows.Forms.ComboBox cbxComName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBufferOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxReadDelay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbExitedScope;
        private System.Windows.Forms.CheckBox cbDataSample;
        private System.Windows.Forms.CheckBox cbCurrParam;
        private System.Windows.Forms.CheckBox cbScopeReady;
        private System.Windows.Forms.CheckBox cbDataBlock;
        private System.Windows.Forms.CheckBox cbCurrConf;
        private System.Windows.Forms.GroupBox gpbParams;
        private System.Windows.Forms.TextBox txtEditCommand;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label lblCplChangeable;
        private System.Windows.Forms.Label lblSensChangeable;
        private System.Windows.Forms.Label lblNoOfChannels;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button lblPopulateConfig;
        private System.Windows.Forms.Label lblMinMaxRecLength;
        private System.Windows.Forms.Label lblMinMaxTrigPos;
        private System.Windows.Forms.Label lblMinMaxTrigLevel;
        private System.Windows.Forms.Label lblMinMaxTrigSlope;
        private System.Windows.Forms.Label lblMinMaxTrigMode;
        private System.Windows.Forms.Label lblMinMaxTb;
        private System.Windows.Forms.Label lblMinMaxCpl;
        private System.Windows.Forms.Label lblMinMaxSens;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxTrigLevel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbxTrigPos;
        private System.Windows.Forms.ComboBox cbxCouple;
        private System.Windows.Forms.ComboBox cbxTrigSlope;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxHSens;
        private System.Windows.Forms.ComboBox cbxTrigType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxVSens;
        private System.Windows.Forms.ComboBox cbxRecLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label VertPosition;
        private System.Windows.Forms.ComboBox cbxVpos;
        private System.Windows.Forms.CheckBox cbCommandAck;
        private System.Windows.Forms.Button btnForceDSO112;
        private System.Windows.Forms.Button btnForceDSO068;
    }
}