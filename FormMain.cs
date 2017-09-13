using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace DDB
{
    public partial class FormMain : Form
    {
        private FormBitmaskPreview formBitmaskPreview;
        private FormEnumPreview formEnumPreview;
        private FormEventPreview formEventPreview;
        private FormHelpPreview formHelpPreview;
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
            EventList.Init();
            EventStructureList.Init();
            EventVariableList.Init();
            EventLogList.Init();
            InitProjectSettings();
        }

        private void PopulateUnits()
        {
            UnitsBusinessLogic ubl = new UnitsBusinessLogic();

            ucEE_Units.setBusinessLogic(ubl);
            ucEE_Units.AddListBoxItems(UnitsList.GetUnits());
        }

        private void PopulateBitmasks()
        {
            BitmasksBusinessLogic bbl = new BitmasksBusinessLogic(formBitmaskPreview);
            ucEE_Bitmasks.setBusinessLogic(bbl);
            ucEE_Bitmasks.AddListBoxItems(BitmaskList.GetBitmasks());
        }

        private void PopulateEnums()
        {
            EnumsBusinessLogic ebl = new EnumsBusinessLogic(formEnumPreview);
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Reload any information based on the current tab selected
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    // Tab Watch
                    if (cBoxWatchScaleType.SelectedItem != null)
                    {
                        if (cBoxWatchScaleType.SelectedItem.ToString() == "Bitmask")
                        {
                            int savedIndex = cBoxWatchUnits.SelectedIndex;
                            LoadBitmasksIntoComboBox(true);
                            cBoxWatchUnits.SelectedIndex = savedIndex;
                        }
                        else if (cBoxWatchScaleType.SelectedItem.ToString() == "Enumeration")
                        {
                            int savedIndex = cBoxWatchUnits.SelectedIndex;
                            LoadEnumsIntoComboBox(true);
                            cBoxWatchUnits.SelectedIndex = savedIndex;
                        }
                    }
                    break;

                case 1:
                    // Tab Event
                    break;

                case 2:
                    // Tab Selftest
                    break;

                case 3:
                    // Tab Project Definitions
                    break;

                case 4:
                    // Tab Project Settings
                    dGridURL.ClearSelection();
                    dGridEventLog.ClearSelection();
                    break;
            }
        }

        private void CreatePreviews()
        {
            formBitmaskPreview = new FormBitmaskPreview();
            formEnumPreview = new FormEnumPreview();
            formEventPreview = new FormEventPreview();
            formEventStructurePreview = new FormEventStructurePreview();
            formHelpPreview = new FormHelpPreview();
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


    }
}