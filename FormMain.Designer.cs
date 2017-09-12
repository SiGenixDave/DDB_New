namespace DDB
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWatchVariables = new System.Windows.Forms.TabPage();
            this.grpBoxWatchVarList = new System.Windows.Forms.GroupBox();
            this.btnWatchFilterClear = new System.Windows.Forms.Button();
            this.cBoxWatchList = new System.Windows.Forms.ComboBox();
            this.btnWatchSortDes = new System.Windows.Forms.Button();
            this.btnWatchFilterApply = new System.Windows.Forms.Button();
            this.lBoxWatchVariables = new System.Windows.Forms.ListBox();
            this.conMenuWatchVarList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBoxWatchFilter = new System.Windows.Forms.TextBox();
            this.btnWatchSortAsc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnWatchModifyHelpText = new System.Windows.Forms.Button();
            this.grpBoxWatchAttrs = new System.Windows.Forms.GroupBox();
            this.cBoxWatchUnitConversion = new System.Windows.Forms.ComboBox();
            this.btnWatchAccept = new System.Windows.Forms.Button();
            this.cBoxWatchScaleInfo = new System.Windows.Forms.ComboBox();
            this.lblWatchUnitConversion = new System.Windows.Forms.Label();
            this.btnWatchCancel = new System.Windows.Forms.Button();
            this.lblWatchScaleInfo = new System.Windows.Forms.Label();
            this.cBoxWatchFormatString = new System.Windows.Forms.ComboBox();
            this.lblFormatString = new System.Windows.Forms.Label();
            this.chkWatchEngViewOnly = new System.Windows.Forms.CheckBox();
            this.cBoxWatchScaleType = new System.Windows.Forms.ComboBox();
            this.lblWatchUnitsEnumBitmask = new System.Windows.Forms.Label();
            this.cBoxWatchUnits = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxWatchReadWriteFlags = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxWatchDataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gBoxWatchVarMod = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxWatchMaxValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxWatchMinValue = new System.Windows.Forms.TextBox();
            this.gBoxWatchChartScaling = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxWatchMaxChart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxWatchMinChart = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxWatchEmbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxWatchDisplayName = new System.Windows.Forms.TextBox();
            this.gBoxWatchActions = new System.Windows.Forms.GroupBox();
            this.btnWatchCopy = new System.Windows.Forms.Button();
            this.btnWatchImport = new System.Windows.Forms.Button();
            this.btnWatchCreate = new System.Windows.Forms.Button();
            this.btnWatchModify = new System.Windows.Forms.Button();
            this.btnWatchDelete = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.ucEE_EventVariables = new DDB.UserControlEntityEditor();
            this.ucEE_EventStructures = new DDB.UserControlEntityEditor();
            this.ucEE_Events = new DDB.UserControlEntityEditor();
            this.tabSelfTest = new System.Windows.Forms.TabPage();
            this.tabProjectDefinitions = new System.Windows.Forms.TabPage();
            this.ucEE_Enumerations = new DDB.UserControlEntityEditor();
            this.ucEE_Bitmasks = new DDB.UserControlEntityEditor();
            this.ucEE_Units = new DDB.UserControlEntityEditor();
            this.tabProjectSettings = new System.Windows.Forms.TabPage();
            this.btnProjSettingsCancelChanges = new System.Windows.Forms.Button();
            this.btnProjSettingsAcceptChanges = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBoxPasswordLevel3 = new System.Windows.Forms.TextBox();
            this.tBoxPasswordLevel2 = new System.Windows.Forms.TextBox();
            this.tBoxPasswordLevel1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gBoxEventLogs = new System.Windows.Forms.GroupBox();
            this.dGridEventLog = new System.Windows.Forms.DataGridView();
            this.eventLogEmbIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMenuEventLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewEventLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProjSettingsAddEventLog = new System.Windows.Forms.Button();
            this.gBoxTargetCommunication = new System.Windows.Forms.GroupBox();
            this.gBoxURLs = new System.Windows.Forms.GroupBox();
            this.dGridURL = new System.Windows.Forms.DataGridView();
            this.urlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMenuURL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewURLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteURLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProjSettingsAddURL = new System.Windows.Forms.Button();
            this.cBoxCommType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tBoxProjSettingsAppDataPath = new System.Windows.Forms.TextBox();
            this.tBoxProjSettingsSoftwareVersion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tBoxProjSettingsWatchVarMax = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cBoxNumStreamVars = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cListBoxFunctionFlags = new System.Windows.Forms.CheckedListBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genEmbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.previewBitmasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEnumerationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEventVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEventStructuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExitDDB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabWatchVariables.SuspendLayout();
            this.grpBoxWatchVarList.SuspendLayout();
            this.conMenuWatchVarList.SuspendLayout();
            this.grpBoxWatchAttrs.SuspendLayout();
            this.gBoxWatchVarMod.SuspendLayout();
            this.gBoxWatchChartScaling.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxWatchActions.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabProjectDefinitions.SuspendLayout();
            this.tabProjectSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gBoxEventLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridEventLog)).BeginInit();
            this.conMenuEventLogs.SuspendLayout();
            this.gBoxTargetCommunication.SuspendLayout();
            this.gBoxURLs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridURL)).BeginInit();
            this.conMenuURL.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWatchVariables);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Controls.Add(this.tabSelfTest);
            this.tabControl1.Controls.Add(this.tabProjectDefinitions);
            this.tabControl1.Controls.Add(this.tabProjectSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 555);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabWatchVariables
            // 
            this.tabWatchVariables.Controls.Add(this.grpBoxWatchVarList);
            this.tabWatchVariables.Controls.Add(this.btnWatchModifyHelpText);
            this.tabWatchVariables.Controls.Add(this.grpBoxWatchAttrs);
            this.tabWatchVariables.Controls.Add(this.gBoxWatchActions);
            this.tabWatchVariables.Location = new System.Drawing.Point(4, 22);
            this.tabWatchVariables.Name = "tabWatchVariables";
            this.tabWatchVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabWatchVariables.Size = new System.Drawing.Size(842, 529);
            this.tabWatchVariables.TabIndex = 0;
            this.tabWatchVariables.Text = "Watch Variables";
            this.tabWatchVariables.UseVisualStyleBackColor = true;
            // 
            // grpBoxWatchVarList
            // 
            this.grpBoxWatchVarList.Controls.Add(this.btnWatchFilterClear);
            this.grpBoxWatchVarList.Controls.Add(this.cBoxWatchList);
            this.grpBoxWatchVarList.Controls.Add(this.btnWatchSortDes);
            this.grpBoxWatchVarList.Controls.Add(this.btnWatchFilterApply);
            this.grpBoxWatchVarList.Controls.Add(this.lBoxWatchVariables);
            this.grpBoxWatchVarList.Controls.Add(this.tBoxWatchFilter);
            this.grpBoxWatchVarList.Controls.Add(this.btnWatchSortAsc);
            this.grpBoxWatchVarList.Controls.Add(this.label11);
            this.grpBoxWatchVarList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWatchVarList.Location = new System.Drawing.Point(6, 27);
            this.grpBoxWatchVarList.Name = "grpBoxWatchVarList";
            this.grpBoxWatchVarList.Size = new System.Drawing.Size(286, 478);
            this.grpBoxWatchVarList.TabIndex = 2;
            this.grpBoxWatchVarList.TabStop = false;
            this.grpBoxWatchVarList.Text = "Watch Variable List";
            // 
            // btnWatchFilterClear
            // 
            this.btnWatchFilterClear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchFilterClear.Location = new System.Drawing.Point(123, 444);
            this.btnWatchFilterClear.Name = "btnWatchFilterClear";
            this.btnWatchFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btnWatchFilterClear.TabIndex = 15;
            this.btnWatchFilterClear.Text = "Clear Filter";
            this.toolTip1.SetToolTip(this.btnWatchFilterClear, "\"Not yet Implemeneted\"");
            this.btnWatchFilterClear.UseVisualStyleBackColor = true;
            // 
            // cBoxWatchList
            // 
            this.cBoxWatchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchList.FormattingEnabled = true;
            this.cBoxWatchList.Items.AddRange(new object[] {
            "Display Name",
            "Embedded Name"});
            this.cBoxWatchList.Location = new System.Drawing.Point(6, 34);
            this.cBoxWatchList.Name = "cBoxWatchList";
            this.cBoxWatchList.Size = new System.Drawing.Size(132, 21);
            this.cBoxWatchList.TabIndex = 14;
            this.cBoxWatchList.SelectedIndexChanged += new System.EventHandler(this.cBoxWatchList_SelectedIndexChanged);
            // 
            // btnWatchSortDes
            // 
            this.btnWatchSortDes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchSortDes.Location = new System.Drawing.Point(207, 444);
            this.btnWatchSortDes.Name = "btnWatchSortDes";
            this.btnWatchSortDes.Size = new System.Drawing.Size(72, 23);
            this.btnWatchSortDes.TabIndex = 12;
            this.btnWatchSortDes.Text = "Sort Des";
            this.toolTip1.SetToolTip(this.btnWatchSortDes, "\"Not yet Implemeneted\"");
            this.btnWatchSortDes.UseVisualStyleBackColor = true;
            this.btnWatchSortDes.Click += new System.EventHandler(this.btnWatchSortZtoA_Click);
            // 
            // btnWatchFilterApply
            // 
            this.btnWatchFilterApply.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchFilterApply.Location = new System.Drawing.Point(6, 444);
            this.btnWatchFilterApply.Name = "btnWatchFilterApply";
            this.btnWatchFilterApply.Size = new System.Drawing.Size(75, 23);
            this.btnWatchFilterApply.TabIndex = 9;
            this.btnWatchFilterApply.Text = "Apply Filter";
            this.toolTip1.SetToolTip(this.btnWatchFilterApply, "\"Not yet Implemeneted\"");
            this.btnWatchFilterApply.UseVisualStyleBackColor = true;
            this.btnWatchFilterApply.Click += new System.EventHandler(this.btnWatchFilterApply_Click);
            // 
            // lBoxWatchVariables
            // 
            this.lBoxWatchVariables.ContextMenuStrip = this.conMenuWatchVarList;
            this.lBoxWatchVariables.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxWatchVariables.FormattingEnabled = true;
            this.lBoxWatchVariables.HorizontalScrollbar = true;
            this.lBoxWatchVariables.Location = new System.Drawing.Point(6, 65);
            this.lBoxWatchVariables.Name = "lBoxWatchVariables";
            this.lBoxWatchVariables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBoxWatchVariables.Size = new System.Drawing.Size(273, 290);
            this.lBoxWatchVariables.TabIndex = 0;
            this.lBoxWatchVariables.SelectedIndexChanged += new System.EventHandler(this.lBoxWatchVariables_SelectedIndexChanged);
            this.lBoxWatchVariables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxWatchVariables_MouseDoubleClick);
            // 
            // conMenuWatchVarList
            // 
            this.conMenuWatchVarList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyWatchMenuItem,
            this.modifyWatchMenuItem,
            this.deleteWatchMenuItem});
            this.conMenuWatchVarList.Name = "contextMenuStrip1";
            this.conMenuWatchVarList.Size = new System.Drawing.Size(113, 70);
            // 
            // copyWatchMenuItem
            // 
            this.copyWatchMenuItem.Name = "copyWatchMenuItem";
            this.copyWatchMenuItem.Size = new System.Drawing.Size(112, 22);
            this.copyWatchMenuItem.Text = "Copy";
            this.copyWatchMenuItem.Click += new System.EventHandler(this.copyWatchMenuItem_Click);
            // 
            // modifyWatchMenuItem
            // 
            this.modifyWatchMenuItem.Name = "modifyWatchMenuItem";
            this.modifyWatchMenuItem.Size = new System.Drawing.Size(112, 22);
            this.modifyWatchMenuItem.Text = "Modify";
            this.modifyWatchMenuItem.Click += new System.EventHandler(this.modifyWatchMenuItem_Click);
            // 
            // deleteWatchMenuItem
            // 
            this.deleteWatchMenuItem.Name = "deleteWatchMenuItem";
            this.deleteWatchMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteWatchMenuItem.Text = "Delete";
            this.deleteWatchMenuItem.Click += new System.EventHandler(this.deleteWatchMenuItem_Click);
            // 
            // tBoxWatchFilter
            // 
            this.tBoxWatchFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchFilter.Location = new System.Drawing.Point(6, 414);
            this.tBoxWatchFilter.Name = "tBoxWatchFilter";
            this.tBoxWatchFilter.Size = new System.Drawing.Size(192, 21);
            this.tBoxWatchFilter.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tBoxWatchFilter, "\"Not yet Implemeneted\"");
            // 
            // btnWatchSortAsc
            // 
            this.btnWatchSortAsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchSortAsc.Location = new System.Drawing.Point(207, 414);
            this.btnWatchSortAsc.Name = "btnWatchSortAsc";
            this.btnWatchSortAsc.Size = new System.Drawing.Size(72, 23);
            this.btnWatchSortAsc.TabIndex = 11;
            this.btnWatchSortAsc.Text = "Sort Asc";
            this.toolTip1.SetToolTip(this.btnWatchSortAsc, "\"Not yet Implemeneted\"");
            this.btnWatchSortAsc.UseVisualStyleBackColor = true;
            this.btnWatchSortAsc.Click += new System.EventHandler(this.btnWatchSortAtoZ_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Filter";
            // 
            // btnWatchModifyHelpText
            // 
            this.btnWatchModifyHelpText.Enabled = false;
            this.btnWatchModifyHelpText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchModifyHelpText.Location = new System.Drawing.Point(697, 456);
            this.btnWatchModifyHelpText.Name = "btnWatchModifyHelpText";
            this.btnWatchModifyHelpText.Size = new System.Drawing.Size(127, 34);
            this.btnWatchModifyHelpText.TabIndex = 18;
            this.btnWatchModifyHelpText.Text = "Modify Help Text...";
            this.btnWatchModifyHelpText.UseVisualStyleBackColor = true;
            this.btnWatchModifyHelpText.Click += new System.EventHandler(this.btnWatchModifyHelpText_Click);
            // 
            // grpBoxWatchAttrs
            // 
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchUnitConversion);
            this.grpBoxWatchAttrs.Controls.Add(this.btnWatchAccept);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchScaleInfo);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchUnitConversion);
            this.grpBoxWatchAttrs.Controls.Add(this.btnWatchCancel);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchScaleInfo);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchFormatString);
            this.grpBoxWatchAttrs.Controls.Add(this.lblFormatString);
            this.grpBoxWatchAttrs.Controls.Add(this.chkWatchEngViewOnly);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchScaleType);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchUnitsEnumBitmask);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchUnits);
            this.grpBoxWatchAttrs.Controls.Add(this.label10);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchReadWriteFlags);
            this.grpBoxWatchAttrs.Controls.Add(this.label9);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchDataType);
            this.grpBoxWatchAttrs.Controls.Add(this.label8);
            this.grpBoxWatchAttrs.Controls.Add(this.gBoxWatchVarMod);
            this.grpBoxWatchAttrs.Controls.Add(this.gBoxWatchChartScaling);
            this.grpBoxWatchAttrs.Controls.Add(this.groupBox1);
            this.grpBoxWatchAttrs.Enabled = false;
            this.grpBoxWatchAttrs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWatchAttrs.Location = new System.Drawing.Point(298, 27);
            this.grpBoxWatchAttrs.Name = "grpBoxWatchAttrs";
            this.grpBoxWatchAttrs.Size = new System.Drawing.Size(528, 411);
            this.grpBoxWatchAttrs.TabIndex = 6;
            this.grpBoxWatchAttrs.TabStop = false;
            this.grpBoxWatchAttrs.Text = "Attributes";
            // 
            // cBoxWatchUnitConversion
            // 
            this.cBoxWatchUnitConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchUnitConversion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchUnitConversion.FormattingEnabled = true;
            this.cBoxWatchUnitConversion.Items.AddRange(new object[] {
            "METERSTOYARDS",
            "YARDSTOINCHES",
            "MPHTOKPH",
            "KPHTOMPH",
            "MILESTOKILOMETERS"});
            this.cBoxWatchUnitConversion.Location = new System.Drawing.Point(349, 270);
            this.cBoxWatchUnitConversion.Name = "cBoxWatchUnitConversion";
            this.cBoxWatchUnitConversion.Size = new System.Drawing.Size(143, 21);
            this.cBoxWatchUnitConversion.TabIndex = 23;
            // 
            // btnWatchAccept
            // 
            this.btnWatchAccept.Enabled = false;
            this.btnWatchAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchAccept.Location = new System.Drawing.Point(294, 366);
            this.btnWatchAccept.Name = "btnWatchAccept";
            this.btnWatchAccept.Size = new System.Drawing.Size(99, 34);
            this.btnWatchAccept.TabIndex = 7;
            this.btnWatchAccept.Text = "Accept";
            this.btnWatchAccept.UseVisualStyleBackColor = true;
            this.btnWatchAccept.Click += new System.EventHandler(this.btnWatchAccept_Click);
            // 
            // cBoxWatchScaleInfo
            // 
            this.cBoxWatchScaleInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchScaleInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchScaleInfo.FormattingEnabled = true;
            this.cBoxWatchScaleInfo.Items.AddRange(new object[] {
            "DIV1",
            "DIV10",
            "DIV100",
            "DIV1000",
            "MUL10",
            "MUL100",
            "MUL1000"});
            this.cBoxWatchScaleInfo.Location = new System.Drawing.Point(349, 231);
            this.cBoxWatchScaleInfo.Name = "cBoxWatchScaleInfo";
            this.cBoxWatchScaleInfo.Size = new System.Drawing.Size(143, 21);
            this.cBoxWatchScaleInfo.TabIndex = 22;
            // 
            // lblWatchUnitConversion
            // 
            this.lblWatchUnitConversion.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchUnitConversion.Location = new System.Drawing.Point(240, 270);
            this.lblWatchUnitConversion.Name = "lblWatchUnitConversion";
            this.lblWatchUnitConversion.Size = new System.Drawing.Size(103, 38);
            this.lblWatchUnitConversion.TabIndex = 21;
            this.lblWatchUnitConversion.Text = "Unit Conversion";
            this.lblWatchUnitConversion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnWatchCancel
            // 
            this.btnWatchCancel.Enabled = false;
            this.btnWatchCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchCancel.Location = new System.Drawing.Point(399, 366);
            this.btnWatchCancel.Name = "btnWatchCancel";
            this.btnWatchCancel.Size = new System.Drawing.Size(99, 34);
            this.btnWatchCancel.TabIndex = 8;
            this.btnWatchCancel.Text = "Cancel";
            this.btnWatchCancel.UseVisualStyleBackColor = true;
            this.btnWatchCancel.Click += new System.EventHandler(this.btnWatchCancel_Click);
            // 
            // lblWatchScaleInfo
            // 
            this.lblWatchScaleInfo.AutoSize = true;
            this.lblWatchScaleInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchScaleInfo.Location = new System.Drawing.Point(280, 235);
            this.lblWatchScaleInfo.Name = "lblWatchScaleInfo";
            this.lblWatchScaleInfo.Size = new System.Drawing.Size(63, 13);
            this.lblWatchScaleInfo.TabIndex = 20;
            this.lblWatchScaleInfo.Text = "Scale Info";
            this.lblWatchScaleInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchFormatString
            // 
            this.cBoxWatchFormatString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchFormatString.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchFormatString.FormattingEnabled = true;
            this.cBoxWatchFormatString.Items.AddRange(new object[] {
            "General Number",
            "Fixed",
            "Standard",
            "Scientific",
            "Hexadecimal",
            "Binary",
            "8Dot8"});
            this.cBoxWatchFormatString.Location = new System.Drawing.Point(349, 306);
            this.cBoxWatchFormatString.Name = "cBoxWatchFormatString";
            this.cBoxWatchFormatString.Size = new System.Drawing.Size(143, 21);
            this.cBoxWatchFormatString.TabIndex = 19;
            // 
            // lblFormatString
            // 
            this.lblFormatString.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatString.Location = new System.Drawing.Point(242, 306);
            this.lblFormatString.Name = "lblFormatString";
            this.lblFormatString.Size = new System.Drawing.Size(101, 34);
            this.lblFormatString.TabIndex = 17;
            this.lblFormatString.Text = "Format String";
            this.lblFormatString.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkWatchEngViewOnly
            // 
            this.chkWatchEngViewOnly.AutoSize = true;
            this.chkWatchEngViewOnly.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWatchEngViewOnly.Location = new System.Drawing.Point(12, 327);
            this.chkWatchEngViewOnly.Name = "chkWatchEngViewOnly";
            this.chkWatchEngViewOnly.Size = new System.Drawing.Size(147, 17);
            this.chkWatchEngViewOnly.TabIndex = 16;
            this.chkWatchEngViewOnly.Text = "Engineering Only Visibility";
            this.chkWatchEngViewOnly.UseVisualStyleBackColor = true;
            // 
            // cBoxWatchScaleType
            // 
            this.cBoxWatchScaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchScaleType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchScaleType.FormattingEnabled = true;
            this.cBoxWatchScaleType.Items.AddRange(new object[] {
            "NONE",
            "Scalar",
            "Enumeration",
            "Bitmask"});
            this.cBoxWatchScaleType.Location = new System.Drawing.Point(349, 160);
            this.cBoxWatchScaleType.Name = "cBoxWatchScaleType";
            this.cBoxWatchScaleType.Size = new System.Drawing.Size(143, 21);
            this.cBoxWatchScaleType.TabIndex = 15;
            this.cBoxWatchScaleType.SelectedIndexChanged += new System.EventHandler(this.cBoxWatchScaleType_SelectedIndexChanged);
            // 
            // lblWatchUnitsEnumBitmask
            // 
            this.lblWatchUnitsEnumBitmask.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchUnitsEnumBitmask.Location = new System.Drawing.Point(249, 202);
            this.lblWatchUnitsEnumBitmask.Name = "lblWatchUnitsEnumBitmask";
            this.lblWatchUnitsEnumBitmask.Size = new System.Drawing.Size(93, 17);
            this.lblWatchUnitsEnumBitmask.TabIndex = 14;
            this.lblWatchUnitsEnumBitmask.Text = "UnitsDB";
            this.lblWatchUnitsEnumBitmask.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchUnits
            // 
            this.cBoxWatchUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchUnits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchUnits.FormattingEnabled = true;
            this.cBoxWatchUnits.Location = new System.Drawing.Point(349, 197);
            this.cBoxWatchUnits.Name = "cBoxWatchUnits";
            this.cBoxWatchUnits.Size = new System.Drawing.Size(143, 21);
            this.cBoxWatchUnits.TabIndex = 13;
            this.cBoxWatchUnits.SelectedIndexChanged += new System.EventHandler(this.cBoxWatchUnits_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Scale Type";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchReadWriteFlags
            // 
            this.cBoxWatchReadWriteFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchReadWriteFlags.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxWatchReadWriteFlags.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchReadWriteFlags.FormattingEnabled = true;
            this.cBoxWatchReadWriteFlags.Items.AddRange(new object[] {
            "Read Only",
            "Read/Write [Level 1]",
            "Read/Write [Level 2]"});
            this.cBoxWatchReadWriteFlags.Location = new System.Drawing.Point(11, 379);
            this.cBoxWatchReadWriteFlags.Name = "cBoxWatchReadWriteFlags";
            this.cBoxWatchReadWriteFlags.Size = new System.Drawing.Size(143, 21);
            this.cBoxWatchReadWriteFlags.TabIndex = 13;
            this.cBoxWatchReadWriteFlags.SelectedIndexChanged += new System.EventHandler(this.cBoxWatchReadWriteFlags_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Read Write Flags";
            // 
            // cBoxWatchDataType
            // 
            this.cBoxWatchDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchDataType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchDataType.FormattingEnabled = true;
            this.cBoxWatchDataType.Items.AddRange(new object[] {
            "BOOL",
            "UINT_8",
            "UINT_16",
            "UINT_32",
            "INT_8",
            "INT_16",
            "INT_32",
            "FLOAT",
            "DOUBLE"});
            this.cBoxWatchDataType.Location = new System.Drawing.Point(349, 127);
            this.cBoxWatchDataType.Name = "cBoxWatchDataType";
            this.cBoxWatchDataType.Size = new System.Drawing.Size(143, 21);
            this.cBoxWatchDataType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gBoxWatchVarMod
            // 
            this.gBoxWatchVarMod.Controls.Add(this.label6);
            this.gBoxWatchVarMod.Controls.Add(this.tBoxWatchMaxValue);
            this.gBoxWatchVarMod.Controls.Add(this.label7);
            this.gBoxWatchVarMod.Controls.Add(this.tBoxWatchMinValue);
            this.gBoxWatchVarMod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxWatchVarMod.Location = new System.Drawing.Point(12, 227);
            this.gBoxWatchVarMod.Name = "gBoxWatchVarMod";
            this.gBoxWatchVarMod.Size = new System.Drawing.Size(222, 94);
            this.gBoxWatchVarMod.TabIndex = 5;
            this.gBoxWatchVarMod.TabStop = false;
            this.gBoxWatchVarMod.Text = "Variable Modification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maximum Value";
            // 
            // tBoxWatchMaxValue
            // 
            this.tBoxWatchMaxValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMaxValue.Location = new System.Drawing.Point(102, 60);
            this.tBoxWatchMaxValue.Name = "tBoxWatchMaxValue";
            this.tBoxWatchMaxValue.Size = new System.Drawing.Size(107, 21);
            this.tBoxWatchMaxValue.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Minimum Value";
            // 
            // tBoxWatchMinValue
            // 
            this.tBoxWatchMinValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMinValue.Location = new System.Drawing.Point(102, 31);
            this.tBoxWatchMinValue.Name = "tBoxWatchMinValue";
            this.tBoxWatchMinValue.Size = new System.Drawing.Size(107, 21);
            this.tBoxWatchMinValue.TabIndex = 0;
            // 
            // gBoxWatchChartScaling
            // 
            this.gBoxWatchChartScaling.Controls.Add(this.label4);
            this.gBoxWatchChartScaling.Controls.Add(this.tBoxWatchMaxChart);
            this.gBoxWatchChartScaling.Controls.Add(this.label5);
            this.gBoxWatchChartScaling.Controls.Add(this.tBoxWatchMinChart);
            this.gBoxWatchChartScaling.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxWatchChartScaling.Location = new System.Drawing.Point(12, 126);
            this.gBoxWatchChartScaling.Name = "gBoxWatchChartScaling";
            this.gBoxWatchChartScaling.Size = new System.Drawing.Size(222, 93);
            this.gBoxWatchChartScaling.TabIndex = 4;
            this.gBoxWatchChartScaling.TabStop = false;
            this.gBoxWatchChartScaling.Text = "Chart Scaling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum Value";
            // 
            // tBoxWatchMaxChart
            // 
            this.tBoxWatchMaxChart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMaxChart.Location = new System.Drawing.Point(102, 60);
            this.tBoxWatchMaxChart.Name = "tBoxWatchMaxChart";
            this.tBoxWatchMaxChart.Size = new System.Drawing.Size(107, 21);
            this.tBoxWatchMaxChart.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minimum Value";
            // 
            // tBoxWatchMinChart
            // 
            this.tBoxWatchMinChart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMinChart.Location = new System.Drawing.Point(102, 31);
            this.tBoxWatchMinChart.Name = "tBoxWatchMinChart";
            this.tBoxWatchMinChart.Size = new System.Drawing.Size(107, 21);
            this.tBoxWatchMinChart.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxWatchEmbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxWatchDisplayName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Embedded";
            // 
            // tBoxWatchEmbName
            // 
            this.tBoxWatchEmbName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchEmbName.Location = new System.Drawing.Point(76, 60);
            this.tBoxWatchEmbName.Name = "tBoxWatchEmbName";
            this.tBoxWatchEmbName.Size = new System.Drawing.Size(404, 21);
            this.tBoxWatchEmbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display";
            // 
            // tBoxWatchDisplayName
            // 
            this.tBoxWatchDisplayName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchDisplayName.Location = new System.Drawing.Point(76, 31);
            this.tBoxWatchDisplayName.Name = "tBoxWatchDisplayName";
            this.tBoxWatchDisplayName.Size = new System.Drawing.Size(404, 21);
            this.tBoxWatchDisplayName.TabIndex = 0;
            // 
            // gBoxWatchActions
            // 
            this.gBoxWatchActions.Controls.Add(this.btnWatchCopy);
            this.gBoxWatchActions.Controls.Add(this.btnWatchImport);
            this.gBoxWatchActions.Controls.Add(this.btnWatchCreate);
            this.gBoxWatchActions.Controls.Add(this.btnWatchModify);
            this.gBoxWatchActions.Controls.Add(this.btnWatchDelete);
            this.gBoxWatchActions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxWatchActions.Location = new System.Drawing.Point(298, 444);
            this.gBoxWatchActions.Name = "gBoxWatchActions";
            this.gBoxWatchActions.Size = new System.Drawing.Size(273, 79);
            this.gBoxWatchActions.TabIndex = 25;
            this.gBoxWatchActions.TabStop = false;
            this.gBoxWatchActions.Text = "Actions";
            // 
            // btnWatchCopy
            // 
            this.btnWatchCopy.Enabled = false;
            this.btnWatchCopy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchCopy.Location = new System.Drawing.Point(11, 49);
            this.btnWatchCopy.Name = "btnWatchCopy";
            this.btnWatchCopy.Size = new System.Drawing.Size(75, 23);
            this.btnWatchCopy.TabIndex = 4;
            this.btnWatchCopy.Text = "Copy";
            this.btnWatchCopy.UseVisualStyleBackColor = true;
            this.btnWatchCopy.Click += new System.EventHandler(this.btnWatchCopy_Click);
            // 
            // btnWatchImport
            // 
            this.btnWatchImport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchImport.Location = new System.Drawing.Point(192, 24);
            this.btnWatchImport.Name = "btnWatchImport";
            this.btnWatchImport.Size = new System.Drawing.Size(75, 23);
            this.btnWatchImport.TabIndex = 7;
            this.btnWatchImport.Text = "Import...";
            this.toolTip1.SetToolTip(this.btnWatchImport, "\"TODO Import watch variables from another XML file\"");
            this.btnWatchImport.UseVisualStyleBackColor = true;
            this.btnWatchImport.Click += new System.EventHandler(this.btnWatchImport_Click);
            // 
            // btnWatchCreate
            // 
            this.btnWatchCreate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchCreate.Location = new System.Drawing.Point(11, 20);
            this.btnWatchCreate.Name = "btnWatchCreate";
            this.btnWatchCreate.Size = new System.Drawing.Size(75, 23);
            this.btnWatchCreate.TabIndex = 2;
            this.btnWatchCreate.Text = "Create";
            this.btnWatchCreate.UseVisualStyleBackColor = true;
            this.btnWatchCreate.Click += new System.EventHandler(this.btnWatchCreate_Click);
            // 
            // btnWatchModify
            // 
            this.btnWatchModify.Enabled = false;
            this.btnWatchModify.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchModify.Location = new System.Drawing.Point(92, 20);
            this.btnWatchModify.Name = "btnWatchModify";
            this.btnWatchModify.Size = new System.Drawing.Size(75, 23);
            this.btnWatchModify.TabIndex = 3;
            this.btnWatchModify.Text = "Modify";
            this.btnWatchModify.UseVisualStyleBackColor = true;
            this.btnWatchModify.Click += new System.EventHandler(this.btnWatchModify_Click);
            // 
            // btnWatchDelete
            // 
            this.btnWatchDelete.Enabled = false;
            this.btnWatchDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchDelete.Location = new System.Drawing.Point(92, 49);
            this.btnWatchDelete.Name = "btnWatchDelete";
            this.btnWatchDelete.Size = new System.Drawing.Size(75, 23);
            this.btnWatchDelete.TabIndex = 5;
            this.btnWatchDelete.Text = "Delete";
            this.btnWatchDelete.UseVisualStyleBackColor = true;
            this.btnWatchDelete.Click += new System.EventHandler(this.btnWatchDelete_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.ucEE_EventVariables);
            this.tabEvents.Controls.Add(this.ucEE_EventStructures);
            this.tabEvents.Controls.Add(this.ucEE_Events);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(842, 529);
            this.tabEvents.TabIndex = 3;
            this.tabEvents.Text = "Event";
            this.tabEvents.UseVisualStyleBackColor = true;
            this.tabEvents.Leave += new System.EventHandler(this.tabEvents_Leave);
            // 
            // ucEE_EventVariables
            // 
            this.ucEE_EventVariables.Location = new System.Drawing.Point(558, 4);
            this.ucEE_EventVariables.Name = "ucEE_EventVariables";
            this.ucEE_EventVariables.Size = new System.Drawing.Size(276, 456);
            this.ucEE_EventVariables.TabIndex = 36;
            this.ucEE_EventVariables.xGroupBoxTitle = "Event Variables";
            this.ucEE_EventVariables.xVisibleImportButton = false;
            this.ucEE_EventVariables.xVisibleLinksButton = false;
            this.ucEE_EventVariables.xVisibleModifyHelpTextButton = false;
            // 
            // ucEE_EventStructures
            // 
            this.ucEE_EventStructures.Location = new System.Drawing.Point(288, 3);
            this.ucEE_EventStructures.Name = "ucEE_EventStructures";
            this.ucEE_EventStructures.Size = new System.Drawing.Size(276, 456);
            this.ucEE_EventStructures.TabIndex = 35;
            this.ucEE_EventStructures.xGroupBoxTitle = "Event Structures";
            this.ucEE_EventStructures.xVisibleImportButton = false;
            this.ucEE_EventStructures.xVisibleLinksButton = false;
            this.ucEE_EventStructures.xVisibleModifyHelpTextButton = false;
            // 
            // ucEE_Events
            // 
            this.ucEE_Events.Location = new System.Drawing.Point(6, 4);
            this.ucEE_Events.Name = "ucEE_Events";
            this.ucEE_Events.Size = new System.Drawing.Size(276, 456);
            this.ucEE_Events.TabIndex = 34;
            this.ucEE_Events.xGroupBoxTitle = "Events";
            this.ucEE_Events.xVisibleImportButton = false;
            this.ucEE_Events.xVisibleLinksButton = false;
            this.ucEE_Events.xVisibleModifyHelpTextButton = false;
            // 
            // tabSelfTest
            // 
            this.tabSelfTest.Location = new System.Drawing.Point(4, 22);
            this.tabSelfTest.Name = "tabSelfTest";
            this.tabSelfTest.Size = new System.Drawing.Size(842, 529);
            this.tabSelfTest.TabIndex = 4;
            this.tabSelfTest.Text = "SelfTest";
            this.tabSelfTest.UseVisualStyleBackColor = true;
            // 
            // tabProjectDefinitions
            // 
            this.tabProjectDefinitions.Controls.Add(this.ucEE_Enumerations);
            this.tabProjectDefinitions.Controls.Add(this.ucEE_Bitmasks);
            this.tabProjectDefinitions.Controls.Add(this.ucEE_Units);
            this.tabProjectDefinitions.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProjectDefinitions.Location = new System.Drawing.Point(4, 22);
            this.tabProjectDefinitions.Name = "tabProjectDefinitions";
            this.tabProjectDefinitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjectDefinitions.Size = new System.Drawing.Size(842, 529);
            this.tabProjectDefinitions.TabIndex = 1;
            this.tabProjectDefinitions.Text = "Project Definitions";
            this.tabProjectDefinitions.UseVisualStyleBackColor = true;
            // 
            // ucEE_Enumerations
            // 
            this.ucEE_Enumerations.Location = new System.Drawing.Point(560, 6);
            this.ucEE_Enumerations.Name = "ucEE_Enumerations";
            this.ucEE_Enumerations.Size = new System.Drawing.Size(276, 421);
            this.ucEE_Enumerations.TabIndex = 23;
            this.ucEE_Enumerations.xGroupBoxTitle = "Enumerations";
            this.ucEE_Enumerations.xVisibleImportButton = false;
            this.ucEE_Enumerations.xVisibleLinksButton = false;
            this.ucEE_Enumerations.xVisibleModifyHelpTextButton = false;
            // 
            // ucEE_Bitmasks
            // 
            this.ucEE_Bitmasks.Location = new System.Drawing.Point(278, 6);
            this.ucEE_Bitmasks.Name = "ucEE_Bitmasks";
            this.ucEE_Bitmasks.Size = new System.Drawing.Size(276, 421);
            this.ucEE_Bitmasks.TabIndex = 22;
            this.ucEE_Bitmasks.xGroupBoxTitle = "Bitmasks";
            this.ucEE_Bitmasks.xVisibleImportButton = false;
            this.ucEE_Bitmasks.xVisibleLinksButton = false;
            this.ucEE_Bitmasks.xVisibleModifyHelpTextButton = false;
            // 
            // ucEE_Units
            // 
            this.ucEE_Units.Location = new System.Drawing.Point(0, 6);
            this.ucEE_Units.Name = "ucEE_Units";
            this.ucEE_Units.Size = new System.Drawing.Size(270, 421);
            this.ucEE_Units.TabIndex = 21;
            this.ucEE_Units.xGroupBoxTitle = "Units";
            this.ucEE_Units.xVisibleImportButton = false;
            this.ucEE_Units.xVisibleLinksButton = false;
            this.ucEE_Units.xVisibleModifyHelpTextButton = false;
            // 
            // tabProjectSettings
            // 
            this.tabProjectSettings.Controls.Add(this.btnProjSettingsCancelChanges);
            this.tabProjectSettings.Controls.Add(this.btnProjSettingsAcceptChanges);
            this.tabProjectSettings.Controls.Add(this.groupBox3);
            this.tabProjectSettings.Controls.Add(this.gBoxEventLogs);
            this.tabProjectSettings.Controls.Add(this.gBoxTargetCommunication);
            this.tabProjectSettings.Controls.Add(this.tableLayoutPanel1);
            this.tabProjectSettings.Controls.Add(this.groupBox2);
            this.tabProjectSettings.Location = new System.Drawing.Point(4, 22);
            this.tabProjectSettings.Name = "tabProjectSettings";
            this.tabProjectSettings.Size = new System.Drawing.Size(842, 529);
            this.tabProjectSettings.TabIndex = 5;
            this.tabProjectSettings.Text = "Project Settings";
            this.tabProjectSettings.UseVisualStyleBackColor = true;
            // 
            // btnProjSettingsCancelChanges
            // 
            this.btnProjSettingsCancelChanges.Location = new System.Drawing.Point(736, 471);
            this.btnProjSettingsCancelChanges.Name = "btnProjSettingsCancelChanges";
            this.btnProjSettingsCancelChanges.Size = new System.Drawing.Size(75, 41);
            this.btnProjSettingsCancelChanges.TabIndex = 12;
            this.btnProjSettingsCancelChanges.Text = "Cancel Changes";
            this.btnProjSettingsCancelChanges.UseVisualStyleBackColor = true;
            this.btnProjSettingsCancelChanges.Click += new System.EventHandler(this.btnProjSettingsCancelChanges_Click);
            // 
            // btnProjSettingsAcceptChanges
            // 
            this.btnProjSettingsAcceptChanges.Location = new System.Drawing.Point(655, 471);
            this.btnProjSettingsAcceptChanges.Name = "btnProjSettingsAcceptChanges";
            this.btnProjSettingsAcceptChanges.Size = new System.Drawing.Size(75, 41);
            this.btnProjSettingsAcceptChanges.TabIndex = 11;
            this.btnProjSettingsAcceptChanges.Text = "Accept Changes";
            this.btnProjSettingsAcceptChanges.UseVisualStyleBackColor = true;
            this.btnProjSettingsAcceptChanges.Click += new System.EventHandler(this.btnProjSettingsAcceptChanges_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxPasswordLevel3);
            this.groupBox3.Controls.Add(this.tBoxPasswordLevel2);
            this.groupBox3.Controls.Add(this.tBoxPasswordLevel1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(502, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 112);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PTU Password Settings";
            // 
            // tBoxPasswordLevel3
            // 
            this.tBoxPasswordLevel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordLevel3.Location = new System.Drawing.Point(72, 79);
            this.tBoxPasswordLevel3.Name = "tBoxPasswordLevel3";
            this.tBoxPasswordLevel3.Size = new System.Drawing.Size(198, 21);
            this.tBoxPasswordLevel3.TabIndex = 5;
            this.tBoxPasswordLevel3.Text = "aeg3";
            // 
            // tBoxPasswordLevel2
            // 
            this.tBoxPasswordLevel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordLevel2.Location = new System.Drawing.Point(72, 49);
            this.tBoxPasswordLevel2.Name = "tBoxPasswordLevel2";
            this.tBoxPasswordLevel2.Size = new System.Drawing.Size(198, 21);
            this.tBoxPasswordLevel2.TabIndex = 4;
            this.tBoxPasswordLevel2.Text = "aeg2";
            // 
            // tBoxPasswordLevel1
            // 
            this.tBoxPasswordLevel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordLevel1.Location = new System.Drawing.Point(72, 20);
            this.tBoxPasswordLevel1.Name = "tBoxPasswordLevel1";
            this.tBoxPasswordLevel1.Size = new System.Drawing.Size(198, 21);
            this.tBoxPasswordLevel1.TabIndex = 3;
            this.tBoxPasswordLevel1.Text = "aeg1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Level3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Level2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Level1";
            // 
            // gBoxEventLogs
            // 
            this.gBoxEventLogs.Controls.Add(this.dGridEventLog);
            this.gBoxEventLogs.Controls.Add(this.btnProjSettingsAddEventLog);
            this.gBoxEventLogs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxEventLogs.Location = new System.Drawing.Point(502, 3);
            this.gBoxEventLogs.Name = "gBoxEventLogs";
            this.gBoxEventLogs.Size = new System.Drawing.Size(320, 224);
            this.gBoxEventLogs.TabIndex = 9;
            this.gBoxEventLogs.TabStop = false;
            this.gBoxEventLogs.Text = "Event Logs";
            // 
            // dGridEventLog
            // 
            this.dGridEventLog.AllowUserToAddRows = false;
            this.dGridEventLog.AllowUserToDeleteRows = false;
            this.dGridEventLog.AllowUserToResizeColumns = false;
            this.dGridEventLog.AllowUserToResizeRows = false;
            this.dGridEventLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dGridEventLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridEventLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventLogEmbIndex,
            this.eventLogName});
            this.dGridEventLog.ContextMenuStrip = this.conMenuEventLogs;
            this.dGridEventLog.EnableHeadersVisualStyles = false;
            this.dGridEventLog.Location = new System.Drawing.Point(14, 20);
            this.dGridEventLog.Name = "dGridEventLog";
            this.dGridEventLog.RowTemplate.Height = 24;
            this.dGridEventLog.Size = new System.Drawing.Size(295, 148);
            this.dGridEventLog.TabIndex = 8;
            this.dGridEventLog.Leave += new System.EventHandler(this.dGridEventLog_Leave);
            // 
            // eventLogEmbIndex
            // 
            this.eventLogEmbIndex.Frozen = true;
            this.eventLogEmbIndex.HeaderText = "Embedded Index";
            this.eventLogEmbIndex.Name = "eventLogEmbIndex";
            // 
            // eventLogName
            // 
            this.eventLogName.Frozen = true;
            this.eventLogName.HeaderText = "Name";
            this.eventLogName.Name = "eventLogName";
            this.eventLogName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // conMenuEventLogs
            // 
            this.conMenuEventLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEventLogMenuItem,
            this.deleteEventLogMenuItem});
            this.conMenuEventLogs.Name = "conMenu";
            this.conMenuEventLogs.Size = new System.Drawing.Size(179, 48);
            // 
            // addNewEventLogMenuItem
            // 
            this.addNewEventLogMenuItem.Name = "addNewEventLogMenuItem";
            this.addNewEventLogMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewEventLogMenuItem.Text = "Add New Event Log";
            this.addNewEventLogMenuItem.Click += new System.EventHandler(this.addNewEventLogMenuItem_Click);
            // 
            // deleteEventLogMenuItem
            // 
            this.deleteEventLogMenuItem.Name = "deleteEventLogMenuItem";
            this.deleteEventLogMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deleteEventLogMenuItem.Text = "Delete";
            this.deleteEventLogMenuItem.Click += new System.EventHandler(this.deleteEventLogMenuItem_Click);
            // 
            // btnProjSettingsAddEventLog
            // 
            this.btnProjSettingsAddEventLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjSettingsAddEventLog.Location = new System.Drawing.Point(6, 180);
            this.btnProjSettingsAddEventLog.Name = "btnProjSettingsAddEventLog";
            this.btnProjSettingsAddEventLog.Size = new System.Drawing.Size(94, 29);
            this.btnProjSettingsAddEventLog.TabIndex = 4;
            this.btnProjSettingsAddEventLog.Text = "Add Event Log";
            this.btnProjSettingsAddEventLog.UseVisualStyleBackColor = true;
            this.btnProjSettingsAddEventLog.Click += new System.EventHandler(this.btnProjSettingsAddEventLog_Click);
            // 
            // gBoxTargetCommunication
            // 
            this.gBoxTargetCommunication.Controls.Add(this.gBoxURLs);
            this.gBoxTargetCommunication.Controls.Add(this.cBoxCommType);
            this.gBoxTargetCommunication.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTargetCommunication.Location = new System.Drawing.Point(17, 3);
            this.gBoxTargetCommunication.Name = "gBoxTargetCommunication";
            this.gBoxTargetCommunication.Size = new System.Drawing.Size(462, 224);
            this.gBoxTargetCommunication.TabIndex = 1;
            this.gBoxTargetCommunication.TabStop = false;
            this.gBoxTargetCommunication.Text = "Target Communication";
            // 
            // gBoxURLs
            // 
            this.gBoxURLs.Controls.Add(this.dGridURL);
            this.gBoxURLs.Controls.Add(this.btnProjSettingsAddURL);
            this.gBoxURLs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxURLs.Location = new System.Drawing.Point(126, 20);
            this.gBoxURLs.Name = "gBoxURLs";
            this.gBoxURLs.Size = new System.Drawing.Size(320, 195);
            this.gBoxURLs.TabIndex = 4;
            this.gBoxURLs.TabStop = false;
            this.gBoxURLs.Text = "URLs";
            // 
            // dGridURL
            // 
            this.dGridURL.AllowUserToAddRows = false;
            this.dGridURL.AllowUserToDeleteRows = false;
            this.dGridURL.AllowUserToResizeColumns = false;
            this.dGridURL.AllowUserToResizeRows = false;
            this.dGridURL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dGridURL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridURL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlName,
            this.urlAlias});
            this.dGridURL.ContextMenuStrip = this.conMenuURL;
            this.dGridURL.EnableHeadersVisualStyles = false;
            this.dGridURL.Location = new System.Drawing.Point(14, 20);
            this.dGridURL.Name = "dGridURL";
            this.dGridURL.RowTemplate.Height = 24;
            this.dGridURL.Size = new System.Drawing.Size(295, 128);
            this.dGridURL.TabIndex = 8;
            this.dGridURL.Leave += new System.EventHandler(this.dGridURL_Leave);
            // 
            // urlName
            // 
            this.urlName.Frozen = true;
            this.urlName.HeaderText = "URL";
            this.urlName.Name = "urlName";
            // 
            // urlAlias
            // 
            this.urlAlias.Frozen = true;
            this.urlAlias.HeaderText = "Alias";
            this.urlAlias.Name = "urlAlias";
            this.urlAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // conMenuURL
            // 
            this.conMenuURL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewURLMenuItem,
            this.deleteURLMenuItem});
            this.conMenuURL.Name = "conMenu";
            this.conMenuURL.Size = new System.Drawing.Size(148, 48);
            // 
            // addNewURLMenuItem
            // 
            this.addNewURLMenuItem.Name = "addNewURLMenuItem";
            this.addNewURLMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addNewURLMenuItem.Text = "Add New URL";
            this.addNewURLMenuItem.Click += new System.EventHandler(this.addNewURLMenuItem_Click);
            // 
            // deleteURLMenuItem
            // 
            this.deleteURLMenuItem.Name = "deleteURLMenuItem";
            this.deleteURLMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deleteURLMenuItem.Text = "Delete";
            this.deleteURLMenuItem.Click += new System.EventHandler(this.deleteURLMenuItem_Click);
            // 
            // btnProjSettingsAddURL
            // 
            this.btnProjSettingsAddURL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjSettingsAddURL.Location = new System.Drawing.Point(6, 160);
            this.btnProjSettingsAddURL.Name = "btnProjSettingsAddURL";
            this.btnProjSettingsAddURL.Size = new System.Drawing.Size(75, 29);
            this.btnProjSettingsAddURL.TabIndex = 4;
            this.btnProjSettingsAddURL.Text = "Add URL";
            this.btnProjSettingsAddURL.UseVisualStyleBackColor = true;
            this.btnProjSettingsAddURL.Click += new System.EventHandler(this.btnProjSettingsAddURL_Click);
            // 
            // cBoxCommType
            // 
            this.cBoxCommType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCommType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCommType.FormattingEnabled = true;
            this.cBoxCommType.Items.AddRange(new object[] {
            "Serial",
            "TCP",
            "Serial & TCP"});
            this.cBoxCommType.Location = new System.Drawing.Point(6, 20);
            this.cBoxCommType.Name = "cBoxCommType";
            this.cBoxCommType.Size = new System.Drawing.Size(101, 21);
            this.cBoxCommType.TabIndex = 0;
            this.cBoxCommType.SelectedIndexChanged += new System.EventHandler(this.cBoxCommType_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.43716F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.56284F));
            this.tableLayoutPanel1.Controls.Add(this.tBoxProjSettingsAppDataPath, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tBoxProjSettingsSoftwareVersion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tBoxProjSettingsWatchVarMax, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cBoxNumStreamVars, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 386);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 126);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tBoxProjSettingsAppDataPath
            // 
            this.tBoxProjSettingsAppDataPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBoxProjSettingsAppDataPath.Location = new System.Drawing.Point(151, 95);
            this.tBoxProjSettingsAppDataPath.Name = "tBoxProjSettingsAppDataPath";
            this.tBoxProjSettingsAppDataPath.Size = new System.Drawing.Size(205, 21);
            this.tBoxProjSettingsAppDataPath.TabIndex = 6;
            // 
            // tBoxProjSettingsSoftwareVersion
            // 
            this.tBoxProjSettingsSoftwareVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBoxProjSettingsSoftwareVersion.Location = new System.Drawing.Point(151, 62);
            this.tBoxProjSettingsSoftwareVersion.Name = "tBoxProjSettingsSoftwareVersion";
            this.tBoxProjSettingsSoftwareVersion.Size = new System.Drawing.Size(102, 21);
            this.tBoxProjSettingsSoftwareVersion.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "Displayed Watch Variables (max)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Software Version";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Application Data Path";
            // 
            // tBoxProjSettingsWatchVarMax
            // 
            this.tBoxProjSettingsWatchVarMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBoxProjSettingsWatchVarMax.Location = new System.Drawing.Point(151, 4);
            this.tBoxProjSettingsWatchVarMax.Name = "tBoxProjSettingsWatchVarMax";
            this.tBoxProjSettingsWatchVarMax.Size = new System.Drawing.Size(72, 21);
            this.tBoxProjSettingsWatchVarMax.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Number of Stream Vars";
            // 
            // cBoxNumStreamVars
            // 
            this.cBoxNumStreamVars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxNumStreamVars.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNumStreamVars.FormattingEnabled = true;
            this.cBoxNumStreamVars.Items.AddRange(new object[] {
            "8",
            "16"});
            this.cBoxNumStreamVars.Location = new System.Drawing.Point(151, 32);
            this.cBoxNumStreamVars.Name = "cBoxNumStreamVars";
            this.cBoxNumStreamVars.Size = new System.Drawing.Size(50, 21);
            this.cBoxNumStreamVars.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cListBoxFunctionFlags);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 139);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function Flags";
            // 
            // cListBoxFunctionFlags
            // 
            this.cListBoxFunctionFlags.CheckOnClick = true;
            this.cListBoxFunctionFlags.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cListBoxFunctionFlags.FormattingEnabled = true;
            this.cListBoxFunctionFlags.Items.AddRange(new object[] {
            "Target requires 4 digit year code",
            "Event log name field displayed in saved event logs",
            "CSV and XML file generated for event log files",
            "Target supports \"pinging\" during idle times while in self test",
            "Display URL Alias Name"});
            this.cListBoxFunctionFlags.Location = new System.Drawing.Point(6, 23);
            this.cListBoxFunctionFlags.Name = "cListBoxFunctionFlags";
            this.cListBoxFunctionFlags.Size = new System.Drawing.Size(400, 84);
            this.cListBoxFunctionFlags.TabIndex = 4;
            this.cListBoxFunctionFlags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cListBoxFunctionFlags_ItemCheck);
            this.cListBoxFunctionFlags.Leave += new System.EventHandler(this.cListBoxFunctionFlags_Leave);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(871, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.importToolStripMenuItem.Text = "Import...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit..";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genEmbToolStripMenuItem,
            this.genHelpFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.previewBitmasksToolStripMenuItem,
            this.previewEnumerationsToolStripMenuItem,
            this.previewEventsToolStripMenuItem,
            this.previewEventVariablesToolStripMenuItem,
            this.previewEventStructuresToolStripMenuItem,
            this.previewHelpToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // genEmbToolStripMenuItem
            // 
            this.genEmbToolStripMenuItem.Name = "genEmbToolStripMenuItem";
            this.genEmbToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.genEmbToolStripMenuItem.Text = "Generate Emb Code";
            // 
            // genHelpFileToolStripMenuItem
            // 
            this.genHelpFileToolStripMenuItem.Name = "genHelpFileToolStripMenuItem";
            this.genHelpFileToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.genHelpFileToolStripMenuItem.Text = "Generate Help File (.chm)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItem1.Text = "Dependencies...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // previewBitmasksToolStripMenuItem
            // 
            this.previewBitmasksToolStripMenuItem.CheckOnClick = true;
            this.previewBitmasksToolStripMenuItem.Name = "previewBitmasksToolStripMenuItem";
            this.previewBitmasksToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewBitmasksToolStripMenuItem.Text = "Preview Bitmasks";
            this.previewBitmasksToolStripMenuItem.Click += new System.EventHandler(this.previewBitmasksToolStripMenuItem_Click);
            // 
            // previewEnumerationsToolStripMenuItem
            // 
            this.previewEnumerationsToolStripMenuItem.CheckOnClick = true;
            this.previewEnumerationsToolStripMenuItem.Name = "previewEnumerationsToolStripMenuItem";
            this.previewEnumerationsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewEnumerationsToolStripMenuItem.Text = "Preview Enumerations";
            this.previewEnumerationsToolStripMenuItem.Click += new System.EventHandler(this.previewEnumerationsToolStripMenuItem_Click);
            // 
            // previewEventsToolStripMenuItem
            // 
            this.previewEventsToolStripMenuItem.CheckOnClick = true;
            this.previewEventsToolStripMenuItem.Name = "previewEventsToolStripMenuItem";
            this.previewEventsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewEventsToolStripMenuItem.Text = "Preview Event";
            this.previewEventsToolStripMenuItem.Click += new System.EventHandler(this.previewEventsToolStripMenuItem_Click);
            // 
            // previewEventVariablesToolStripMenuItem
            // 
            this.previewEventVariablesToolStripMenuItem.CheckOnClick = true;
            this.previewEventVariablesToolStripMenuItem.Name = "previewEventVariablesToolStripMenuItem";
            this.previewEventVariablesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewEventVariablesToolStripMenuItem.Text = "Preview Event Variables";
            // 
            // previewEventStructuresToolStripMenuItem
            // 
            this.previewEventStructuresToolStripMenuItem.CheckOnClick = true;
            this.previewEventStructuresToolStripMenuItem.Name = "previewEventStructuresToolStripMenuItem";
            this.previewEventStructuresToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewEventStructuresToolStripMenuItem.Text = "Preview Event Structures";
            // 
            // previewHelpToolStripMenuItem
            // 
            this.previewHelpToolStripMenuItem.CheckOnClick = true;
            this.previewHelpToolStripMenuItem.Name = "previewHelpToolStripMenuItem";
            this.previewHelpToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewHelpToolStripMenuItem.Text = "Preview Help";
            this.previewHelpToolStripMenuItem.Click += new System.EventHandler(this.previewHelpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem1.Text = "About...";
            // 
            // btnExitDDB
            // 
            this.btnExitDDB.Location = new System.Drawing.Point(348, 588);
            this.btnExitDDB.Name = "btnExitDDB";
            this.btnExitDDB.Size = new System.Drawing.Size(120, 40);
            this.btnExitDDB.TabIndex = 2;
            this.btnExitDDB.Text = "Exit DDB";
            this.btnExitDDB.UseVisualStyleBackColor = true;
            this.btnExitDDB.Click += new System.EventHandler(this.btnExitDDB_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(871, 635);
            this.Controls.Add(this.btnExitDDB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bombardier DDB (v 0.0.0.10)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabWatchVariables.ResumeLayout(false);
            this.grpBoxWatchVarList.ResumeLayout(false);
            this.grpBoxWatchVarList.PerformLayout();
            this.conMenuWatchVarList.ResumeLayout(false);
            this.grpBoxWatchAttrs.ResumeLayout(false);
            this.grpBoxWatchAttrs.PerformLayout();
            this.gBoxWatchVarMod.ResumeLayout(false);
            this.gBoxWatchVarMod.PerformLayout();
            this.gBoxWatchChartScaling.ResumeLayout(false);
            this.gBoxWatchChartScaling.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxWatchActions.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tabProjectDefinitions.ResumeLayout(false);
            this.tabProjectSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gBoxEventLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridEventLog)).EndInit();
            this.conMenuEventLogs.ResumeLayout(false);
            this.gBoxTargetCommunication.ResumeLayout(false);
            this.gBoxURLs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridURL)).EndInit();
            this.conMenuURL.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabWatchVariables;
        private System.Windows.Forms.TabPage tabProjectDefinitions;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genEmbToolStripMenuItem;
        private System.Windows.Forms.ListBox lBoxWatchVariables;
        private System.Windows.Forms.Button btnWatchCreate;
        private System.Windows.Forms.GroupBox grpBoxWatchAttrs;
        private System.Windows.Forms.GroupBox gBoxWatchChartScaling;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxWatchMaxChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxWatchMinChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxWatchEmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxWatchDisplayName;
        private System.Windows.Forms.Button btnWatchDelete;
        private System.Windows.Forms.Button btnWatchCopy;
        private System.Windows.Forms.Button btnWatchModify;
        private System.Windows.Forms.GroupBox gBoxWatchVarMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxWatchMaxValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxWatchMinValue;
        private System.Windows.Forms.Button btnWatchCancel;
        private System.Windows.Forms.Button btnWatchAccept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxWatchDataType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxWatchUnits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnWatchSortDes;
        private System.Windows.Forms.Button btnWatchSortAsc;
        private System.Windows.Forms.Button btnWatchFilterApply;
        private System.Windows.Forms.TextBox tBoxWatchFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip conMenuWatchVarList;
        private System.Windows.Forms.ToolStripMenuItem copyWatchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyWatchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWatchMenuItem;
        private System.Windows.Forms.GroupBox grpBoxWatchVarList;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem genHelpFileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabSelfTest;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cBoxWatchList;
        private System.Windows.Forms.ComboBox cBoxWatchReadWriteFlags;
        private System.Windows.Forms.ComboBox cBoxWatchScaleType;
        private System.Windows.Forms.Label lblWatchUnitsEnumBitmask;
        private System.Windows.Forms.ComboBox cBoxWatchUnitConversion;
        private System.Windows.Forms.ComboBox cBoxWatchScaleInfo;
        private System.Windows.Forms.Label lblWatchUnitConversion;
        private System.Windows.Forms.Label lblWatchScaleInfo;
        private System.Windows.Forms.ComboBox cBoxWatchFormatString;
        private System.Windows.Forms.Button btnWatchModifyHelpText;
        private System.Windows.Forms.Label lblFormatString;
        private System.Windows.Forms.CheckBox chkWatchEngViewOnly;
        private System.Windows.Forms.Button btnExitDDB;
        private System.Windows.Forms.Button btnWatchImport;
        private System.Windows.Forms.TabPage tabProjectSettings;
        private System.Windows.Forms.ToolStripMenuItem previewBitmasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewEnumerationsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gBoxTargetCommunication;
        private System.Windows.Forms.ComboBox cBoxCommType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox cListBoxFunctionFlags;
        private System.Windows.Forms.GroupBox gBoxURLs;
        private System.Windows.Forms.Button btnProjSettingsAddURL;
        private System.Windows.Forms.TextBox tBoxProjSettingsAppDataPath;
        private System.Windows.Forms.TextBox tBoxProjSettingsSoftwareVersion;
        private System.Windows.Forms.TextBox tBoxProjSettingsWatchVarMax;
        private System.Windows.Forms.DataGridView dGridURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlName;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlAlias;
        private System.Windows.Forms.ContextMenuStrip conMenuURL;
        private System.Windows.Forms.ToolStripMenuItem addNewURLMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteURLMenuItem;
        private System.Windows.Forms.GroupBox gBoxEventLogs;
        private System.Windows.Forms.DataGridView dGridEventLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventLogEmbIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventLogName;
        private System.Windows.Forms.Button btnProjSettingsAddEventLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBoxPasswordLevel3;
        private System.Windows.Forms.TextBox tBoxPasswordLevel2;
        private System.Windows.Forms.TextBox tBoxPasswordLevel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gBoxWatchActions;
        private System.Windows.Forms.ToolStripMenuItem previewEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewEventVariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewEventStructuresToolStripMenuItem;
        private System.Windows.Forms.Button btnWatchFilterClear;
        private System.Windows.Forms.ToolStripMenuItem previewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip conMenuEventLogs;
        private System.Windows.Forms.ToolStripMenuItem addNewEventLogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventLogMenuItem;
        private System.Windows.Forms.Button btnProjSettingsCancelChanges;
        private System.Windows.Forms.Button btnProjSettingsAcceptChanges;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cBoxNumStreamVars;
        private UserControlEntityEditor ucEE_Units;
        private UserControlEntityEditor ucEE_Bitmasks;
        private UserControlEntityEditor ucEE_Enumerations;
        private UserControlEntityEditor ucEE_Events;
        private UserControlEntityEditor ucEE_EventVariables;
        private UserControlEntityEditor ucEE_EventStructures;
    }
}

