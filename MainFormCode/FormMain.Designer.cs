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
            this.ucEE_WatchVariables = new DDB.UserControlEntityEditor();
            this.grpBoxWatchAttrs = new System.Windows.Forms.GroupBox();
            this.ucVE_WatchVar = new DDB.UserControlVariableEditor();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.ucEE_EventVariables = new DDB.UserControlEntityEditor();
            this.ucEE_EventStructures = new DDB.UserControlEntityEditor();
            this.ucEE_Events = new DDB.UserControlEntityEditor();
            this.tabSelfTest = new System.Windows.Forms.TabPage();
            this.btnEditSelfTestErrorMessages = new System.Windows.Forms.Button();
            this.btnEditSelfTestLists = new System.Windows.Forms.Button();
            this.ucEE_SelfTestVariables = new DDB.UserControlEntityEditor();
            this.ucEE_SelfTest = new DDB.UserControlEntityEditor();
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
            this.conMenuWatchVarList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWatchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genEmbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genDocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.previewBitmasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEnumerationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEventStructuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewEventVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExitDDB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabWatchVariables.SuspendLayout();
            this.grpBoxWatchAttrs.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabSelfTest.SuspendLayout();
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
            this.conMenuWatchVarList.SuspendLayout();
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
            this.tabWatchVariables.Controls.Add(this.ucEE_WatchVariables);
            this.tabWatchVariables.Controls.Add(this.grpBoxWatchAttrs);
            this.tabWatchVariables.Location = new System.Drawing.Point(4, 22);
            this.tabWatchVariables.Name = "tabWatchVariables";
            this.tabWatchVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabWatchVariables.Size = new System.Drawing.Size(842, 529);
            this.tabWatchVariables.TabIndex = 0;
            this.tabWatchVariables.Text = "Watch Variables";
            this.tabWatchVariables.UseVisualStyleBackColor = true;
            // 
            // ucEE_WatchVariables
            // 
            this.ucEE_WatchVariables.Location = new System.Drawing.Point(16, 23);
            this.ucEE_WatchVariables.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_WatchVariables.Name = "ucEE_WatchVariables";
            this.ucEE_WatchVariables.Size = new System.Drawing.Size(276, 500);
            this.ucEE_WatchVariables.TabIndex = 7;
            this.ucEE_WatchVariables.xGroupBoxTitle = "Watch Variables";
            this.ucEE_WatchVariables.xVisibleDispEmbComboBox = true;
            this.ucEE_WatchVariables.xVisibleLinksButton = false;
            // 
            // grpBoxWatchAttrs
            // 
            this.grpBoxWatchAttrs.Controls.Add(this.ucVE_WatchVar);
            this.grpBoxWatchAttrs.Enabled = false;
            this.grpBoxWatchAttrs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWatchAttrs.Location = new System.Drawing.Point(298, 30);
            this.grpBoxWatchAttrs.Name = "grpBoxWatchAttrs";
            this.grpBoxWatchAttrs.Size = new System.Drawing.Size(528, 440);
            this.grpBoxWatchAttrs.TabIndex = 6;
            this.grpBoxWatchAttrs.TabStop = false;
            this.grpBoxWatchAttrs.Text = "Attributes";
            // 
            // ucVE_WatchVar
            // 
            this.ucVE_WatchVar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucVE_WatchVar.Location = new System.Drawing.Point(9, 23);
            this.ucVE_WatchVar.Margin = new System.Windows.Forms.Padding(4);
            this.ucVE_WatchVar.Name = "ucVE_WatchVar";
            this.ucVE_WatchVar.Size = new System.Drawing.Size(528, 423);
            this.ucVE_WatchVar.TabIndex = 0;
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
            this.ucEE_EventVariables.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_EventVariables.Name = "ucEE_EventVariables";
            this.ucEE_EventVariables.Size = new System.Drawing.Size(276, 738);
            this.ucEE_EventVariables.TabIndex = 36;
            this.ucEE_EventVariables.xGroupBoxTitle = "Event Variables";
            this.ucEE_EventVariables.xVisibleDispEmbComboBox = true;
            // 
            // ucEE_EventStructures
            // 
            this.ucEE_EventStructures.Location = new System.Drawing.Point(288, 3);
            this.ucEE_EventStructures.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_EventStructures.Name = "ucEE_EventStructures";
            this.ucEE_EventStructures.Size = new System.Drawing.Size(276, 738);
            this.ucEE_EventStructures.TabIndex = 35;
            this.ucEE_EventStructures.xGroupBoxTitle = "Event Structures";
            this.ucEE_EventStructures.xVisibleModifyHelpTextButton = false;
            // 
            // ucEE_Events
            // 
            this.ucEE_Events.Location = new System.Drawing.Point(6, 4);
            this.ucEE_Events.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_Events.Name = "ucEE_Events";
            this.ucEE_Events.Size = new System.Drawing.Size(276, 738);
            this.ucEE_Events.TabIndex = 34;
            this.ucEE_Events.xGroupBoxTitle = "Events";
            this.ucEE_Events.xVisibleLinksButton = false;
            // 
            // tabSelfTest
            // 
            this.tabSelfTest.Controls.Add(this.btnEditSelfTestErrorMessages);
            this.tabSelfTest.Controls.Add(this.btnEditSelfTestLists);
            this.tabSelfTest.Controls.Add(this.ucEE_SelfTestVariables);
            this.tabSelfTest.Controls.Add(this.ucEE_SelfTest);
            this.tabSelfTest.Location = new System.Drawing.Point(4, 22);
            this.tabSelfTest.Name = "tabSelfTest";
            this.tabSelfTest.Size = new System.Drawing.Size(842, 529);
            this.tabSelfTest.TabIndex = 4;
            this.tabSelfTest.Text = "SelfTest";
            this.tabSelfTest.UseVisualStyleBackColor = true;
            // 
            // btnEditSelfTestErrorMessages
            // 
            this.btnEditSelfTestErrorMessages.Location = new System.Drawing.Point(640, 224);
            this.btnEditSelfTestErrorMessages.Name = "btnEditSelfTestErrorMessages";
            this.btnEditSelfTestErrorMessages.Size = new System.Drawing.Size(168, 42);
            this.btnEditSelfTestErrorMessages.TabIndex = 3;
            this.btnEditSelfTestErrorMessages.Text = "Edit Self Test Error Messages...";
            this.btnEditSelfTestErrorMessages.UseVisualStyleBackColor = true;
            // 
            // btnEditSelfTestLists
            // 
            this.btnEditSelfTestLists.Location = new System.Drawing.Point(640, 170);
            this.btnEditSelfTestLists.Name = "btnEditSelfTestLists";
            this.btnEditSelfTestLists.Size = new System.Drawing.Size(168, 36);
            this.btnEditSelfTestLists.TabIndex = 2;
            this.btnEditSelfTestLists.Text = "Edit Self Test Lists...";
            this.btnEditSelfTestLists.UseVisualStyleBackColor = true;
            this.btnEditSelfTestLists.Click += new System.EventHandler(this.btnEditSelfTestLists_Click);
            // 
            // ucEE_SelfTestVariables
            // 
            this.ucEE_SelfTestVariables.Location = new System.Drawing.Point(305, 48);
            this.ucEE_SelfTestVariables.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_SelfTestVariables.Name = "ucEE_SelfTestVariables";
            this.ucEE_SelfTestVariables.Size = new System.Drawing.Size(276, 738);
            this.ucEE_SelfTestVariables.TabIndex = 1;
            this.ucEE_SelfTestVariables.xGroupBoxTitle = "Self Test Variables";
            this.ucEE_SelfTestVariables.xVisibleDispEmbComboBox = true;
            // 
            // ucEE_SelfTest
            // 
            this.ucEE_SelfTest.Location = new System.Drawing.Point(23, 48);
            this.ucEE_SelfTest.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_SelfTest.Name = "ucEE_SelfTest";
            this.ucEE_SelfTest.Size = new System.Drawing.Size(276, 738);
            this.ucEE_SelfTest.TabIndex = 0;
            this.ucEE_SelfTest.xGroupBoxTitle = "Self Test";
            this.ucEE_SelfTest.xVisibleLinksButton = false;
            this.ucEE_SelfTest.xVisibleModifyHelpTextButton = false;
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
            this.ucEE_Enumerations.Location = new System.Drawing.Point(533, 7);
            this.ucEE_Enumerations.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_Enumerations.Name = "ucEE_Enumerations";
            this.ucEE_Enumerations.Size = new System.Drawing.Size(293, 421);
            this.ucEE_Enumerations.TabIndex = 23;
            this.ucEE_Enumerations.xGroupBoxTitle = "Enumerations";
            this.ucEE_Enumerations.xVisibleModifyHelpTextButton = false;
            // 
            // ucEE_Bitmasks
            // 
            this.ucEE_Bitmasks.Location = new System.Drawing.Point(266, 7);
            this.ucEE_Bitmasks.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_Bitmasks.Name = "ucEE_Bitmasks";
            this.ucEE_Bitmasks.Size = new System.Drawing.Size(300, 421);
            this.ucEE_Bitmasks.TabIndex = 22;
            this.ucEE_Bitmasks.xGroupBoxTitle = "Bitmasks";
            this.ucEE_Bitmasks.xVisibleModifyHelpTextButton = false;
            // 
            // ucEE_Units
            // 
            this.ucEE_Units.Location = new System.Drawing.Point(0, 6);
            this.ucEE_Units.Margin = new System.Windows.Forms.Padding(4);
            this.ucEE_Units.Name = "ucEE_Units";
            this.ucEE_Units.Size = new System.Drawing.Size(282, 512);
            this.ucEE_Units.TabIndex = 21;
            this.ucEE_Units.xGroupBoxTitle = "Units";
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
            this.tBoxPasswordLevel3.Location = new System.Drawing.Point(104, 79);
            this.tBoxPasswordLevel3.Name = "tBoxPasswordLevel3";
            this.tBoxPasswordLevel3.Size = new System.Drawing.Size(166, 21);
            this.tBoxPasswordLevel3.TabIndex = 5;
            this.tBoxPasswordLevel3.Text = "aeg3";
            // 
            // tBoxPasswordLevel2
            // 
            this.tBoxPasswordLevel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordLevel2.Location = new System.Drawing.Point(104, 49);
            this.tBoxPasswordLevel2.Name = "tBoxPasswordLevel2";
            this.tBoxPasswordLevel2.Size = new System.Drawing.Size(166, 21);
            this.tBoxPasswordLevel2.TabIndex = 4;
            this.tBoxPasswordLevel2.Text = "aeg2";
            // 
            // tBoxPasswordLevel1
            // 
            this.tBoxPasswordLevel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordLevel1.Location = new System.Drawing.Point(104, 20);
            this.tBoxPasswordLevel1.Name = "tBoxPasswordLevel1";
            this.tBoxPasswordLevel1.Size = new System.Drawing.Size(166, 21);
            this.tBoxPasswordLevel1.TabIndex = 3;
            this.tBoxPasswordLevel1.Text = "aeg1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(48, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Factory";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Engineering";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Maintenence";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 385);
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
            this.cListBoxFunctionFlags.Size = new System.Drawing.Size(400, 68);
            this.cListBoxFunctionFlags.TabIndex = 4;
            this.cListBoxFunctionFlags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cListBoxFunctionFlags_ItemCheck);
            this.cListBoxFunctionFlags.Leave += new System.EventHandler(this.cListBoxFunctionFlags_Leave);
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
            // 
            // modifyWatchMenuItem
            // 
            this.modifyWatchMenuItem.Name = "modifyWatchMenuItem";
            this.modifyWatchMenuItem.Size = new System.Drawing.Size(112, 22);
            this.modifyWatchMenuItem.Text = "Modify";
            // 
            // deleteWatchMenuItem
            // 
            this.deleteWatchMenuItem.Name = "deleteWatchMenuItem";
            this.deleteWatchMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteWatchMenuItem.Text = "Delete";
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
            this.exitToolStripMenuItem,
            this.newToolStripMenuItem});
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genEmbToolStripMenuItem,
            this.genHelpFileToolStripMenuItem,
            this.genDocsToolStripMenuItem,
            this.toolStripSeparator2,
            this.previewBitmasksToolStripMenuItem,
            this.previewEnumerationsToolStripMenuItem,
            this.previewEventsToolStripMenuItem,
            this.previewEventStructuresToolStripMenuItem,
            this.previewEventVariablesToolStripMenuItem,
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
            // genDocsToolStripMenuItem
            // 
            this.genDocsToolStripMenuItem.Name = "genDocsToolStripMenuItem";
            this.genDocsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.genDocsToolStripMenuItem.Text = "Generate Docs...";
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
            // previewEventStructuresToolStripMenuItem
            // 
            this.previewEventStructuresToolStripMenuItem.CheckOnClick = true;
            this.previewEventStructuresToolStripMenuItem.Name = "previewEventStructuresToolStripMenuItem";
            this.previewEventStructuresToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewEventStructuresToolStripMenuItem.Text = "Preview Event Structures";
            this.previewEventStructuresToolStripMenuItem.Click += new System.EventHandler(this.previewEventStructuresToolStripMenuItem_Click);
            // 
            // previewEventVariablesToolStripMenuItem
            // 
            this.previewEventVariablesToolStripMenuItem.CheckOnClick = true;
            this.previewEventVariablesToolStripMenuItem.Name = "previewEventVariablesToolStripMenuItem";
            this.previewEventVariablesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.previewEventVariablesToolStripMenuItem.Text = "Preview Event Variables";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 641);
            this.Controls.Add(this.btnExitDDB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 670);
            this.MinimumSize = new System.Drawing.Size(877, 670);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bombardier DDB (v 0.0.0.12)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabWatchVariables.ResumeLayout(false);
            this.grpBoxWatchAttrs.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tabSelfTest.ResumeLayout(false);
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
            this.conMenuWatchVarList.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpBoxWatchAttrs;
        private System.Windows.Forms.ContextMenuStrip conMenuWatchVarList;
        private System.Windows.Forms.ToolStripMenuItem copyWatchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyWatchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWatchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem genHelpFileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabSelfTest;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExitDDB;
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
        private System.Windows.Forms.ToolStripMenuItem previewEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewEventVariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewEventStructuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewHelpToolStripMenuItem;
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
        private UserControlEntityEditor ucEE_WatchVariables;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genDocsToolStripMenuItem;
        private UserControlEntityEditor ucEE_SelfTest;
        private UserControlEntityEditor ucEE_SelfTestVariables;
        private System.Windows.Forms.Button btnEditSelfTestLists;
        private System.Windows.Forms.Button btnEditSelfTestErrorMessages;
        private UserControlVariableEditor ucVE_WatchVar;
    }
}

