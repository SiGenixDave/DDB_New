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
            this.btnWatchImport = new System.Windows.Forms.Button();
            this.grpBoxWatchVarList = new System.Windows.Forms.GroupBox();
            this.cBoxWatchList = new System.Windows.Forms.ComboBox();
            this.btnWatchSortZtoA = new System.Windows.Forms.Button();
            this.btnWatchFilterApply = new System.Windows.Forms.Button();
            this.lBoxWatchVariables = new System.Windows.Forms.ListBox();
            this.conMenuWatchVarList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBoxWatchFilter = new System.Windows.Forms.TextBox();
            this.btnWatchSortAtoZ = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.grpBoxWatchAttrs = new System.Windows.Forms.GroupBox();
            this.btnWatchHelpAvailable = new System.Windows.Forms.Button();
            this.cBoxWatchUnitConversion = new System.Windows.Forms.ComboBox();
            this.cBoxWatchScaleInfo = new System.Windows.Forms.ComboBox();
            this.lblWatchUnitConversion = new System.Windows.Forms.Label();
            this.lblWatchScaleInfo = new System.Windows.Forms.Label();
            this.cBoxWatchFormatString = new System.Windows.Forms.ComboBox();
            this.btnWatchModifyHelpText = new System.Windows.Forms.Button();
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
            this.btnWatchCancel = new System.Windows.Forms.Button();
            this.btnWatchAccept = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxWatchMaxValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxWatchMinValue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxWatchMaxChart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxWatchMinChart = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxWatchEmbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxWatchDisplayName = new System.Windows.Forms.TextBox();
            this.btnWatchDelete = new System.Windows.Forms.Button();
            this.btnWatchCopy = new System.Windows.Forms.Button();
            this.btnWatchModify = new System.Windows.Forms.Button();
            this.btnWatchCreate = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tabSelfTest = new System.Windows.Forms.TabPage();
            this.tabProjectDefinitions = new System.Windows.Forms.TabPage();
            this.gBoxProjBitmask = new System.Windows.Forms.GroupBox();
            this.btnProBitmasksImport = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnProBitmasksCopy = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnProBitmasksDelete = new System.Windows.Forms.Button();
            this.btnProBitmasksModify = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnProBitmasksCreate = new System.Windows.Forms.Button();
            this.lBoxProjBitmasks = new System.Windows.Forms.ListBox();
            this.conMenuBitmasks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyBitmasksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBitmasksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBitmasksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxProjUnits = new System.Windows.Forms.GroupBox();
            this.btnProjUnitsImport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProUnitsCopy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProUnitsDelete = new System.Windows.Forms.Button();
            this.btnProUnitsModify = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProUnitsCreate = new System.Windows.Forms.Button();
            this.lBoxProjUnits = new System.Windows.Forms.ListBox();
            this.conMenuUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyUnitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUnitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUnitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabProjectSettings = new System.Windows.Forms.TabPage();
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
            this.previewBitmasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEnumerationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExitDDB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabWatchVariables.SuspendLayout();
            this.grpBoxWatchVarList.SuspendLayout();
            this.conMenuWatchVarList.SuspendLayout();
            this.grpBoxWatchAttrs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabProjectDefinitions.SuspendLayout();
            this.gBoxProjBitmask.SuspendLayout();
            this.conMenuBitmasks.SuspendLayout();
            this.gBoxProjUnits.SuspendLayout();
            this.conMenuUnits.SuspendLayout();
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
            // 
            // tabWatchVariables
            // 
            this.tabWatchVariables.Controls.Add(this.btnWatchImport);
            this.tabWatchVariables.Controls.Add(this.grpBoxWatchVarList);
            this.tabWatchVariables.Controls.Add(this.grpBoxWatchAttrs);
            this.tabWatchVariables.Controls.Add(this.btnWatchDelete);
            this.tabWatchVariables.Controls.Add(this.btnWatchCopy);
            this.tabWatchVariables.Controls.Add(this.btnWatchModify);
            this.tabWatchVariables.Controls.Add(this.btnWatchCreate);
            this.tabWatchVariables.Location = new System.Drawing.Point(4, 26);
            this.tabWatchVariables.Name = "tabWatchVariables";
            this.tabWatchVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabWatchVariables.Size = new System.Drawing.Size(842, 525);
            this.tabWatchVariables.TabIndex = 0;
            this.tabWatchVariables.Text = "Watch Variables";
            this.tabWatchVariables.UseVisualStyleBackColor = true;
            // 
            // btnWatchImport
            // 
            this.btnWatchImport.Location = new System.Drawing.Point(721, 482);
            this.btnWatchImport.Name = "btnWatchImport";
            this.btnWatchImport.Size = new System.Drawing.Size(75, 23);
            this.btnWatchImport.TabIndex = 7;
            this.btnWatchImport.Text = "Import...";
            this.toolTip1.SetToolTip(this.btnWatchImport, "\"TODO Import watch variables from another XML file\"");
            this.btnWatchImport.UseVisualStyleBackColor = true;
            this.btnWatchImport.Click += new System.EventHandler(this.btnWatchImport_Click);
            // 
            // grpBoxWatchVarList
            // 
            this.grpBoxWatchVarList.Controls.Add(this.cBoxWatchList);
            this.grpBoxWatchVarList.Controls.Add(this.btnWatchSortZtoA);
            this.grpBoxWatchVarList.Controls.Add(this.btnWatchFilterApply);
            this.grpBoxWatchVarList.Controls.Add(this.lBoxWatchVariables);
            this.grpBoxWatchVarList.Controls.Add(this.tBoxWatchFilter);
            this.grpBoxWatchVarList.Controls.Add(this.btnWatchSortAtoZ);
            this.grpBoxWatchVarList.Controls.Add(this.label11);
            this.grpBoxWatchVarList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWatchVarList.Location = new System.Drawing.Point(6, 27);
            this.grpBoxWatchVarList.Name = "grpBoxWatchVarList";
            this.grpBoxWatchVarList.Size = new System.Drawing.Size(286, 478);
            this.grpBoxWatchVarList.TabIndex = 2;
            this.grpBoxWatchVarList.TabStop = false;
            this.grpBoxWatchVarList.Text = "Watch Variable List";
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
            this.cBoxWatchList.Size = new System.Drawing.Size(132, 25);
            this.cBoxWatchList.TabIndex = 14;
            this.cBoxWatchList.SelectedIndexChanged += new System.EventHandler(this.cBoxWatchList_SelectedIndexChanged);
            // 
            // btnWatchSortZtoA
            // 
            this.btnWatchSortZtoA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchSortZtoA.Location = new System.Drawing.Point(207, 444);
            this.btnWatchSortZtoA.Name = "btnWatchSortZtoA";
            this.btnWatchSortZtoA.Size = new System.Drawing.Size(72, 23);
            this.btnWatchSortZtoA.TabIndex = 12;
            this.btnWatchSortZtoA.Text = "Sort Z-A";
            this.toolTip1.SetToolTip(this.btnWatchSortZtoA, "\"Not yet Implemeneted\"");
            this.btnWatchSortZtoA.UseVisualStyleBackColor = true;
            this.btnWatchSortZtoA.Click += new System.EventHandler(this.btnWatchSortZtoA_Click);
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
            this.lBoxWatchVariables.ItemHeight = 17;
            this.lBoxWatchVariables.Location = new System.Drawing.Point(6, 65);
            this.lBoxWatchVariables.Name = "lBoxWatchVariables";
            this.lBoxWatchVariables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBoxWatchVariables.Size = new System.Drawing.Size(273, 327);
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
            this.conMenuWatchVarList.Size = new System.Drawing.Size(126, 76);
            // 
            // copyWatchMenuItem
            // 
            this.copyWatchMenuItem.Name = "copyWatchMenuItem";
            this.copyWatchMenuItem.Size = new System.Drawing.Size(125, 24);
            this.copyWatchMenuItem.Text = "Copy";
            this.copyWatchMenuItem.Click += new System.EventHandler(this.copyWatchMenuItem_Click);
            // 
            // modifyWatchMenuItem
            // 
            this.modifyWatchMenuItem.Name = "modifyWatchMenuItem";
            this.modifyWatchMenuItem.Size = new System.Drawing.Size(125, 24);
            this.modifyWatchMenuItem.Text = "Modify";
            this.modifyWatchMenuItem.Click += new System.EventHandler(this.modifyWatchMenuItem_Click);
            // 
            // deleteWatchMenuItem
            // 
            this.deleteWatchMenuItem.Name = "deleteWatchMenuItem";
            this.deleteWatchMenuItem.Size = new System.Drawing.Size(125, 24);
            this.deleteWatchMenuItem.Text = "Delete";
            this.deleteWatchMenuItem.Click += new System.EventHandler(this.deleteWatchMenuItem_Click);
            // 
            // tBoxWatchFilter
            // 
            this.tBoxWatchFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchFilter.Location = new System.Drawing.Point(6, 414);
            this.tBoxWatchFilter.Name = "tBoxWatchFilter";
            this.tBoxWatchFilter.Size = new System.Drawing.Size(192, 24);
            this.tBoxWatchFilter.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tBoxWatchFilter, "\"Not yet Implemeneted\"");
            // 
            // btnWatchSortAtoZ
            // 
            this.btnWatchSortAtoZ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchSortAtoZ.Location = new System.Drawing.Point(207, 414);
            this.btnWatchSortAtoZ.Name = "btnWatchSortAtoZ";
            this.btnWatchSortAtoZ.Size = new System.Drawing.Size(72, 23);
            this.btnWatchSortAtoZ.TabIndex = 11;
            this.btnWatchSortAtoZ.Text = "Sort A-Z";
            this.toolTip1.SetToolTip(this.btnWatchSortAtoZ, "\"Not yet Implemeneted\"");
            this.btnWatchSortAtoZ.UseVisualStyleBackColor = true;
            this.btnWatchSortAtoZ.Click += new System.EventHandler(this.btnWatchSortAtoZ_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Filter";
            // 
            // grpBoxWatchAttrs
            // 
            this.grpBoxWatchAttrs.Controls.Add(this.btnWatchHelpAvailable);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchUnitConversion);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchScaleInfo);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchUnitConversion);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchScaleInfo);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchFormatString);
            this.grpBoxWatchAttrs.Controls.Add(this.btnWatchModifyHelpText);
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
            this.grpBoxWatchAttrs.Controls.Add(this.btnWatchCancel);
            this.grpBoxWatchAttrs.Controls.Add(this.btnWatchAccept);
            this.grpBoxWatchAttrs.Controls.Add(this.groupBox3);
            this.grpBoxWatchAttrs.Controls.Add(this.groupBox2);
            this.grpBoxWatchAttrs.Controls.Add(this.groupBox1);
            this.grpBoxWatchAttrs.Enabled = false;
            this.grpBoxWatchAttrs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWatchAttrs.Location = new System.Drawing.Point(298, 27);
            this.grpBoxWatchAttrs.Name = "grpBoxWatchAttrs";
            this.grpBoxWatchAttrs.Size = new System.Drawing.Size(528, 434);
            this.grpBoxWatchAttrs.TabIndex = 6;
            this.grpBoxWatchAttrs.TabStop = false;
            this.grpBoxWatchAttrs.Text = "Attributes";
            // 
            // btnWatchHelpAvailable
            // 
            this.btnWatchHelpAvailable.Location = new System.Drawing.Point(382, 366);
            this.btnWatchHelpAvailable.Name = "btnWatchHelpAvailable";
            this.btnWatchHelpAvailable.Size = new System.Drawing.Size(19, 49);
            this.btnWatchHelpAvailable.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnWatchHelpAvailable, "RED if no help text; GREEN otherwise");
            this.btnWatchHelpAvailable.UseVisualStyleBackColor = true;
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
            this.cBoxWatchUnitConversion.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchUnitConversion.TabIndex = 23;
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
            this.cBoxWatchScaleInfo.Size = new System.Drawing.Size(143, 25);
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
            // lblWatchScaleInfo
            // 
            this.lblWatchScaleInfo.AutoSize = true;
            this.lblWatchScaleInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchScaleInfo.Location = new System.Drawing.Point(266, 235);
            this.lblWatchScaleInfo.Name = "lblWatchScaleInfo";
            this.lblWatchScaleInfo.Size = new System.Drawing.Size(77, 17);
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
            this.cBoxWatchFormatString.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchFormatString.TabIndex = 19;
            // 
            // btnWatchModifyHelpText
            // 
            this.btnWatchModifyHelpText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchModifyHelpText.Location = new System.Drawing.Point(223, 366);
            this.btnWatchModifyHelpText.Name = "btnWatchModifyHelpText";
            this.btnWatchModifyHelpText.Size = new System.Drawing.Size(153, 49);
            this.btnWatchModifyHelpText.TabIndex = 18;
            this.btnWatchModifyHelpText.Text = "Modify Help Text...";
            this.btnWatchModifyHelpText.UseVisualStyleBackColor = true;
            this.btnWatchModifyHelpText.Click += new System.EventHandler(this.btnWatchModifyHelpText_Click);
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
            this.chkWatchEngViewOnly.Location = new System.Drawing.Point(22, 401);
            this.chkWatchEngViewOnly.Name = "chkWatchEngViewOnly";
            this.chkWatchEngViewOnly.Size = new System.Drawing.Size(182, 21);
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
            this.cBoxWatchScaleType.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchScaleType.TabIndex = 15;
            this.cBoxWatchScaleType.SelectedIndexChanged += new System.EventHandler(this.cBoxWatchScaleType_SelectedIndexChanged);
            // 
            // lblWatchUnitsEnumBitmask
            // 
            this.lblWatchUnitsEnumBitmask.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchUnitsEnumBitmask.Location = new System.Drawing.Point(240, 201);
            this.lblWatchUnitsEnumBitmask.Name = "lblWatchUnitsEnumBitmask";
            this.lblWatchUnitsEnumBitmask.Size = new System.Drawing.Size(93, 17);
            this.lblWatchUnitsEnumBitmask.TabIndex = 14;
            this.lblWatchUnitsEnumBitmask.Text = "Units";
            this.lblWatchUnitsEnumBitmask.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchUnits
            // 
            this.cBoxWatchUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchUnits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchUnits.FormattingEnabled = true;
            this.cBoxWatchUnits.Location = new System.Drawing.Point(349, 197);
            this.cBoxWatchUnits.Name = "cBoxWatchUnits";
            this.cBoxWatchUnits.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchUnits.TabIndex = 13;
            this.cBoxWatchUnits.SelectedIndexChanged += new System.EventHandler(this.cBoxWatchUnits_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
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
            this.cBoxWatchReadWriteFlags.Location = new System.Drawing.Point(21, 360);
            this.cBoxWatchReadWriteFlags.Name = "cBoxWatchReadWriteFlags";
            this.cBoxWatchReadWriteFlags.Size = new System.Drawing.Size(132, 25);
            this.cBoxWatchReadWriteFlags.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 21);
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
            this.cBoxWatchDataType.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchDataType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnWatchCancel
            // 
            this.btnWatchCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchCancel.Location = new System.Drawing.Point(408, 392);
            this.btnWatchCancel.Name = "btnWatchCancel";
            this.btnWatchCancel.Size = new System.Drawing.Size(99, 34);
            this.btnWatchCancel.TabIndex = 8;
            this.btnWatchCancel.Text = "Cancel";
            this.btnWatchCancel.UseVisualStyleBackColor = true;
            this.btnWatchCancel.Click += new System.EventHandler(this.btnWatchCancel_Click);
            // 
            // btnWatchAccept
            // 
            this.btnWatchAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchAccept.Location = new System.Drawing.Point(408, 351);
            this.btnWatchAccept.Name = "btnWatchAccept";
            this.btnWatchAccept.Size = new System.Drawing.Size(99, 34);
            this.btnWatchAccept.TabIndex = 7;
            this.btnWatchAccept.Text = "Accept";
            this.btnWatchAccept.UseVisualStyleBackColor = true;
            this.btnWatchAccept.Click += new System.EventHandler(this.btnWatchAccept_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tBoxWatchMaxValue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tBoxWatchMinValue);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 94);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Variable Modification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maximum Value";
            // 
            // tBoxWatchMaxValue
            // 
            this.tBoxWatchMaxValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMaxValue.Location = new System.Drawing.Point(102, 60);
            this.tBoxWatchMaxValue.Name = "tBoxWatchMaxValue";
            this.tBoxWatchMaxValue.Size = new System.Drawing.Size(107, 24);
            this.tBoxWatchMaxValue.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Minimum Value";
            // 
            // tBoxWatchMinValue
            // 
            this.tBoxWatchMinValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMinValue.Location = new System.Drawing.Point(102, 31);
            this.tBoxWatchMinValue.Name = "tBoxWatchMinValue";
            this.tBoxWatchMinValue.Size = new System.Drawing.Size(107, 24);
            this.tBoxWatchMinValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tBoxWatchMaxChart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tBoxWatchMinChart);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart Scaling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum Value";
            // 
            // tBoxWatchMaxChart
            // 
            this.tBoxWatchMaxChart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMaxChart.Location = new System.Drawing.Point(102, 60);
            this.tBoxWatchMaxChart.Name = "tBoxWatchMaxChart";
            this.tBoxWatchMaxChart.Size = new System.Drawing.Size(107, 24);
            this.tBoxWatchMaxChart.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minimum Value";
            // 
            // tBoxWatchMinChart
            // 
            this.tBoxWatchMinChart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchMinChart.Location = new System.Drawing.Point(102, 31);
            this.tBoxWatchMinChart.Name = "tBoxWatchMinChart";
            this.tBoxWatchMinChart.Size = new System.Drawing.Size(107, 24);
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
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Embedded";
            // 
            // tBoxWatchEmbName
            // 
            this.tBoxWatchEmbName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchEmbName.Location = new System.Drawing.Point(76, 60);
            this.tBoxWatchEmbName.Name = "tBoxWatchEmbName";
            this.tBoxWatchEmbName.Size = new System.Drawing.Size(404, 24);
            this.tBoxWatchEmbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display";
            // 
            // tBoxWatchDisplayName
            // 
            this.tBoxWatchDisplayName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchDisplayName.Location = new System.Drawing.Point(76, 31);
            this.tBoxWatchDisplayName.Name = "tBoxWatchDisplayName";
            this.tBoxWatchDisplayName.Size = new System.Drawing.Size(404, 24);
            this.tBoxWatchDisplayName.TabIndex = 0;
            // 
            // btnWatchDelete
            // 
            this.btnWatchDelete.Enabled = false;
            this.btnWatchDelete.Location = new System.Drawing.Point(541, 496);
            this.btnWatchDelete.Name = "btnWatchDelete";
            this.btnWatchDelete.Size = new System.Drawing.Size(75, 23);
            this.btnWatchDelete.TabIndex = 5;
            this.btnWatchDelete.Text = "Delete";
            this.btnWatchDelete.UseVisualStyleBackColor = true;
            this.btnWatchDelete.Click += new System.EventHandler(this.btnWatchDelete_Click);
            // 
            // btnWatchCopy
            // 
            this.btnWatchCopy.Enabled = false;
            this.btnWatchCopy.Location = new System.Drawing.Point(541, 467);
            this.btnWatchCopy.Name = "btnWatchCopy";
            this.btnWatchCopy.Size = new System.Drawing.Size(75, 23);
            this.btnWatchCopy.TabIndex = 4;
            this.btnWatchCopy.Text = "Copy";
            this.btnWatchCopy.UseVisualStyleBackColor = true;
            this.btnWatchCopy.Click += new System.EventHandler(this.btnWatchCopy_Click);
            // 
            // btnWatchModify
            // 
            this.btnWatchModify.Enabled = false;
            this.btnWatchModify.Location = new System.Drawing.Point(453, 496);
            this.btnWatchModify.Name = "btnWatchModify";
            this.btnWatchModify.Size = new System.Drawing.Size(75, 23);
            this.btnWatchModify.TabIndex = 3;
            this.btnWatchModify.Text = "Modify";
            this.btnWatchModify.UseVisualStyleBackColor = true;
            this.btnWatchModify.Click += new System.EventHandler(this.btnWatchModify_Click);
            // 
            // btnWatchCreate
            // 
            this.btnWatchCreate.Location = new System.Drawing.Point(453, 467);
            this.btnWatchCreate.Name = "btnWatchCreate";
            this.btnWatchCreate.Size = new System.Drawing.Size(75, 23);
            this.btnWatchCreate.TabIndex = 2;
            this.btnWatchCreate.Text = "Create";
            this.btnWatchCreate.UseVisualStyleBackColor = true;
            this.btnWatchCreate.Click += new System.EventHandler(this.btnWatchCreate_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(842, 526);
            this.tabEvents.TabIndex = 3;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // tabSelfTest
            // 
            this.tabSelfTest.Location = new System.Drawing.Point(4, 25);
            this.tabSelfTest.Name = "tabSelfTest";
            this.tabSelfTest.Size = new System.Drawing.Size(842, 526);
            this.tabSelfTest.TabIndex = 4;
            this.tabSelfTest.Text = "SelfTest";
            this.tabSelfTest.UseVisualStyleBackColor = true;
            // 
            // tabProjectDefinitions
            // 
            this.tabProjectDefinitions.Controls.Add(this.gBoxProjBitmask);
            this.tabProjectDefinitions.Controls.Add(this.gBoxProjUnits);
            this.tabProjectDefinitions.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProjectDefinitions.Location = new System.Drawing.Point(4, 26);
            this.tabProjectDefinitions.Name = "tabProjectDefinitions";
            this.tabProjectDefinitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjectDefinitions.Size = new System.Drawing.Size(842, 525);
            this.tabProjectDefinitions.TabIndex = 1;
            this.tabProjectDefinitions.Text = "Project Definitions";
            this.tabProjectDefinitions.UseVisualStyleBackColor = true;
            // 
            // gBoxProjBitmask
            // 
            this.gBoxProjBitmask.Controls.Add(this.btnProBitmasksImport);
            this.gBoxProjBitmask.Controls.Add(this.button5);
            this.gBoxProjBitmask.Controls.Add(this.btnProBitmasksCopy);
            this.gBoxProjBitmask.Controls.Add(this.button7);
            this.gBoxProjBitmask.Controls.Add(this.button8);
            this.gBoxProjBitmask.Controls.Add(this.btnProBitmasksDelete);
            this.gBoxProjBitmask.Controls.Add(this.btnProBitmasksModify);
            this.gBoxProjBitmask.Controls.Add(this.textBox2);
            this.gBoxProjBitmask.Controls.Add(this.label12);
            this.gBoxProjBitmask.Controls.Add(this.btnProBitmasksCreate);
            this.gBoxProjBitmask.Controls.Add(this.lBoxProjBitmasks);
            this.gBoxProjBitmask.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxProjBitmask.Location = new System.Drawing.Point(273, 20);
            this.gBoxProjBitmask.Name = "gBoxProjBitmask";
            this.gBoxProjBitmask.Size = new System.Drawing.Size(247, 499);
            this.gBoxProjBitmask.TabIndex = 19;
            this.gBoxProjBitmask.TabStop = false;
            this.gBoxProjBitmask.Text = "Bitmasks";
            this.gBoxProjBitmask.Enter += new System.EventHandler(this.gBoxProjBitmask_Enter);
            this.gBoxProjBitmask.Leave += new System.EventHandler(this.gBoxProjBitmask_Leave);
            // 
            // btnProBitmasksImport
            // 
            this.btnProBitmasksImport.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProBitmasksImport.Location = new System.Drawing.Point(165, 279);
            this.btnProBitmasksImport.Name = "btnProBitmasksImport";
            this.btnProBitmasksImport.Size = new System.Drawing.Size(75, 23);
            this.btnProBitmasksImport.TabIndex = 18;
            this.btnProBitmasksImport.Text = "Import...";
            this.toolTip1.SetToolTip(this.btnProBitmasksImport, "\"TODO Import units from another XML file\"");
            this.btnProBitmasksImport.UseVisualStyleBackColor = true;
            this.btnProBitmasksImport.Click += new System.EventHandler(this.btnProBitmasksImport_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(168, 461);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Sort Z-A";
            this.toolTip1.SetToolTip(this.button5, "\"Not yet Implemeneted\"");
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnProBitmasksCopy
            // 
            this.btnProBitmasksCopy.Enabled = false;
            this.btnProBitmasksCopy.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProBitmasksCopy.Location = new System.Drawing.Point(167, 164);
            this.btnProBitmasksCopy.Name = "btnProBitmasksCopy";
            this.btnProBitmasksCopy.Size = new System.Drawing.Size(75, 23);
            this.btnProBitmasksCopy.TabIndex = 5;
            this.btnProBitmasksCopy.Text = "Copy";
            this.btnProBitmasksCopy.UseVisualStyleBackColor = true;
            this.btnProBitmasksCopy.Click += new System.EventHandler(this.btnProBitmasksCopy_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Apply Filter";
            this.toolTip1.SetToolTip(this.button7, "\"Not yet Implemeneted\"");
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(168, 432);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Sort A-Z";
            this.toolTip1.SetToolTip(this.button8, "\"Not yet Implemeneted\"");
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnProBitmasksDelete
            // 
            this.btnProBitmasksDelete.Enabled = false;
            this.btnProBitmasksDelete.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProBitmasksDelete.Location = new System.Drawing.Point(167, 222);
            this.btnProBitmasksDelete.Name = "btnProBitmasksDelete";
            this.btnProBitmasksDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProBitmasksDelete.TabIndex = 4;
            this.btnProBitmasksDelete.Text = "Delete";
            this.btnProBitmasksDelete.UseVisualStyleBackColor = true;
            this.btnProBitmasksDelete.Click += new System.EventHandler(this.btnProBitmasksDelete_Click);
            // 
            // btnProBitmasksModify
            // 
            this.btnProBitmasksModify.Enabled = false;
            this.btnProBitmasksModify.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProBitmasksModify.Location = new System.Drawing.Point(168, 193);
            this.btnProBitmasksModify.Name = "btnProBitmasksModify";
            this.btnProBitmasksModify.Size = new System.Drawing.Size(75, 23);
            this.btnProBitmasksModify.TabIndex = 3;
            this.btnProBitmasksModify.Text = "Modify";
            this.btnProBitmasksModify.UseVisualStyleBackColor = true;
            this.btnProBitmasksModify.Click += new System.EventHandler(this.btnProBitmasksModify_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 432);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 24);
            this.textBox2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox2, "\"Not yet Implemeneted\"");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Filter";
            // 
            // btnProBitmasksCreate
            // 
            this.btnProBitmasksCreate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProBitmasksCreate.Location = new System.Drawing.Point(167, 135);
            this.btnProBitmasksCreate.Name = "btnProBitmasksCreate";
            this.btnProBitmasksCreate.Size = new System.Drawing.Size(75, 23);
            this.btnProBitmasksCreate.TabIndex = 2;
            this.btnProBitmasksCreate.Text = "Create";
            this.btnProBitmasksCreate.UseVisualStyleBackColor = true;
            this.btnProBitmasksCreate.Click += new System.EventHandler(this.btnProBitmasksCreate_Click);
            // 
            // lBoxProjBitmasks
            // 
            this.lBoxProjBitmasks.ContextMenuStrip = this.conMenuBitmasks;
            this.lBoxProjBitmasks.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxProjBitmasks.FormattingEnabled = true;
            this.lBoxProjBitmasks.HorizontalScrollbar = true;
            this.lBoxProjBitmasks.ItemHeight = 21;
            this.lBoxProjBitmasks.Location = new System.Drawing.Point(6, 27);
            this.lBoxProjBitmasks.Name = "lBoxProjBitmasks";
            this.lBoxProjBitmasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBoxProjBitmasks.Size = new System.Drawing.Size(155, 382);
            this.lBoxProjBitmasks.TabIndex = 1;
            this.lBoxProjBitmasks.SelectedIndexChanged += new System.EventHandler(this.lBoxProjBitmasks_SelectedIndexChanged);
            this.lBoxProjBitmasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxProjBitmasks_MouseDoubleClick);
            // 
            // conMenuBitmasks
            // 
            this.conMenuBitmasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyBitmasksMenuItem,
            this.modifyBitmasksMenuItem,
            this.deleteBitmasksMenuItem});
            this.conMenuBitmasks.Name = "conMenuUnits";
            this.conMenuBitmasks.Size = new System.Drawing.Size(126, 76);
            // 
            // copyBitmasksMenuItem
            // 
            this.copyBitmasksMenuItem.Name = "copyBitmasksMenuItem";
            this.copyBitmasksMenuItem.Size = new System.Drawing.Size(125, 24);
            this.copyBitmasksMenuItem.Text = "Copy";
            this.copyBitmasksMenuItem.Click += new System.EventHandler(this.copyBitmasksMenuItem_Click);
            // 
            // modifyBitmasksMenuItem
            // 
            this.modifyBitmasksMenuItem.Name = "modifyBitmasksMenuItem";
            this.modifyBitmasksMenuItem.Size = new System.Drawing.Size(125, 24);
            this.modifyBitmasksMenuItem.Text = "Modify";
            this.modifyBitmasksMenuItem.Click += new System.EventHandler(this.modifyBitmasksMenuItem_Click);
            // 
            // deleteBitmasksMenuItem
            // 
            this.deleteBitmasksMenuItem.Name = "deleteBitmasksMenuItem";
            this.deleteBitmasksMenuItem.Size = new System.Drawing.Size(125, 24);
            this.deleteBitmasksMenuItem.Text = "Delete";
            this.deleteBitmasksMenuItem.Click += new System.EventHandler(this.deleteBitmasksMenuItem_Click);
            // 
            // gBoxProjUnits
            // 
            this.gBoxProjUnits.Controls.Add(this.btnProjUnitsImport);
            this.gBoxProjUnits.Controls.Add(this.button1);
            this.gBoxProjUnits.Controls.Add(this.btnProUnitsCopy);
            this.gBoxProjUnits.Controls.Add(this.button2);
            this.gBoxProjUnits.Controls.Add(this.button3);
            this.gBoxProjUnits.Controls.Add(this.btnProUnitsDelete);
            this.gBoxProjUnits.Controls.Add(this.btnProUnitsModify);
            this.gBoxProjUnits.Controls.Add(this.textBox1);
            this.gBoxProjUnits.Controls.Add(this.label1);
            this.gBoxProjUnits.Controls.Add(this.btnProUnitsCreate);
            this.gBoxProjUnits.Controls.Add(this.lBoxProjUnits);
            this.gBoxProjUnits.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxProjUnits.Location = new System.Drawing.Point(6, 20);
            this.gBoxProjUnits.Name = "gBoxProjUnits";
            this.gBoxProjUnits.Size = new System.Drawing.Size(247, 499);
            this.gBoxProjUnits.TabIndex = 3;
            this.gBoxProjUnits.TabStop = false;
            this.gBoxProjUnits.Text = "Units";
            this.gBoxProjUnits.Enter += new System.EventHandler(this.gBoxProjUnits_Enter);
            this.gBoxProjUnits.Leave += new System.EventHandler(this.gBoxProjUnits_Leave);
            // 
            // btnProjUnitsImport
            // 
            this.btnProjUnitsImport.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjUnitsImport.Location = new System.Drawing.Point(165, 279);
            this.btnProjUnitsImport.Name = "btnProjUnitsImport";
            this.btnProjUnitsImport.Size = new System.Drawing.Size(75, 23);
            this.btnProjUnitsImport.TabIndex = 18;
            this.btnProjUnitsImport.Text = "Import...";
            this.toolTip1.SetToolTip(this.btnProjUnitsImport, "\"TODO Import units from another XML file\"");
            this.btnProjUnitsImport.UseVisualStyleBackColor = true;
            this.btnProjUnitsImport.Click += new System.EventHandler(this.btnProjUnitsImport_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sort Z-A";
            this.toolTip1.SetToolTip(this.button1, "\"Not yet Implemeneted\"");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProUnitsCopy
            // 
            this.btnProUnitsCopy.Enabled = false;
            this.btnProUnitsCopy.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUnitsCopy.Location = new System.Drawing.Point(167, 164);
            this.btnProUnitsCopy.Name = "btnProUnitsCopy";
            this.btnProUnitsCopy.Size = new System.Drawing.Size(75, 23);
            this.btnProUnitsCopy.TabIndex = 5;
            this.btnProUnitsCopy.Text = "Copy";
            this.btnProUnitsCopy.UseVisualStyleBackColor = true;
            this.btnProUnitsCopy.Click += new System.EventHandler(this.btnProUnitsCopy_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Apply Filter";
            this.toolTip1.SetToolTip(this.button2, "\"Not yet Implemeneted\"");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(168, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Sort A-Z";
            this.toolTip1.SetToolTip(this.button3, "\"Not yet Implemeneted\"");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnProUnitsDelete
            // 
            this.btnProUnitsDelete.Enabled = false;
            this.btnProUnitsDelete.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUnitsDelete.Location = new System.Drawing.Point(167, 222);
            this.btnProUnitsDelete.Name = "btnProUnitsDelete";
            this.btnProUnitsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProUnitsDelete.TabIndex = 4;
            this.btnProUnitsDelete.Text = "Delete";
            this.btnProUnitsDelete.UseVisualStyleBackColor = true;
            this.btnProUnitsDelete.Click += new System.EventHandler(this.btnProUnitsDelete_Click);
            // 
            // btnProUnitsModify
            // 
            this.btnProUnitsModify.Enabled = false;
            this.btnProUnitsModify.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUnitsModify.Location = new System.Drawing.Point(168, 193);
            this.btnProUnitsModify.Name = "btnProUnitsModify";
            this.btnProUnitsModify.Size = new System.Drawing.Size(75, 23);
            this.btnProUnitsModify.TabIndex = 3;
            this.btnProUnitsModify.Text = "Modify";
            this.btnProUnitsModify.UseVisualStyleBackColor = true;
            this.btnProUnitsModify.Click += new System.EventHandler(this.btnProUnitsModify_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 24);
            this.textBox1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox1, "\"Not yet Implemeneted\"");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter";
            // 
            // btnProUnitsCreate
            // 
            this.btnProUnitsCreate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUnitsCreate.Location = new System.Drawing.Point(167, 135);
            this.btnProUnitsCreate.Name = "btnProUnitsCreate";
            this.btnProUnitsCreate.Size = new System.Drawing.Size(75, 23);
            this.btnProUnitsCreate.TabIndex = 2;
            this.btnProUnitsCreate.Text = "Create";
            this.btnProUnitsCreate.UseVisualStyleBackColor = true;
            this.btnProUnitsCreate.Click += new System.EventHandler(this.btnProUnitsCreate_Click);
            // 
            // lBoxProjUnits
            // 
            this.lBoxProjUnits.ContextMenuStrip = this.conMenuUnits;
            this.lBoxProjUnits.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxProjUnits.FormattingEnabled = true;
            this.lBoxProjUnits.HorizontalScrollbar = true;
            this.lBoxProjUnits.ItemHeight = 21;
            this.lBoxProjUnits.Location = new System.Drawing.Point(6, 27);
            this.lBoxProjUnits.Name = "lBoxProjUnits";
            this.lBoxProjUnits.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBoxProjUnits.Size = new System.Drawing.Size(155, 382);
            this.lBoxProjUnits.TabIndex = 1;
            this.lBoxProjUnits.SelectedIndexChanged += new System.EventHandler(this.lBoxProjUnits_SelectedIndexChanged);
            this.lBoxProjUnits.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxProjUnits_MouseDoubleClick);
            // 
            // conMenuUnits
            // 
            this.conMenuUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyUnitsMenuItem,
            this.modifyUnitsMenuItem,
            this.deleteUnitsMenuItem});
            this.conMenuUnits.Name = "conMenuUnits";
            this.conMenuUnits.Size = new System.Drawing.Size(126, 76);
            // 
            // copyUnitsMenuItem
            // 
            this.copyUnitsMenuItem.Name = "copyUnitsMenuItem";
            this.copyUnitsMenuItem.Size = new System.Drawing.Size(125, 24);
            this.copyUnitsMenuItem.Text = "Copy";
            // 
            // modifyUnitsMenuItem
            // 
            this.modifyUnitsMenuItem.Name = "modifyUnitsMenuItem";
            this.modifyUnitsMenuItem.Size = new System.Drawing.Size(125, 24);
            this.modifyUnitsMenuItem.Text = "Modify";
            this.modifyUnitsMenuItem.Click += new System.EventHandler(this.modifyUnitsMenuItem_Click);
            // 
            // deleteUnitsMenuItem
            // 
            this.deleteUnitsMenuItem.Name = "deleteUnitsMenuItem";
            this.deleteUnitsMenuItem.Size = new System.Drawing.Size(125, 24);
            this.deleteUnitsMenuItem.Text = "Delete";
            this.deleteUnitsMenuItem.Click += new System.EventHandler(this.deleteUnitsMenuItem_Click);
            // 
            // tabProjectSettings
            // 
            this.tabProjectSettings.Location = new System.Drawing.Point(4, 25);
            this.tabProjectSettings.Name = "tabProjectSettings";
            this.tabProjectSettings.Size = new System.Drawing.Size(842, 526);
            this.tabProjectSettings.TabIndex = 5;
            this.tabProjectSettings.Text = "Project Settings";
            this.tabProjectSettings.UseVisualStyleBackColor = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(871, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.importToolStripMenuItem.Text = "Import...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.exitToolStripMenuItem.Text = "Exit..";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genEmbToolStripMenuItem,
            this.genHelpFileToolStripMenuItem,
            this.previewBitmasksToolStripMenuItem,
            this.previewEnumerationsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // genEmbToolStripMenuItem
            // 
            this.genEmbToolStripMenuItem.Name = "genEmbToolStripMenuItem";
            this.genEmbToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.genEmbToolStripMenuItem.Text = "Generate Emb Code";
            // 
            // genHelpFileToolStripMenuItem
            // 
            this.genHelpFileToolStripMenuItem.Name = "genHelpFileToolStripMenuItem";
            this.genHelpFileToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.genHelpFileToolStripMenuItem.Text = "Generate Help File (.chm)";
            // 
            // previewBitmasksToolStripMenuItem
            // 
            this.previewBitmasksToolStripMenuItem.CheckOnClick = true;
            this.previewBitmasksToolStripMenuItem.Name = "previewBitmasksToolStripMenuItem";
            this.previewBitmasksToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.previewBitmasksToolStripMenuItem.Text = "Preview Bitmasks";
            this.previewBitmasksToolStripMenuItem.Click += new System.EventHandler(this.previewBitmasksToolStripMenuItem_Click);
            // 
            // previewEnumerationsToolStripMenuItem
            // 
            this.previewEnumerationsToolStripMenuItem.CheckOnClick = true;
            this.previewEnumerationsToolStripMenuItem.Name = "previewEnumerationsToolStripMenuItem";
            this.previewEnumerationsToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.previewEnumerationsToolStripMenuItem.Text = "Preview Enumerations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(128, 24);
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
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bombardier Data Dictionary Builder User Interface Validator  (v 0.0.0.6)";
            this.tabControl1.ResumeLayout(false);
            this.tabWatchVariables.ResumeLayout(false);
            this.grpBoxWatchVarList.ResumeLayout(false);
            this.grpBoxWatchVarList.PerformLayout();
            this.conMenuWatchVarList.ResumeLayout(false);
            this.grpBoxWatchAttrs.ResumeLayout(false);
            this.grpBoxWatchAttrs.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabProjectDefinitions.ResumeLayout(false);
            this.gBoxProjBitmask.ResumeLayout(false);
            this.gBoxProjBitmask.PerformLayout();
            this.conMenuBitmasks.ResumeLayout(false);
            this.gBoxProjUnits.ResumeLayout(false);
            this.gBoxProjUnits.PerformLayout();
            this.conMenuUnits.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.Button btnWatchSortZtoA;
        private System.Windows.Forms.Button btnWatchSortAtoZ;
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
        private System.Windows.Forms.Button btnWatchHelpAvailable;
        private System.Windows.Forms.GroupBox gBoxProjUnits;
        private System.Windows.Forms.Button btnProUnitsCopy;
        private System.Windows.Forms.Button btnProUnitsDelete;
        private System.Windows.Forms.Button btnProUnitsModify;
        private System.Windows.Forms.Button btnProUnitsCreate;
        private System.Windows.Forms.ListBox lBoxProjUnits;
        private System.Windows.Forms.ContextMenuStrip conMenuUnits;
        private System.Windows.Forms.ToolStripMenuItem copyUnitsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyUnitsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUnitsMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWatchImport;
        private System.Windows.Forms.Button btnProjUnitsImport;
        private System.Windows.Forms.TabPage tabProjectSettings;
        private System.Windows.Forms.GroupBox gBoxProjBitmask;
        private System.Windows.Forms.Button btnProBitmasksImport;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnProBitmasksCopy;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnProBitmasksDelete;
        private System.Windows.Forms.Button btnProBitmasksModify;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnProBitmasksCreate;
        private System.Windows.Forms.ListBox lBoxProjBitmasks;
        private System.Windows.Forms.ContextMenuStrip conMenuBitmasks;
        private System.Windows.Forms.ToolStripMenuItem copyBitmasksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyBitmasksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBitmasksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewBitmasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewEnumerationsToolStripMenuItem;
    }
}

