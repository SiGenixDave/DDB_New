using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain : Form
    {
        private FormBitmaskPreview formBitmaskPreview;
        private FormEnumPreview formEnumPreview;
        private FormEventPreview formEventPreview;
        private FormHelpPreview formHelpPreview;
        private FormVariablePreview formVariablePreview;
        private FormEventStructurePreview formEventStructurePreview;

        private FormMain()
        { }

        public FormMain(string[] args)
        {
            GlobalSettings.setCustomerUseOnly(false);
            if (args.Length == 1)
            {
                if (args[0] == "CUSTOMER_USE_ONLY")
                {
                    GlobalSettings.setCustomerUseOnly(true);
                }
            }

            InitializeComponent();
            if (GlobalSettings.getCustomerUseOnly())
            {
                this.Text += " -- (Customer Mode)";
                GlobalSettings.setCustomerUseOnly(true);
                importToolStripMenuItem.Enabled = false;
                genEmbToolStripMenuItem.Enabled = false;
                tabControl1.TabPages.Remove(tabProjectDefinitions);
                tabControl1.TabPages.Remove(tabProjectSettings);
            }

            CreatePreviews();

            ////////////////////////////////////////////////////////
            /// FOR TEST ONLY
            WatchVarList.Init();
            BitmaskList.Init();
            EnumList.Init();
            ProjectSettingsDB.Init();

            // Must be this order
            EventVariableList.Init();
            EventStructureList.Init();
            EventLogList.Init();
            EventList.Init();

            // Must be this order
            SelfTestVariableList.Init();
            SelfTestList.Init();
            SelfTestGroupList.Init();

            ucVE_WatchVar.setFormMain(this);
            ucVE_WatchVar.setBitmaskHelpPreview(formBitmaskPreview);
            ucVE_WatchVar.setEnumHelpPreview(formEnumPreview);

            InitProjectSettings();
        }

        public object[] GetUnits()
        {
            return ucEE_Units.GetItems();
        }

        public object[] GetBitmasks()
        {
            return ucEE_Bitmasks.GetItems();
        }

        public object[] GetEnums()
        {
            return ucEE_Enumerations.GetItems();
        }

        private void PopulateWatchVars()
        {
            WatchVariablesBusinessLogic wbl = new WatchVariablesBusinessLogic(this, formHelpPreview, ucVE_WatchVar);
            ucEE_WatchVariables.setBusinessLogic(wbl);
            ucEE_WatchVariables.AddListBoxItems(WatchVarList.GetWatchVars());
        }

        public void SetWatchGroupBoxEnable(Boolean enable)
        {
            grpBoxWatchAttrs.Enabled = enable;
        }

        public void SetWatchVarUserControlEnable(Boolean enable)
        {
            ucEE_WatchVariables.Enabled = enable;
        }

        public void SetWatchOtherTabsEnable(Boolean enable)
        {
            tabEvents.Enabled = enable;
            tabSelfTest.Enabled = enable;
            tabProjectDefinitions.Enabled = enable;
            tabProjectSettings.Enabled = enable;
        }


        private void PopulateEventLists()
        {
            PopulateEvents();
            PopulateEventStructures();
            PopulateEventVariables();
        }

        private void PopulateEvents()
        {
            EventBusinesssLogic ebl = new EventBusinesssLogic(this, formEventPreview, formHelpPreview);
            ucEE_Events.setBusinessLogic(ebl);
            ucEE_Events.AddListBoxItems(EventList.GetEvents());
        }

        public object[] GetEvents()
        {
            return ucEE_Events.GetItems();
        }

        private void PopulateEventStructures()
        {
            EventStructuresBusinessLogic ebl = new EventStructuresBusinessLogic(formEventStructurePreview);
            ucEE_EventStructures.setBusinessLogic(ebl);
            ucEE_EventStructures.AddListBoxItems(EventStructureList.GetEventStructures());
        }

        public object[] GetEventStructures()
        {
            return ucEE_EventStructures.GetItems();
        }

        private void PopulateEventVariables()
        {
            EventVariablesBusinessLogic ebl = new EventVariablesBusinessLogic(this, formVariablePreview, formHelpPreview, formBitmaskPreview, formEnumPreview);
            ucEE_EventVariables.setBusinessLogic(ebl);
            ucEE_EventVariables.AddListBoxItems(EventVariableList.GetEventVariables());
        }

        public object[] GetEventVariables()
        {
            return ucEE_EventVariables.GetItems();
        }

        private void PopulateSelfTestLists()
        {
            PopulateSelfTests();
        }

        private void PopulateSelfTests()
        {
            SelfTestsBusinessLogic sbl = new SelfTestsBusinessLogic(this, formHelpPreview);
            ucEE_SelfTest.setBusinessLogic(sbl);
            ucEE_SelfTest.AddListBoxItems(SelfTestList.GetObjects());

            SelfTestVariablesBusinessLogic svbl = new SelfTestVariablesBusinessLogic(this, formHelpPreview, formVariablePreview, formBitmaskPreview, formEnumPreview);
            ucEE_SelfTestVariables.setBusinessLogic(svbl);
            ucEE_SelfTestVariables.AddListBoxItems(SelfTestVariableList.GetSelfTestVariables());
        }

        private void btnEditSelfTestLists_Click(object sender, EventArgs e)
        {
            FormSelfTestListEditor formSTLE = new FormSelfTestListEditor();
            formSTLE.ShowDialog();
        }

        private void PopulateUnits()
        {
            UnitsBusinessLogic ubl = new UnitsBusinessLogic();

            ucEE_Units.setBusinessLogic(ubl);
            ucEE_Units.AddListBoxItems(UnitsList.GetUnits());
        }

        private void PopulateBitmasks()
        {
            BitmaskBusinesssLogic bbl = new BitmaskBusinesssLogic(formBitmaskPreview);
            ucEE_Bitmasks.setBusinessLogic(bbl);
            ucEE_Bitmasks.AddListBoxItems(BitmaskList.GetBitmasks());
        }

        private void PopulateEnums()
        {
            EnumerationsBusinessLogic ebl = new EnumerationsBusinessLogic(formEnumPreview);
            ucEE_Enumerations.setBusinessLogic(ebl);
            ucEE_Enumerations.AddListBoxItems(EnumList.GetEnums());
        }

        private void PopulateProjectSettings()
        {
            URLTarget[] urls = ProjectSettingsDB.GetURLs();

            foreach (URLTarget u in urls)
            {
                dGridURL.Rows.Add(u.name, u.alias);
            }

            EventLogDB[] eventLogs = EventLogList.GetEventLogs();

            foreach (EventLogDB e in eventLogs)
            {
                dGridEventLog.Rows.Add(e.embeddedId, e.name);
            }

            int ff = ProjectSettingsDB.GetFunctionFlags();

            for (int index = 0; index < 32; index++)
            {
                if (((1 << index) & ff) != 0)
                {
                    cListBoxFunctionFlags.SetItemChecked(index, true);
                }
            }

            tBoxProjSettingsWatchVarMax.Text = "40";
            tBoxProjSettingsSoftwareVersion.Text = "PROJVC0100";
            tBoxProjSettingsAppDataPath.Text = @"C:\PTU\Data";
        }

        private void btnExitDDB_Click(object sender, EventArgs e)
        {
            // TODO Are you sure that you want to Exit
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Are you sure...
            Close();
        }

        
        private void CreatePreviews()
        {
            formBitmaskPreview = new FormBitmaskPreview();
            formEnumPreview = new FormEnumPreview();
            formEventPreview = new FormEventPreview();
            formEventStructurePreview = new FormEventStructurePreview();
            formHelpPreview = new FormHelpPreview();
            formVariablePreview = new FormVariablePreview(this, formBitmaskPreview, formEnumPreview);
        }

        private void previewBitmasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewBitmasksToolStripMenuItem.Checked)
            {
                formBitmaskPreview.Visible = true;
                this.Focus();
            }
            else
            {
                formBitmaskPreview.Visible = false;
            }
        }

        private void previewEnumerationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewEnumerationsToolStripMenuItem.Checked)
            {
                formEnumPreview.Visible = true;
                this.Focus();
            }
            else
            {
                formEnumPreview.Visible = false;
            }
        }

        private void previewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewEventsToolStripMenuItem.Checked)
            {
                formEventPreview.Visible = true;
                this.Focus();
            }
            else
            {
                formEventPreview.Visible = false;
            }
        }

        private void previewEventStructuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewEventStructuresToolStripMenuItem.Checked)
            {
                formEventStructurePreview.Visible = true;
                this.Focus();
            }
            else
            {
                formEventStructurePreview.Visible = false;
            }
        }

        private void previewEventVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewEventVariablesToolStripMenuItem.Checked)
            {
                formVariablePreview.Visible = true;
                this.Focus();
            }
            else
            {
                formVariablePreview.Visible = false;
            }
        }

        private void previewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewHelpToolStripMenuItem.Checked)
            {
                formHelpPreview.Visible = true;
                this.Focus();
            }
            else
            {
                formHelpPreview.Visible = false;
            }
        }

        private void dGridURL_Leave(object sender, EventArgs e)
        {
            dGridURL.ClearSelection();
        }

        private void dGridEventLog_Leave(object sender, EventArgs e)
        {
            dGridEventLog.ClearSelection();
        }

        private void cListBoxFunctionFlags_Leave(object sender, EventArgs e)
        {
            cListBoxFunctionFlags.SelectedIndex = -1;
        }

        private void btnProjSettingsAcceptChanges_Click(object sender, EventArgs e)
        {
            SaveEventLogs();

            //TODO  Save All Project Settings and make other tabs visible
            tabWatchVariables.Enabled = true;
            tabEvents.Enabled = true;
            tabSelfTest.Enabled = true;
            tabProjectDefinitions.Enabled = true;
        }

        private void btnProjSettingsCancelChanges_Click(object sender, EventArgs e)
        {
            //TODO  Restore All Project Settings and make other tabs visible
            tabWatchVariables.Enabled = true;
            tabEvents.Enabled = true;
            tabSelfTest.Enabled = true;
            tabProjectDefinitions.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateWatchVars();
            PopulateUnits();
            PopulateBitmasks();
            PopulateEnums();
            PopulateProjectSettings();
            PopulateEventLists();
            PopulateSelfTestLists();
            //////////////////////////////////////////////////////////
            cBoxCommType.SelectedIndex = 0;
            cBoxNumStreamVars.SelectedIndex = 0;
            cBoxCommType.SelectedIndex = 1;
        }

        private void tabEvents_Leave(object sender, EventArgs e)
        {
            EventList.Update(ucEE_Events.GetItems());
            EventStructureList.Update(ucEE_EventStructures.GetItems());
            EventVariableList.Update(ucEE_EventVariables.GetItems());
        }

        private void dGridURL_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Right click row to add or delete URLs", this);
        }


    }
}