namespace ATTerm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtResultsHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasics = new System.Windows.Forms.TabPage();
            this.chkFW = new System.Windows.Forms.CheckBox();
            this.chkHW = new System.Windows.Forms.CheckBox();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.btnPower = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtFW = new System.Windows.Forms.TextBox();
            this.txtHW = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnVersions = new System.Windows.Forms.Button();
            this.chkAddLF = new System.Windows.Forms.CheckBox();
            this.chkAddCR = new System.Windows.Forms.CheckBox();
            this.txtSendCmd = new System.Windows.Forms.TextBox();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.txtNetwork = new System.Windows.Forms.TextBox();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.txtSignal = new System.Windows.Forms.TextBox();
            this.btnSignal = new System.Windows.Forms.Button();
            this.txtAT = new System.Windows.Forms.TextBox();
            this.btnAT = new System.Windows.Forms.Button();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.chkPauseStep = new System.Windows.Forms.CheckBox();
            this.chkSleepScript = new System.Windows.Forms.CheckBox();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBasics.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(993, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open Script";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBaud);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coms Port";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(113, 65);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 24);
            this.cmbBaud.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbBaud, "connection baud rate ");
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(6, 22);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(101, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Connect";
            this.toolTip1.SetToolTip(this.btnDisconnect, "Serial Port connect/disconnect");
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(113, 21);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 24);
            this.cmbPort.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbPort, "Com port used");
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(610, 31);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(371, 470);
            this.txtResults.TabIndex = 3;
            // 
            // txtResultsHex
            // 
            this.txtResultsHex.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultsHex.Location = new System.Drawing.Point(610, 535);
            this.txtResultsHex.Multiline = true;
            this.txtResultsHex.Name = "txtResultsHex";
            this.txtResultsHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultsHex.Size = new System.Drawing.Size(371, 149);
            this.txtResultsHex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Received (HEX):";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasics);
            this.tabControl1.Controls.Add(this.tabScripts);
            this.tabControl1.Location = new System.Drawing.Point(18, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 576);
            this.tabControl1.TabIndex = 32;
            // 
            // tabBasics
            // 
            this.tabBasics.Controls.Add(this.chkFW);
            this.tabBasics.Controls.Add(this.chkHW);
            this.tabBasics.Controls.Add(this.chkInfo);
            this.tabBasics.Controls.Add(this.txtPower);
            this.tabBasics.Controls.Add(this.btnPower);
            this.tabBasics.Controls.Add(this.txtSave);
            this.tabBasics.Controls.Add(this.btnSave);
            this.tabBasics.Controls.Add(this.txtReset);
            this.tabBasics.Controls.Add(this.btnReset);
            this.tabBasics.Controls.Add(this.txtFW);
            this.tabBasics.Controls.Add(this.txtHW);
            this.tabBasics.Controls.Add(this.txtInfo);
            this.tabBasics.Controls.Add(this.btnVersions);
            this.tabBasics.Controls.Add(this.chkAddLF);
            this.tabBasics.Controls.Add(this.chkAddCR);
            this.tabBasics.Controls.Add(this.txtSendCmd);
            this.tabBasics.Controls.Add(this.btnSendCmd);
            this.tabBasics.Controls.Add(this.txtNetwork);
            this.tabBasics.Controls.Add(this.btnNetwork);
            this.tabBasics.Controls.Add(this.txtSignal);
            this.tabBasics.Controls.Add(this.btnSignal);
            this.tabBasics.Controls.Add(this.txtAT);
            this.tabBasics.Controls.Add(this.btnAT);
            this.tabBasics.Location = new System.Drawing.Point(4, 25);
            this.tabBasics.Name = "tabBasics";
            this.tabBasics.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasics.Size = new System.Drawing.Size(506, 547);
            this.tabBasics.TabIndex = 0;
            this.tabBasics.Text = "Basics";
            this.tabBasics.UseVisualStyleBackColor = true;
            // 
            // chkFW
            // 
            this.chkFW.AutoSize = true;
            this.chkFW.Location = new System.Drawing.Point(384, 226);
            this.chkFW.Name = "chkFW";
            this.chkFW.Size = new System.Drawing.Size(101, 21);
            this.chkFW.TabIndex = 54;
            this.chkFW.Text = "FW version";
            this.chkFW.UseVisualStyleBackColor = true;
            // 
            // chkHW
            // 
            this.chkHW.AutoSize = true;
            this.chkHW.Location = new System.Drawing.Point(384, 198);
            this.chkHW.Name = "chkHW";
            this.chkHW.Size = new System.Drawing.Size(105, 21);
            this.chkHW.TabIndex = 53;
            this.chkHW.Text = "HW Version";
            this.chkHW.UseVisualStyleBackColor = true;
            // 
            // chkInfo
            // 
            this.chkInfo.AutoSize = true;
            this.chkInfo.Location = new System.Drawing.Point(384, 170);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(105, 21);
            this.chkInfo.TabIndex = 52;
            this.chkInfo.Text = "Info Version";
            this.chkInfo.UseVisualStyleBackColor = true;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(103, 319);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(254, 22);
            this.txtPower.TabIndex = 51;
            this.txtPower.Text = "AT+CPOWD=1";
            this.toolTip1.SetToolTip(this.txtPower, "AT command to execute");
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(10, 319);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(75, 23);
            this.btnPower.TabIndex = 50;
            this.btnPower.Text = "Power Off";
            this.toolTip1.SetToolTip(this.btnPower, "Execute command");
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(103, 291);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(254, 22);
            this.txtSave.TabIndex = 49;
            this.txtSave.Text = "AT&W";
            this.toolTip1.SetToolTip(this.txtSave, "AT command to execute");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Execute command");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(103, 263);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(254, 22);
            this.txtReset.TabIndex = 47;
            this.txtReset.Text = "AT&F";
            this.toolTip1.SetToolTip(this.txtReset, "AT command to execute");
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(10, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Execute command");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtFW
            // 
            this.txtFW.Location = new System.Drawing.Point(103, 224);
            this.txtFW.Name = "txtFW";
            this.txtFW.Size = new System.Drawing.Size(254, 22);
            this.txtFW.TabIndex = 45;
            this.txtFW.Text = "AT+GSV";
            this.toolTip1.SetToolTip(this.txtFW, "AT command to execute");
            // 
            // txtHW
            // 
            this.txtHW.Location = new System.Drawing.Point(103, 196);
            this.txtHW.Name = "txtHW";
            this.txtHW.Size = new System.Drawing.Size(254, 22);
            this.txtHW.TabIndex = 44;
            this.txtHW.Text = "AT+GMR";
            this.toolTip1.SetToolTip(this.txtHW, "AT command to execute");
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(103, 168);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(254, 22);
            this.txtInfo.TabIndex = 43;
            this.txtInfo.Text = "ATI";
            this.toolTip1.SetToolTip(this.txtInfo, "AT command to execute");
            // 
            // btnVersions
            // 
            this.btnVersions.Location = new System.Drawing.Point(10, 168);
            this.btnVersions.Name = "btnVersions";
            this.btnVersions.Size = new System.Drawing.Size(75, 23);
            this.btnVersions.TabIndex = 42;
            this.btnVersions.Text = "Versions";
            this.toolTip1.SetToolTip(this.btnVersions, "Execute command");
            this.btnVersions.UseVisualStyleBackColor = true;
            this.btnVersions.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // chkAddLF
            // 
            this.chkAddLF.AutoSize = true;
            this.chkAddLF.Location = new System.Drawing.Point(387, 41);
            this.chkAddLF.Name = "chkAddLF";
            this.chkAddLF.Size = new System.Drawing.Size(75, 21);
            this.chkAddLF.TabIndex = 41;
            this.chkAddLF.Text = "Add LF";
            this.chkAddLF.UseVisualStyleBackColor = true;
            // 
            // chkAddCR
            // 
            this.chkAddCR.AutoSize = true;
            this.chkAddCR.Location = new System.Drawing.Point(387, 13);
            this.chkAddCR.Name = "chkAddCR";
            this.chkAddCR.Size = new System.Drawing.Size(78, 21);
            this.chkAddCR.TabIndex = 40;
            this.chkAddCR.Text = "Add CR";
            this.chkAddCR.UseVisualStyleBackColor = true;
            // 
            // txtSendCmd
            // 
            this.txtSendCmd.Location = new System.Drawing.Point(103, 20);
            this.txtSendCmd.Multiline = true;
            this.txtSendCmd.Name = "txtSendCmd";
            this.txtSendCmd.Size = new System.Drawing.Size(254, 39);
            this.txtSendCmd.TabIndex = 39;
            this.txtSendCmd.Text = "AT";
            this.toolTip1.SetToolTip(this.txtSendCmd, "AT command to execute");
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(10, 20);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(87, 42);
            this.btnSendCmd.TabIndex = 38;
            this.btnSendCmd.Text = "Send Command";
            this.toolTip1.SetToolTip(this.btnSendCmd, "Execute command");
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtNetwork
            // 
            this.txtNetwork.Location = new System.Drawing.Point(103, 129);
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.Size = new System.Drawing.Size(254, 22);
            this.txtNetwork.TabIndex = 37;
            this.txtNetwork.Text = "AT+CREG?";
            this.toolTip1.SetToolTip(this.txtNetwork, "AT command to execute");
            // 
            // btnNetwork
            // 
            this.btnNetwork.Location = new System.Drawing.Point(10, 129);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(75, 23);
            this.btnNetwork.TabIndex = 36;
            this.btnNetwork.Text = "Network";
            this.toolTip1.SetToolTip(this.btnNetwork, "Execute command");
            this.btnNetwork.UseVisualStyleBackColor = true;
            this.btnNetwork.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtSignal
            // 
            this.txtSignal.Location = new System.Drawing.Point(103, 101);
            this.txtSignal.Name = "txtSignal";
            this.txtSignal.Size = new System.Drawing.Size(254, 22);
            this.txtSignal.TabIndex = 35;
            this.txtSignal.Text = "AT+CSQ";
            this.toolTip1.SetToolTip(this.txtSignal, "AT command to execute");
            // 
            // btnSignal
            // 
            this.btnSignal.Location = new System.Drawing.Point(10, 101);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.Size = new System.Drawing.Size(75, 23);
            this.btnSignal.TabIndex = 34;
            this.btnSignal.Text = "Signal";
            this.toolTip1.SetToolTip(this.btnSignal, "Execute command");
            this.btnSignal.UseVisualStyleBackColor = true;
            this.btnSignal.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // txtAT
            // 
            this.txtAT.Location = new System.Drawing.Point(103, 73);
            this.txtAT.Name = "txtAT";
            this.txtAT.Size = new System.Drawing.Size(254, 22);
            this.txtAT.TabIndex = 33;
            this.txtAT.Text = "AT";
            this.toolTip1.SetToolTip(this.txtAT, "AT command to execute");
            // 
            // btnAT
            // 
            this.btnAT.Location = new System.Drawing.Point(10, 73);
            this.btnAT.Name = "btnAT";
            this.btnAT.Size = new System.Drawing.Size(75, 23);
            this.btnAT.TabIndex = 32;
            this.btnAT.Text = "AT";
            this.toolTip1.SetToolTip(this.btnAT, "Execute command");
            this.btnAT.UseVisualStyleBackColor = true;
            this.btnAT.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.chkPauseStep);
            this.tabScripts.Controls.Add(this.chkSleepScript);
            this.tabScripts.Controls.Add(this.btnRunScript);
            this.tabScripts.Controls.Add(this.txtScript);
            this.tabScripts.Location = new System.Drawing.Point(4, 25);
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.Padding = new System.Windows.Forms.Padding(3);
            this.tabScripts.Size = new System.Drawing.Size(506, 547);
            this.tabScripts.TabIndex = 1;
            this.tabScripts.Text = "Script";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // chkPauseStep
            // 
            this.chkPauseStep.AutoSize = true;
            this.chkPauseStep.Location = new System.Drawing.Point(383, 65);
            this.chkPauseStep.Name = "chkPauseStep";
            this.chkPauseStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPauseStep.Size = new System.Drawing.Size(121, 21);
            this.chkPauseStep.TabIndex = 8;
            this.chkPauseStep.Text = "Pause @ Step";
            this.toolTip1.SetToolTip(this.chkPauseStep, "Stop after each command step");
            this.chkPauseStep.UseVisualStyleBackColor = true;
            // 
            // chkSleepScript
            // 
            this.chkSleepScript.AutoSize = true;
            this.chkSleepScript.Checked = true;
            this.chkSleepScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSleepScript.Location = new System.Drawing.Point(383, 20);
            this.chkSleepScript.Name = "chkSleepScript";
            this.chkSleepScript.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSleepScript.Size = new System.Drawing.Size(106, 21);
            this.chkSleepScript.TabIndex = 7;
            this.chkSleepScript.Text = "Sleep Script";
            this.toolTip1.SetToolTip(this.chkSleepScript, "Pause using default timer 500ms after each step");
            this.chkSleepScript.UseVisualStyleBackColor = true;
            // 
            // btnRunScript
            // 
            this.btnRunScript.Location = new System.Drawing.Point(6, 6);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(75, 23);
            this.btnRunScript.TabIndex = 6;
            this.btnRunScript.Text = "Run Script";
            this.toolTip1.SetToolTip(this.btnRunScript, "Execute the loaded script");
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtScript
            // 
            this.txtScript.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScript.Location = new System.Drawing.Point(6, 33);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScript.Size = new System.Drawing.Size(371, 458);
            this.txtScript.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 835);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultsHex);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AT Command Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBasics.ResumeLayout(false);
            this.tabBasics.PerformLayout();
            this.tabScripts.ResumeLayout(false);
            this.tabScripts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtResultsHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasics;
        private System.Windows.Forms.CheckBox chkFW;
        private System.Windows.Forms.CheckBox chkHW;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtReset;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtFW;
        private System.Windows.Forms.TextBox txtHW;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnVersions;
        private System.Windows.Forms.CheckBox chkAddLF;
        private System.Windows.Forms.CheckBox chkAddCR;
        private System.Windows.Forms.TextBox txtSendCmd;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.TextBox txtNetwork;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.TextBox txtSignal;
        private System.Windows.Forms.Button btnSignal;
        private System.Windows.Forms.TextBox txtAT;
        private System.Windows.Forms.Button btnAT;
        private System.Windows.Forms.TabPage tabScripts;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.CheckBox chkSleepScript;
        private System.Windows.Forms.CheckBox chkPauseStep;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

