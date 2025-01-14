﻿
namespace AuthentiKitTuningApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.headerControl2 = new AuthentiKitTuningApp.Controls.HeaderControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spitfireMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honeycombBravoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p40BMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllMappingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lblSaveFileName = new System.Windows.Forms.Label();
            this.axisToButtonControl1 = new AuthentiKitTuningApp.Controls.AxisToButtonControl();
            this.btnAddMapping = new System.Windows.Forms.Button();
            this.lsbMappings = new System.Windows.Forms.ListBox();
            this.pnlAddMapping = new System.Windows.Forms.Panel();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnRemoveMapping = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.mappingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbMappingType = new System.Windows.Forms.ComboBox();
            this.lblMappingType = new System.Windows.Forms.Label();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemStartAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToAxisControl = new AuthentiKitTuningApp.Controls.ButtonToAxisControl();
            this.buttonToButtonControl = new AuthentiKitTuningApp.Controls.ButtonToButtonControl();
            this.encoderToAxisControl = new AuthentiKitTuningApp.Controls.EncoderToAxisControl();
            this.axisToAxisControl = new AuthentiKitTuningApp.Controls.AxisToAxisControl();
            this.pnlHeader.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlAddMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mappingBindingSource)).BeginInit();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblVersion);
            this.pnlHeader.Controls.Add(this.headerControl2);
            this.pnlHeader.Controls.Add(this.menuStrip);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(649, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblVersion.Location = new System.Drawing.Point(601, 82);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // headerControl2
            // 
            this.headerControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(9)))));
            this.headerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl2.Location = new System.Drawing.Point(0, 24);
            this.headerControl2.Name = "headerControl2";
            this.headerControl2.Size = new System.Drawing.Size(649, 76);
            this.headerControl2.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.presetsMenuItem,
            this.settingsMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(649, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.loadMenuItem,
            this.toolStripSeparator6,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            this.fileMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.configMenuItemClicked);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveMenuItem.Image")));
            this.saveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveMenuItem.Text = "&Save";
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsMenuItem.Image")));
            this.saveAsMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F12)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveAsMenuItem.Text = "&Save As";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadMenuItem.Image")));
            this.loadMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadMenuItem.Text = "&Load";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(168, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // presetsMenuItem
            // 
            this.presetsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spitfireMenuItem,
            this.honeycombBravoMenuItem,
            this.p40BMenuItem,
            this.toolStripSeparator4,
            this.clearMenuItem});
            this.presetsMenuItem.Name = "presetsMenuItem";
            this.presetsMenuItem.Size = new System.Drawing.Size(56, 20);
            this.presetsMenuItem.Text = "&Presets";
            this.presetsMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.presetsMenuItemClicked);
            // 
            // spitfireMenuItem
            // 
            this.spitfireMenuItem.Name = "spitfireMenuItem";
            this.spitfireMenuItem.Size = new System.Drawing.Size(236, 22);
            this.spitfireMenuItem.Text = "&Spitfire Mk.I / Mk.IX (for MSFS)";
            // 
            // honeycombBravoMenuItem
            // 
            this.honeycombBravoMenuItem.Name = "honeycombBravoMenuItem";
            this.honeycombBravoMenuItem.Size = new System.Drawing.Size(236, 22);
            this.honeycombBravoMenuItem.Text = "&Honeycomb Bravo (for MSFS)";
            // 
            // p40BMenuItem
            // 
            this.p40BMenuItem.Name = "p40BMenuItem";
            this.p40BMenuItem.Size = new System.Drawing.Size(236, 22);
            this.p40BMenuItem.Text = "&P-40B (for MSFS)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(236, 22);
            this.clearMenuItem.Text = "&Clear All";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startupMenuItem,
            this.calibrationMenuItem,
            this.startAllMappingsMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsMenuItem.Text = "&Settings";
            this.settingsMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.settingsMenuItemClicked);
            // 
            // startupMenuItem
            // 
            this.startupMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startupMenuItem.Image")));
            this.startupMenuItem.Name = "startupMenuItem";
            this.startupMenuItem.Size = new System.Drawing.Size(246, 22);
            this.startupMenuItem.Text = "&Run on Windows Start?";
            // 
            // calibrationMenuItem
            // 
            this.calibrationMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calibrationMenuItem.Image")));
            this.calibrationMenuItem.Name = "calibrationMenuItem";
            this.calibrationMenuItem.Size = new System.Drawing.Size(246, 22);
            this.calibrationMenuItem.Text = "&Save and Load Axis Calibrations?";
            // 
            // startAllMappingsMenuItem
            // 
            this.startAllMappingsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startAllMappingsMenuItem.Image")));
            this.startAllMappingsMenuItem.Name = "startAllMappingsMenuItem";
            this.startAllMappingsMenuItem.Size = new System.Drawing.Size(246, 22);
            this.startAllMappingsMenuItem.Text = "Start All Mappings on App Start?";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideMenuItem,
            this.bugReportMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "&Help";
            this.helpMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.helpMenuItemClicked);
            // 
            // userGuideMenuItem
            // 
            this.userGuideMenuItem.Name = "userGuideMenuItem";
            this.userGuideMenuItem.Size = new System.Drawing.Size(142, 22);
            this.userGuideMenuItem.Text = "&User Guide";
            // 
            // bugReportMenuItem
            // 
            this.bugReportMenuItem.Name = "bugReportMenuItem";
            this.bugReportMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bugReportMenuItem.Text = "&Report a Bug";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(139, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.AutoSize = true;
            this.pnlNavigation.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNavigation.Controls.Add(this.lblSaveFileName);
            this.pnlNavigation.Controls.Add(this.axisToButtonControl1);
            this.pnlNavigation.Controls.Add(this.btnAddMapping);
            this.pnlNavigation.Controls.Add(this.lsbMappings);
            this.pnlNavigation.Controls.Add(this.pnlAddMapping);
            this.pnlNavigation.Controls.Add(this.lblName);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 100);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(652, 435);
            this.pnlNavigation.TabIndex = 1;
            // 
            // lblSaveFileName
            // 
            this.lblSaveFileName.AutoSize = true;
            this.lblSaveFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaveFileName.Location = new System.Drawing.Point(3, 3);
            this.lblSaveFileName.Name = "lblSaveFileName";
            this.lblSaveFileName.Padding = new System.Windows.Forms.Padding(5);
            this.lblSaveFileName.Size = new System.Drawing.Size(60, 25);
            this.lblSaveFileName.TabIndex = 21;
            this.lblSaveFileName.Text = "SaveFile";
            // 
            // axisToButtonControl1
            // 
            this.axisToButtonControl1.Location = new System.Drawing.Point(242, 121);
            this.axisToButtonControl1.Name = "axisToButtonControl1";
            this.axisToButtonControl1.Size = new System.Drawing.Size(407, 256);
            this.axisToButtonControl1.TabIndex = 2;
            // 
            // btnAddMapping
            // 
            this.btnAddMapping.Location = new System.Drawing.Point(7, 344);
            this.btnAddMapping.Name = "btnAddMapping";
            this.btnAddMapping.Size = new System.Drawing.Size(229, 26);
            this.btnAddMapping.TabIndex = 0;
            this.btnAddMapping.Text = "Add Mapping";
            this.btnAddMapping.UseVisualStyleBackColor = true;
            this.btnAddMapping.Click += new System.EventHandler(this.btnAddMapping_Click);
            // 
            // lsbMappings
            // 
            this.lsbMappings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lsbMappings.FormattingEnabled = true;
            this.lsbMappings.ItemHeight = 15;
            this.lsbMappings.Location = new System.Drawing.Point(7, 31);
            this.lsbMappings.Name = "lsbMappings";
            this.lsbMappings.Size = new System.Drawing.Size(229, 304);
            this.lsbMappings.TabIndex = 1;
            // 
            // pnlAddMapping
            // 
            this.pnlAddMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlAddMapping.AutoSize = true;
            this.pnlAddMapping.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAddMapping.Controls.Add(this.btnActivate);
            this.pnlAddMapping.Controls.Add(this.btnDeactivate);
            this.pnlAddMapping.Controls.Add(this.btnStopAll);
            this.pnlAddMapping.Controls.Add(this.btnRemoveMapping);
            this.pnlAddMapping.Controls.Add(this.btnStartAll);
            this.pnlAddMapping.Location = new System.Drawing.Point(0, 376);
            this.pnlAddMapping.Name = "pnlAddMapping";
            this.pnlAddMapping.Size = new System.Drawing.Size(637, 56);
            this.pnlAddMapping.TabIndex = 0;
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActivate.AutoSize = true;
            this.btnActivate.Location = new System.Drawing.Point(252, 25);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(91, 28);
            this.btnActivate.TabIndex = 17;
            this.btnActivate.Text = "Start";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeactivate.AutoSize = true;
            this.btnDeactivate.Enabled = false;
            this.btnDeactivate.Location = new System.Drawing.Point(349, 25);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(91, 28);
            this.btnDeactivate.TabIndex = 18;
            this.btnDeactivate.Text = "Stop";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopAll.Location = new System.Drawing.Point(126, 25);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(110, 28);
            this.btnStopAll.TabIndex = 1;
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnRemoveMapping
            // 
            this.btnRemoveMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveMapping.Location = new System.Drawing.Point(554, 25);
            this.btnRemoveMapping.Name = "btnRemoveMapping";
            this.btnRemoveMapping.Size = new System.Drawing.Size(80, 28);
            this.btnRemoveMapping.TabIndex = 1;
            this.btnRemoveMapping.Text = "Delete";
            this.btnRemoveMapping.UseVisualStyleBackColor = true;
            this.btnRemoveMapping.Click += new System.EventHandler(this.btnRemoveMapping_Click);
            // 
            // btnStartAll
            // 
            this.btnStartAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartAll.Location = new System.Drawing.Point(7, 25);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(113, 28);
            this.btnStartAll.TabIndex = 0;
            this.btnStartAll.Text = "Start All";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(261, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(261, 137);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(376, 23);
            this.tbName.TabIndex = 23;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // cbMappingType
            // 
            this.cbMappingType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMappingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMappingType.FormattingEnabled = true;
            this.cbMappingType.Location = new System.Drawing.Point(261, 191);
            this.cbMappingType.Name = "cbMappingType";
            this.cbMappingType.Size = new System.Drawing.Size(376, 23);
            this.cbMappingType.TabIndex = 22;
            this.cbMappingType.SelectedValueChanged += new System.EventHandler(this.cbMappingType_SelectedValueChanged);
            // 
            // lblMappingType
            // 
            this.lblMappingType.AutoSize = true;
            this.lblMappingType.Location = new System.Drawing.Point(261, 173);
            this.lblMappingType.Name = "lblMappingType";
            this.lblMappingType.Size = new System.Drawing.Size(82, 15);
            this.lblMappingType.TabIndex = 21;
            this.lblMappingType.Text = "Mapping Type";
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "AuthentiKit Tuning App";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.DoubleClick += new System.EventHandler(this.notifyIconTray_DoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStartAll,
            this.toolStripMenuItemStopAll,
            this.toolStripSeparator7,
            this.toolStripMenuItemExit});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(116, 76);
            // 
            // toolStripMenuItemStartAll
            // 
            this.toolStripMenuItemStartAll.Name = "toolStripMenuItemStartAll";
            this.toolStripMenuItemStartAll.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemStartAll.Text = "Start All";
            this.toolStripMenuItemStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // toolStripMenuItemStopAll
            // 
            this.toolStripMenuItemStopAll.Name = "toolStripMenuItemStopAll";
            this.toolStripMenuItemStopAll.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemStopAll.Text = "Stop All";
            this.toolStripMenuItemStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(112, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // buttonToAxisControl
            // 
            this.buttonToAxisControl.Location = new System.Drawing.Point(242, 218);
            this.buttonToAxisControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonToAxisControl.Name = "buttonToAxisControl";
            this.buttonToAxisControl.Size = new System.Drawing.Size(407, 256);
            this.buttonToAxisControl.TabIndex = 24;
            // 
            // buttonToButtonControl
            // 
            this.buttonToButtonControl.Location = new System.Drawing.Point(242, 218);
            this.buttonToButtonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonToButtonControl.Name = "buttonToButtonControl";
            this.buttonToButtonControl.Size = new System.Drawing.Size(407, 256);
            this.buttonToButtonControl.TabIndex = 25;
            // 
            // encoderToAxisControl
            // 
            this.encoderToAxisControl.Location = new System.Drawing.Point(242, 218);
            this.encoderToAxisControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encoderToAxisControl.Name = "encoderToAxisControl";
            this.encoderToAxisControl.Size = new System.Drawing.Size(407, 256);
            this.encoderToAxisControl.TabIndex = 26;
            // 
            // axisToAxisControl
            // 
            this.axisToAxisControl.AutoSize = true;
            this.axisToAxisControl.Location = new System.Drawing.Point(242, 218);
            this.axisToAxisControl.Name = "axisToAxisControl";
            this.axisToAxisControl.Size = new System.Drawing.Size(410, 259);
            this.axisToAxisControl.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(649, 535);
            this.Controls.Add(this.axisToAxisControl);
            this.Controls.Add(this.encoderToAxisControl);
            this.Controls.Add(this.buttonToButtonControl);
            this.Controls.Add(this.buttonToAxisControl);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbMappingType);
            this.Controls.Add(this.lblMappingType);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(665, 574);
            this.MinimumSize = new System.Drawing.Size(665, 574);
            this.Name = "MainForm";
            this.Text = "AuthentiKit Tuning App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.pnlAddMapping.ResumeLayout(false);
            this.pnlAddMapping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mappingBindingSource)).EndInit();
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.ListBox lsbMappings;
        private System.Windows.Forms.Panel pnlAddMapping;
        private System.Windows.Forms.Button btnAddMapping;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.BindingSource mappingBindingSource;
        private Controls.HeaderControl headerControl2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spitfireMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveMapping;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbMappingType;
        private System.Windows.Forms.Label lblMappingType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupMenuItem;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem honeycombBravoMenuItem;
        private Controls.ButtonToAxisControl buttonToAxisControl;
        private Controls.ButtonToButtonControl buttonToButtonControl;
        private Controls.EncoderToAxisControl encoderToAxisControl;
        private Controls.AxisToAxisControl axisToAxisControl;
        private Controls.AxisToButtonControl axisToButtonControl1;
        private System.Windows.Forms.ToolStripMenuItem calibrationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAllMappingsMenuItem;
        private System.Windows.Forms.Label lblSaveFileName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolStripMenuItem p40BMenuItem;
    }
}

