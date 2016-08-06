namespace UniversalTCPClient
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
            this.contextMenuStripClear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new UniversalTCPClient.Controls.BetterSplitContainer();
            this.splitContainer2 = new UniversalTCPClient.Controls.BetterSplitContainer();
            this.groupBoxIPScanner = new System.Windows.Forms.GroupBox();
            this.labelms1 = new System.Windows.Forms.Label();
            this.numericUpDownIPScanTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScanIPAttempts = new System.Windows.Forms.NumericUpDown();
            this.labelTimeout1 = new System.Windows.Forms.Label();
            this.labelAttempts = new System.Windows.Forms.Label();
            this.ipAddressControlMaxIP = new IPAddressControlLib.IPAddressControl();
            this.labelMaxIP = new System.Windows.Forms.Label();
            this.ipAddressControlMinIP = new IPAddressControlLib.IPAddressControl();
            this.infoProgressBarIPScanner = new UniversalTCPClient.Controls.InfoProgressBar();
            this.labelProgress1 = new System.Windows.Forms.Label();
            this.labelResults1 = new System.Windows.Forms.Label();
            this.listViewIPScan = new BrightIdeasSoftware.FastObjectListView();
            this.IPScanColumnIP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.IPScanColumnHostName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonClearIP = new System.Windows.Forms.Button();
            this.buttonIPScan = new System.Windows.Forms.Button();
            this.labelMinIP = new System.Windows.Forms.Label();
            this.groupBoxPortScanner = new System.Windows.Forms.GroupBox();
            this.hostTextBoxPortScanHost = new UniversalTCPClient.Controls.HostTextBox();
            this.labelMinPort = new System.Windows.Forms.Label();
            this.labelms2 = new System.Windows.Forms.Label();
            this.numericUpDownMinPort = new System.Windows.Forms.NumericUpDown();
            this.infoProgressBarPortScanner = new UniversalTCPClient.Controls.InfoProgressBar();
            this.labelProgress2 = new System.Windows.Forms.Label();
            this.numericUpDownPortScanTimeout = new System.Windows.Forms.NumericUpDown();
            this.labelTimeout2 = new System.Windows.Forms.Label();
            this.labelResults2 = new System.Windows.Forms.Label();
            this.listViewPortScan = new BrightIdeasSoftware.FastObjectListView();
            this.PortScanColumnIP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PortScanColumnHostName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PortScanColumnPort = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonClearPort = new System.Windows.Forms.Button();
            this.buttonPortScan = new System.Windows.Forms.Button();
            this.numericUpDownMaxPort = new System.Windows.Forms.NumericUpDown();
            this.labelMaxPort = new System.Windows.Forms.Label();
            this.labelHost1 = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.splitContainer3 = new UniversalTCPClient.Controls.BetterSplitContainer();
            this.checkBoxAutoClear = new System.Windows.Forms.CheckBox();
            this.sendBoxSend = new UniversalTCPClient.Controls.SendBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.labelLineending = new System.Windows.Forms.Label();
            this.comboBoxLineending = new System.Windows.Forms.ComboBox();
            this.labelCharset = new System.Windows.Forms.Label();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.numericUpDownPortConnect = new System.Windows.Forms.NumericUpDown();
            this.hostTextBoxHostConnect = new UniversalTCPClient.Controls.HostTextBox();
            this.labelHost2 = new System.Windows.Forms.Label();
            this.contextMenuStripClear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxIPScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIPScanTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanIPAttempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewIPScan)).BeginInit();
            this.groupBoxPortScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortScanTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewPortScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPort)).BeginInit();
            this.groupBoxClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortConnect)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripClear
            // 
            this.contextMenuStripClear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemClear});
            this.contextMenuStripClear.Name = "contextMenuStripClear";
            this.contextMenuStripClear.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripClear.Size = new System.Drawing.Size(122, 26);
            this.contextMenuStripClear.Text = "Clear";
            // 
            // toolStripMenuItemClear
            // 
            this.toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            this.toolStripMenuItemClear.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemClear.Text = "Clear log";
            this.toolStripMenuItemClear.Click += new System.EventHandler(this.toolStripMenuItemClear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxClient);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1168, 350);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxIPScanner);
            this.splitContainer2.Panel1MinSize = 176;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBoxPortScanner);
            this.splitContainer2.Panel2MinSize = 176;
            this.splitContainer2.Size = new System.Drawing.Size(366, 350);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxIPScanner
            // 
            this.groupBoxIPScanner.Controls.Add(this.labelms1);
            this.groupBoxIPScanner.Controls.Add(this.numericUpDownIPScanTimeout);
            this.groupBoxIPScanner.Controls.Add(this.numericUpDownScanIPAttempts);
            this.groupBoxIPScanner.Controls.Add(this.labelTimeout1);
            this.groupBoxIPScanner.Controls.Add(this.labelAttempts);
            this.groupBoxIPScanner.Controls.Add(this.ipAddressControlMaxIP);
            this.groupBoxIPScanner.Controls.Add(this.labelMaxIP);
            this.groupBoxIPScanner.Controls.Add(this.ipAddressControlMinIP);
            this.groupBoxIPScanner.Controls.Add(this.infoProgressBarIPScanner);
            this.groupBoxIPScanner.Controls.Add(this.labelProgress1);
            this.groupBoxIPScanner.Controls.Add(this.labelResults1);
            this.groupBoxIPScanner.Controls.Add(this.listViewIPScan);
            this.groupBoxIPScanner.Controls.Add(this.buttonClearIP);
            this.groupBoxIPScanner.Controls.Add(this.buttonIPScan);
            this.groupBoxIPScanner.Controls.Add(this.labelMinIP);
            this.groupBoxIPScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIPScanner.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIPScanner.Name = "groupBoxIPScanner";
            this.groupBoxIPScanner.Size = new System.Drawing.Size(178, 348);
            this.groupBoxIPScanner.TabIndex = 2;
            this.groupBoxIPScanner.TabStop = false;
            this.groupBoxIPScanner.Text = "IP scanner";
            // 
            // labelms1
            // 
            this.labelms1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelms1.AutoSize = true;
            this.labelms1.Location = new System.Drawing.Point(152, 99);
            this.labelms1.Name = "labelms1";
            this.labelms1.Size = new System.Drawing.Size(20, 13);
            this.labelms1.TabIndex = 3;
            this.labelms1.Text = "ms";
            // 
            // numericUpDownIPScanTimeout
            // 
            this.numericUpDownIPScanTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownIPScanTimeout.Location = new System.Drawing.Point(72, 97);
            this.numericUpDownIPScanTimeout.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.numericUpDownIPScanTimeout.Name = "numericUpDownIPScanTimeout";
            this.numericUpDownIPScanTimeout.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownIPScanTimeout.TabIndex = 3;
            this.numericUpDownIPScanTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownIPScanTimeout.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // numericUpDownScanIPAttempts
            // 
            this.numericUpDownScanIPAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownScanIPAttempts.Location = new System.Drawing.Point(72, 71);
            this.numericUpDownScanIPAttempts.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.numericUpDownScanIPAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScanIPAttempts.Name = "numericUpDownScanIPAttempts";
            this.numericUpDownScanIPAttempts.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownScanIPAttempts.TabIndex = 2;
            this.numericUpDownScanIPAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScanIPAttempts.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelTimeout1
            // 
            this.labelTimeout1.AutoSize = true;
            this.labelTimeout1.Location = new System.Drawing.Point(11, 99);
            this.labelTimeout1.Name = "labelTimeout1";
            this.labelTimeout1.Size = new System.Drawing.Size(48, 13);
            this.labelTimeout1.TabIndex = 3;
            this.labelTimeout1.Text = "Timeout:";
            // 
            // labelAttempts
            // 
            this.labelAttempts.AutoSize = true;
            this.labelAttempts.Location = new System.Drawing.Point(11, 73);
            this.labelAttempts.Name = "labelAttempts";
            this.labelAttempts.Size = new System.Drawing.Size(51, 13);
            this.labelAttempts.TabIndex = 2;
            this.labelAttempts.Text = "Attempts:";
            // 
            // ipAddressControlMaxIP
            // 
            this.ipAddressControlMaxIP.AllowInternalTab = false;
            this.ipAddressControlMaxIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddressControlMaxIP.AutoHeight = true;
            this.ipAddressControlMaxIP.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControlMaxIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControlMaxIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControlMaxIP.Location = new System.Drawing.Point(72, 45);
            this.ipAddressControlMaxIP.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControlMaxIP.Name = "ipAddressControlMaxIP";
            this.ipAddressControlMaxIP.ReadOnly = false;
            this.ipAddressControlMaxIP.Size = new System.Drawing.Size(100, 20);
            this.ipAddressControlMaxIP.TabIndex = 1;
            this.ipAddressControlMaxIP.Text = "...";
            this.ipAddressControlMaxIP.TextChanged += new System.EventHandler(this.ipAddressControlMaxIP_TextChanged);
            // 
            // labelMaxIP
            // 
            this.labelMaxIP.AutoSize = true;
            this.labelMaxIP.Location = new System.Drawing.Point(11, 47);
            this.labelMaxIP.Name = "labelMaxIP";
            this.labelMaxIP.Size = new System.Drawing.Size(40, 13);
            this.labelMaxIP.TabIndex = 1;
            this.labelMaxIP.Text = "MaxIP:";
            // 
            // ipAddressControlMinIP
            // 
            this.ipAddressControlMinIP.AllowInternalTab = false;
            this.ipAddressControlMinIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddressControlMinIP.AutoHeight = true;
            this.ipAddressControlMinIP.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControlMinIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControlMinIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControlMinIP.Location = new System.Drawing.Point(72, 19);
            this.ipAddressControlMinIP.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControlMinIP.Name = "ipAddressControlMinIP";
            this.ipAddressControlMinIP.ReadOnly = false;
            this.ipAddressControlMinIP.Size = new System.Drawing.Size(100, 20);
            this.ipAddressControlMinIP.TabIndex = 0;
            this.ipAddressControlMinIP.Text = "...";
            this.ipAddressControlMinIP.TextChanged += new System.EventHandler(this.ipAddressControlMinIP_TextChanged);
            // 
            // infoProgressBarIPScanner
            // 
            this.infoProgressBarIPScanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoProgressBarIPScanner.CustomText = "Done!";
            this.infoProgressBarIPScanner.DisplayStyle = UniversalTCPClient.Controls.ProgressBarDisplayText.Percentage;
            this.infoProgressBarIPScanner.Location = new System.Drawing.Point(14, 165);
            this.infoProgressBarIPScanner.Name = "infoProgressBarIPScanner";
            this.infoProgressBarIPScanner.Size = new System.Drawing.Size(158, 23);
            this.infoProgressBarIPScanner.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.infoProgressBarIPScanner.TabIndex = 6;
            // 
            // labelProgress1
            // 
            this.labelProgress1.AutoSize = true;
            this.labelProgress1.Location = new System.Drawing.Point(11, 149);
            this.labelProgress1.Name = "labelProgress1";
            this.labelProgress1.Size = new System.Drawing.Size(51, 13);
            this.labelProgress1.TabIndex = 6;
            this.labelProgress1.Text = "Progress:";
            // 
            // labelResults1
            // 
            this.labelResults1.AutoSize = true;
            this.labelResults1.Location = new System.Drawing.Point(11, 191);
            this.labelResults1.Name = "labelResults1";
            this.labelResults1.Size = new System.Drawing.Size(45, 13);
            this.labelResults1.TabIndex = 7;
            this.labelResults1.Text = "Results:";
            // 
            // listViewIPScan
            // 
            this.listViewIPScan.AllColumns.Add(this.IPScanColumnIP);
            this.listViewIPScan.AllColumns.Add(this.IPScanColumnHostName);
            this.listViewIPScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIPScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewIPScan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IPScanColumnIP,
            this.IPScanColumnHostName});
            this.listViewIPScan.GridLines = true;
            this.listViewIPScan.Location = new System.Drawing.Point(14, 207);
            this.listViewIPScan.MultiSelect = false;
            this.listViewIPScan.Name = "listViewIPScan";
            this.listViewIPScan.ShowGroups = false;
            this.listViewIPScan.Size = new System.Drawing.Size(158, 135);
            this.listViewIPScan.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewIPScan.TabIndex = 7;
            this.listViewIPScan.UseCompatibleStateImageBehavior = false;
            this.listViewIPScan.View = System.Windows.Forms.View.Details;
            this.listViewIPScan.VirtualMode = true;
            this.listViewIPScan.SelectionChanged += new System.EventHandler(this.listViewIPScan_SelectionChanged);
            // 
            // IPScanColumnIP
            // 
            this.IPScanColumnIP.AspectName = "IP";
            this.IPScanColumnIP.Text = "IP";
            this.IPScanColumnIP.Width = 92;
            // 
            // IPScanColumnHostName
            // 
            this.IPScanColumnHostName.AspectName = "HostName";
            this.IPScanColumnHostName.Text = "Name";
            this.IPScanColumnHostName.Width = 57;
            // 
            // buttonClearIP
            // 
            this.buttonClearIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearIP.Location = new System.Drawing.Point(97, 123);
            this.buttonClearIP.Name = "buttonClearIP";
            this.buttonClearIP.Size = new System.Drawing.Size(75, 23);
            this.buttonClearIP.TabIndex = 5;
            this.buttonClearIP.Text = "Clear list";
            this.buttonClearIP.UseVisualStyleBackColor = true;
            this.buttonClearIP.Click += new System.EventHandler(this.buttonClearIP_Click);
            // 
            // buttonIPScan
            // 
            this.buttonIPScan.Enabled = false;
            this.buttonIPScan.Location = new System.Drawing.Point(14, 123);
            this.buttonIPScan.Name = "buttonIPScan";
            this.buttonIPScan.Size = new System.Drawing.Size(75, 23);
            this.buttonIPScan.TabIndex = 4;
            this.buttonIPScan.Text = "Scan!";
            this.buttonIPScan.UseVisualStyleBackColor = true;
            this.buttonIPScan.Click += new System.EventHandler(this.buttonIPScan_Click);
            // 
            // labelMinIP
            // 
            this.labelMinIP.AutoSize = true;
            this.labelMinIP.Location = new System.Drawing.Point(11, 22);
            this.labelMinIP.Name = "labelMinIP";
            this.labelMinIP.Size = new System.Drawing.Size(37, 13);
            this.labelMinIP.TabIndex = 0;
            this.labelMinIP.Text = "MinIP:";
            // 
            // groupBoxPortScanner
            // 
            this.groupBoxPortScanner.Controls.Add(this.hostTextBoxPortScanHost);
            this.groupBoxPortScanner.Controls.Add(this.labelMinPort);
            this.groupBoxPortScanner.Controls.Add(this.labelms2);
            this.groupBoxPortScanner.Controls.Add(this.numericUpDownMinPort);
            this.groupBoxPortScanner.Controls.Add(this.infoProgressBarPortScanner);
            this.groupBoxPortScanner.Controls.Add(this.labelProgress2);
            this.groupBoxPortScanner.Controls.Add(this.numericUpDownPortScanTimeout);
            this.groupBoxPortScanner.Controls.Add(this.labelTimeout2);
            this.groupBoxPortScanner.Controls.Add(this.labelResults2);
            this.groupBoxPortScanner.Controls.Add(this.listViewPortScan);
            this.groupBoxPortScanner.Controls.Add(this.buttonClearPort);
            this.groupBoxPortScanner.Controls.Add(this.buttonPortScan);
            this.groupBoxPortScanner.Controls.Add(this.numericUpDownMaxPort);
            this.groupBoxPortScanner.Controls.Add(this.labelMaxPort);
            this.groupBoxPortScanner.Controls.Add(this.labelHost1);
            this.groupBoxPortScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPortScanner.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPortScanner.Name = "groupBoxPortScanner";
            this.groupBoxPortScanner.Size = new System.Drawing.Size(180, 348);
            this.groupBoxPortScanner.TabIndex = 2;
            this.groupBoxPortScanner.TabStop = false;
            this.groupBoxPortScanner.Text = "Port scanner";
            // 
            // hostTextBoxPortScanHost
            // 
            this.hostTextBoxPortScanHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostTextBoxPortScanHost.Location = new System.Drawing.Point(66, 19);
            this.hostTextBoxPortScanHost.Name = "hostTextBoxPortScanHost";
            this.hostTextBoxPortScanHost.Size = new System.Drawing.Size(108, 20);
            this.hostTextBoxPortScanHost.TabIndex = 0;
            this.hostTextBoxPortScanHost.IPValidChanged += new UniversalTCPClient.Controls.HostTextBox.IPValidationChangedEventHandler(this.hostTextBoxPortScannerHost_IPValidChanged);
            // 
            // labelMinPort
            // 
            this.labelMinPort.AutoSize = true;
            this.labelMinPort.Location = new System.Drawing.Point(11, 47);
            this.labelMinPort.Name = "labelMinPort";
            this.labelMinPort.Size = new System.Drawing.Size(46, 13);
            this.labelMinPort.TabIndex = 1;
            this.labelMinPort.Text = "MinPort:";
            // 
            // labelms2
            // 
            this.labelms2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelms2.AutoSize = true;
            this.labelms2.Location = new System.Drawing.Point(154, 99);
            this.labelms2.Name = "labelms2";
            this.labelms2.Size = new System.Drawing.Size(20, 13);
            this.labelms2.TabIndex = 8;
            this.labelms2.Text = "ms";
            // 
            // numericUpDownMinPort
            // 
            this.numericUpDownMinPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMinPort.Location = new System.Drawing.Point(66, 45);
            this.numericUpDownMinPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownMinPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinPort.Name = "numericUpDownMinPort";
            this.numericUpDownMinPort.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownMinPort.TabIndex = 1;
            this.numericUpDownMinPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinPort.ValueChanged += new System.EventHandler(this.numericUpDownMinPort_ValueChanged);
            this.numericUpDownMinPort.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // infoProgressBarPortScanner
            // 
            this.infoProgressBarPortScanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoProgressBarPortScanner.CustomText = "Done!";
            this.infoProgressBarPortScanner.DisplayStyle = UniversalTCPClient.Controls.ProgressBarDisplayText.Percentage;
            this.infoProgressBarPortScanner.Location = new System.Drawing.Point(14, 165);
            this.infoProgressBarPortScanner.Name = "infoProgressBarPortScanner";
            this.infoProgressBarPortScanner.Size = new System.Drawing.Size(160, 23);
            this.infoProgressBarPortScanner.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.infoProgressBarPortScanner.TabIndex = 6;
            // 
            // labelProgress2
            // 
            this.labelProgress2.AutoSize = true;
            this.labelProgress2.Location = new System.Drawing.Point(11, 149);
            this.labelProgress2.Name = "labelProgress2";
            this.labelProgress2.Size = new System.Drawing.Size(51, 13);
            this.labelProgress2.TabIndex = 6;
            this.labelProgress2.Text = "Progress:";
            // 
            // numericUpDownPortScanTimeout
            // 
            this.numericUpDownPortScanTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPortScanTimeout.Location = new System.Drawing.Point(66, 97);
            this.numericUpDownPortScanTimeout.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.numericUpDownPortScanTimeout.Name = "numericUpDownPortScanTimeout";
            this.numericUpDownPortScanTimeout.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownPortScanTimeout.TabIndex = 3;
            this.numericUpDownPortScanTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPortScanTimeout.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelTimeout2
            // 
            this.labelTimeout2.AutoSize = true;
            this.labelTimeout2.Location = new System.Drawing.Point(11, 99);
            this.labelTimeout2.Name = "labelTimeout2";
            this.labelTimeout2.Size = new System.Drawing.Size(48, 13);
            this.labelTimeout2.TabIndex = 3;
            this.labelTimeout2.Text = "Timeout:";
            // 
            // labelResults2
            // 
            this.labelResults2.AutoSize = true;
            this.labelResults2.Location = new System.Drawing.Point(11, 191);
            this.labelResults2.Name = "labelResults2";
            this.labelResults2.Size = new System.Drawing.Size(45, 13);
            this.labelResults2.TabIndex = 7;
            this.labelResults2.Text = "Results:";
            // 
            // listViewPortScan
            // 
            this.listViewPortScan.AllColumns.Add(this.PortScanColumnIP);
            this.listViewPortScan.AllColumns.Add(this.PortScanColumnHostName);
            this.listViewPortScan.AllColumns.Add(this.PortScanColumnPort);
            this.listViewPortScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPortScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPortScan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PortScanColumnIP,
            this.PortScanColumnHostName,
            this.PortScanColumnPort});
            this.listViewPortScan.GridLines = true;
            this.listViewPortScan.Location = new System.Drawing.Point(14, 207);
            this.listViewPortScan.Name = "listViewPortScan";
            this.listViewPortScan.ShowGroups = false;
            this.listViewPortScan.Size = new System.Drawing.Size(160, 135);
            this.listViewPortScan.TabIndex = 7;
            this.listViewPortScan.TintSortColumn = true;
            this.listViewPortScan.UseCompatibleStateImageBehavior = false;
            this.listViewPortScan.View = System.Windows.Forms.View.Details;
            this.listViewPortScan.VirtualMode = true;
            this.listViewPortScan.SelectedIndexChanged += new System.EventHandler(this.listViewPortScan_SelectedIndexChanged);
            // 
            // PortScanColumnIP
            // 
            this.PortScanColumnIP.AspectName = "IP";
            this.PortScanColumnIP.Text = "IP";
            this.PortScanColumnIP.Width = 75;
            // 
            // PortScanColumnHostName
            // 
            this.PortScanColumnHostName.AspectName = "HostName";
            this.PortScanColumnHostName.Text = "Name";
            this.PortScanColumnHostName.Width = 81;
            // 
            // PortScanColumnPort
            // 
            this.PortScanColumnPort.AspectName = "Port";
            this.PortScanColumnPort.Text = "Port";
            this.PortScanColumnPort.Width = 46;
            // 
            // buttonClearPort
            // 
            this.buttonClearPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearPort.Location = new System.Drawing.Point(99, 123);
            this.buttonClearPort.Name = "buttonClearPort";
            this.buttonClearPort.Size = new System.Drawing.Size(75, 23);
            this.buttonClearPort.TabIndex = 5;
            this.buttonClearPort.Text = "Clear list";
            this.buttonClearPort.UseVisualStyleBackColor = true;
            this.buttonClearPort.Click += new System.EventHandler(this.buttonClearPort_Click);
            // 
            // buttonPortScan
            // 
            this.buttonPortScan.Enabled = false;
            this.buttonPortScan.Location = new System.Drawing.Point(14, 123);
            this.buttonPortScan.Name = "buttonPortScan";
            this.buttonPortScan.Size = new System.Drawing.Size(75, 23);
            this.buttonPortScan.TabIndex = 4;
            this.buttonPortScan.Text = "Scan!";
            this.buttonPortScan.UseVisualStyleBackColor = true;
            this.buttonPortScan.Click += new System.EventHandler(this.buttonPortScan_Click);
            // 
            // numericUpDownMaxPort
            // 
            this.numericUpDownMaxPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMaxPort.Location = new System.Drawing.Point(66, 71);
            this.numericUpDownMaxPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownMaxPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxPort.Name = "numericUpDownMaxPort";
            this.numericUpDownMaxPort.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownMaxPort.TabIndex = 2;
            this.numericUpDownMaxPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxPort.ValueChanged += new System.EventHandler(this.numericUpDownMaxPort_ValueChanged);
            this.numericUpDownMaxPort.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // labelMaxPort
            // 
            this.labelMaxPort.AutoSize = true;
            this.labelMaxPort.Location = new System.Drawing.Point(11, 73);
            this.labelMaxPort.Name = "labelMaxPort";
            this.labelMaxPort.Size = new System.Drawing.Size(49, 13);
            this.labelMaxPort.TabIndex = 2;
            this.labelMaxPort.Text = "MaxPort:";
            // 
            // labelHost1
            // 
            this.labelHost1.AutoSize = true;
            this.labelHost1.Location = new System.Drawing.Point(11, 21);
            this.labelHost1.Name = "labelHost1";
            this.labelHost1.Size = new System.Drawing.Size(32, 13);
            this.labelHost1.TabIndex = 0;
            this.labelHost1.Text = "Host:";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.comboBoxLanguage);
            this.groupBoxClient.Controls.Add(this.labelLanguage);
            this.groupBoxClient.Controls.Add(this.labelRed);
            this.groupBoxClient.Controls.Add(this.labelGreen);
            this.groupBoxClient.Controls.Add(this.splitContainer3);
            this.groupBoxClient.Controls.Add(this.checkBoxAutoScroll);
            this.groupBoxClient.Controls.Add(this.labelLineending);
            this.groupBoxClient.Controls.Add(this.comboBoxLineending);
            this.groupBoxClient.Controls.Add(this.labelCharset);
            this.groupBoxClient.Controls.Add(this.comboBoxEncoding);
            this.groupBoxClient.Controls.Add(this.buttonConnect);
            this.groupBoxClient.Controls.Add(this.labelPort);
            this.groupBoxClient.Controls.Add(this.numericUpDownPortConnect);
            this.groupBoxClient.Controls.Add(this.hostTextBoxHostConnect);
            this.groupBoxClient.Controls.Add(this.labelHost2);
            this.groupBoxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxClient.Location = new System.Drawing.Point(0, 0);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(796, 348);
            this.groupBoxClient.TabIndex = 1;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Choose automatically",
            "English",
            "Deutsch",
            "中文"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(633, 316);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(152, 21);
            this.comboBoxLanguage.TabIndex = 10;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(577, 319);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(58, 13);
            this.labelLanguage.TabIndex = 9;
            this.labelLanguage.Text = "Language:";
            // 
            // labelRed
            // 
            this.labelRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRed.AutoSize = true;
            this.labelRed.ForeColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(483, 329);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(85, 13);
            this.labelRed.TabIndex = 8;
            this.labelRed.Text = "Red = Received";
            // 
            // labelGreen
            // 
            this.labelGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGreen.AutoSize = true;
            this.labelGreen.ForeColor = System.Drawing.Color.Green;
            this.labelGreen.Location = new System.Drawing.Point(483, 312);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(70, 13);
            this.labelGreen.TabIndex = 7;
            this.labelGreen.Text = "Green = Sent";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Location = new System.Drawing.Point(9, 45);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.checkBoxAutoClear);
            this.splitContainer3.Panel1.Controls.Add(this.sendBoxSend);
            this.splitContainer3.Panel1.Controls.Add(this.buttonSend);
            this.splitContainer3.Panel1MinSize = 0;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainer3.Panel2MinSize = 0;
            this.splitContainer3.Size = new System.Drawing.Size(776, 265);
            this.splitContainer3.SplitterDistance = 44;
            this.splitContainer3.TabIndex = 3;
            // 
            // checkBoxAutoClear
            // 
            this.checkBoxAutoClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoClear.AutoSize = true;
            this.checkBoxAutoClear.Location = new System.Drawing.Point(700, 22);
            this.checkBoxAutoClear.Name = "checkBoxAutoClear";
            this.checkBoxAutoClear.Size = new System.Drawing.Size(72, 17);
            this.checkBoxAutoClear.TabIndex = 2;
            this.checkBoxAutoClear.Text = "AutoClear";
            this.checkBoxAutoClear.UseVisualStyleBackColor = true;
            // 
            // sendBoxSend
            // 
            this.sendBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBoxSend.Enabled = false;
            this.sendBoxSend.Location = new System.Drawing.Point(-1, -1);
            this.sendBoxSend.Multiline = true;
            this.sendBoxSend.Name = "sendBoxSend";
            this.sendBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sendBoxSend.Size = new System.Drawing.Size(695, 44);
            this.sendBoxSend.TabIndex = 0;
            this.sendBoxSend.Enter += new System.EventHandler(this.textBoxSend_Enter);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(700, -1);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send!";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLog.ContextMenuStrip = this.contextMenuStripClear;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(774, 215);
            this.richTextBoxLog.TabIndex = 2;
            this.richTextBoxLog.Text = "";
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Checked = true;
            this.checkBoxAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(403, 318);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(74, 17);
            this.checkBoxAutoScroll.TabIndex = 6;
            this.checkBoxAutoScroll.Text = "AutoScroll";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // labelLineending
            // 
            this.labelLineending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLineending.AutoSize = true;
            this.labelLineending.Location = new System.Drawing.Point(207, 319);
            this.labelLineending.Name = "labelLineending";
            this.labelLineending.Size = new System.Drawing.Size(62, 13);
            this.labelLineending.TabIndex = 5;
            this.labelLineending.Text = "Lineending:";
            // 
            // comboBoxLineending
            // 
            this.comboBoxLineending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxLineending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLineending.FormattingEnabled = true;
            this.comboBoxLineending.Items.AddRange(new object[] {
            "No Lineending",
            "Linefeed",
            "Carriage Return",
            "CR + LF",
            "中文"});
            this.comboBoxLineending.Location = new System.Drawing.Point(276, 316);
            this.comboBoxLineending.Name = "comboBoxLineending";
            this.comboBoxLineending.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLineending.TabIndex = 5;
            // 
            // labelCharset
            // 
            this.labelCharset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCharset.AutoSize = true;
            this.labelCharset.Location = new System.Drawing.Point(6, 319);
            this.labelCharset.Name = "labelCharset";
            this.labelCharset.Size = new System.Drawing.Size(46, 13);
            this.labelCharset.TabIndex = 4;
            this.labelCharset.Text = "Charset:";
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEncoding.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEncoding.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Location = new System.Drawing.Point(80, 316);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEncoding.TabIndex = 4;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(710, 17);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect!";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelPort
            // 
            this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(616, 22);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port:";
            // 
            // numericUpDownPortConnect
            // 
            this.numericUpDownPortConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPortConnect.Location = new System.Drawing.Point(651, 19);
            this.numericUpDownPortConnect.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPortConnect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPortConnect.Name = "numericUpDownPortConnect";
            this.numericUpDownPortConnect.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownPortConnect.TabIndex = 1;
            this.numericUpDownPortConnect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPortConnect.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // hostTextBoxHostConnect
            // 
            this.hostTextBoxHostConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostTextBoxHostConnect.Location = new System.Drawing.Point(44, 19);
            this.hostTextBoxHostConnect.Name = "hostTextBoxHostConnect";
            this.hostTextBoxHostConnect.Size = new System.Drawing.Size(566, 20);
            this.hostTextBoxHostConnect.TabIndex = 0;
            this.hostTextBoxHostConnect.IPValidChanged += new UniversalTCPClient.Controls.HostTextBox.IPValidationChangedEventHandler(this.hostTextBoxHostConnect_IPValidChanged);
            // 
            // labelHost2
            // 
            this.labelHost2.AutoSize = true;
            this.labelHost2.Location = new System.Drawing.Point(6, 22);
            this.labelHost2.Name = "labelHost2";
            this.labelHost2.Size = new System.Drawing.Size(32, 13);
            this.labelHost2.TabIndex = 0;
            this.labelHost2.Text = "Host:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 350);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Universal TCP client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.contextMenuStripClear.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxIPScanner.ResumeLayout(false);
            this.groupBoxIPScanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIPScanTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanIPAttempts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewIPScan)).EndInit();
            this.groupBoxPortScanner.ResumeLayout(false);
            this.groupBoxPortScanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortScanTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewPortScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPort)).EndInit();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortConnect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BetterSplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private Controls.BetterSplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxIPScanner;
        private IPAddressControlLib.IPAddressControl ipAddressControlMinIP;
        private Controls.InfoProgressBar infoProgressBarIPScanner;
        private System.Windows.Forms.Label labelProgress1;
        private System.Windows.Forms.Label labelResults1;
        private BrightIdeasSoftware.FastObjectListView listViewIPScan;
        private System.Windows.Forms.Button buttonClearIP;
        private System.Windows.Forms.Button buttonIPScan;
        private IPAddressControlLib.IPAddressControl ipAddressControlMaxIP;
        private System.Windows.Forms.Label labelMinIP;
        private System.Windows.Forms.Label labelMaxIP;
        private System.Windows.Forms.GroupBox groupBoxPortScanner;
        private Controls.InfoProgressBar infoProgressBarPortScanner;
        private System.Windows.Forms.Label labelProgress2;
        private System.Windows.Forms.NumericUpDown numericUpDownPortScanTimeout;
        private System.Windows.Forms.Label labelTimeout2;
        private System.Windows.Forms.Label labelResults2;
        private BrightIdeasSoftware.FastObjectListView listViewPortScan;
        private System.Windows.Forms.Button buttonClearPort;
        private System.Windows.Forms.Button buttonPortScan;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPort;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPort;
        private System.Windows.Forms.Label labelMaxPort;
        private System.Windows.Forms.Label labelMinPort;
        private System.Windows.Forms.Label labelHost1;
        private BrightIdeasSoftware.OLVColumn IPScanColumnIP;
        private BrightIdeasSoftware.OLVColumn PortScanColumnIP;
        private BrightIdeasSoftware.OLVColumn PortScanColumnPort;
        private System.Windows.Forms.Label labelms2;
        private System.Windows.Forms.Label labelms1;
        private System.Windows.Forms.NumericUpDown numericUpDownIPScanTimeout;
        private System.Windows.Forms.NumericUpDown numericUpDownScanIPAttempts;
        private System.Windows.Forms.Label labelTimeout1;
        private System.Windows.Forms.Label labelAttempts;
        private BrightIdeasSoftware.OLVColumn IPScanColumnHostName;
        private Controls.HostTextBox hostTextBoxPortScanHost;
        private BrightIdeasSoftware.OLVColumn PortScanColumnHostName;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown numericUpDownPortConnect;
        private Controls.HostTextBox hostTextBoxHostConnect;
        private System.Windows.Forms.Label labelHost2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSend;
        private Controls.SendBox sendBoxSend;
        private System.Windows.Forms.Label labelLineending;
        private System.Windows.Forms.ComboBox comboBoxLineending;
        private System.Windows.Forms.Label labelCharset;
        private System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private Controls.BetterSplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.CheckBox checkBoxAutoClear;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClear;
    }
}