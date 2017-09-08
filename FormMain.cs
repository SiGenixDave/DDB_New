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

        private FormMain()
        { }

        public FormMain(string[] args)
        {
            InitializeComponent();

            GlobalSettings.setCustomerUseOnly(false);
            if (args.Length == 1)
            {
                if (args[0] == "CUSTOMER_USE_ONLY")
                {
                    this.Text += " -- (Customer Mode)";
                    GlobalSettings.setCustomerUseOnly(true);
                    importToolStripMenuItem.Enabled = false;
                    genEmbToolStripMenuItem.Enabled = false;
                    tabControl1.TabPages.Remove(tabProjectDefinitions);
                    tabControl1.TabPages.Remove(tabProjectSettings);
                }
            }

            CreatePreviews();


            ////////////////////////////////////////////////////////
            /// FOR TEST ONLY
            WatchVarList.Init();
            BitmaskList.Init();
            EnumList.Init();
            ProjectSettingsDB.Init();
            EventList.Init();
            InitWatchVars();
            InitEvents();
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

        private void PopulateEnums(int select)
        {
            Enums[] enums = EnumList.GetEnums();
            lBoxProjEnums.Items.Clear();
            foreach (Enums e in enums)
            {
                lBoxProjEnums.Items.Add(e);
            }

            if (select >= lBoxProjEnums.Items.Count)
            {
                lBoxProjEnums.SelectedIndex = lBoxProjEnums.Items.Count - 1;
            }
            else
            {
                lBoxProjEnums.SelectedIndex = select;
            }
        }

        private void PopulateProjectSettings()
        {
            URLTarget[] urls = ProjectSettingsDB.GetURLs();

            foreach (URLTarget u in urls)
            {
                dGridURL.Rows.Add(u.name, u.alias);
            }

            EventLog[] eventLogs = ProjectSettingsDB.GetEventLogs();

            foreach (EventLog e in eventLogs)
            {
                dGridEventLog.Rows.Add(e.embIndex, e.name);
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


        // Make false whenever any project settings are made by the user. Make true when user clicks
        // project settings accepted button
        Boolean projSettingsAccepted = true;
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

                    //TODO Remove after test; code must detect when changes are made to project settings 
                    projSettingsAccepted = false;
                    tabWatchVariables.Enabled = false;
                    tabEvents.Enabled = false;
                    tabSelfTest.Enabled = false;
                    tabProjectDefinitions.Enabled = false;
                    break;
            }
        }

        private void CreatePreviews()
        {
            formBitmaskPreview = new FormBitmaskPreview();
            formEnumPreview = new FormEnumPreview();
            formEventPreview = new FormEventPreview();
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

        // Handle <Escape> and <CR> keys
        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (grpBoxWatchAttrs.Enabled)
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        btnWatchAccept_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.Escape)
                    {
                        btnWatchCancel_Click(null, null);
                    }
                }
            }
        }

        private void btnProjSettingsAcceptChanges_Click(object sender, EventArgs e)
        {
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
            if (this.Visible)
            {
                PopulateUnits();
                PopulateBitmasks();
            }
            PopulateEnums(-1);
            PopulateProjectSettings();
            PopulateEventLists();
            //////////////////////////////////////////////////////////
            cBoxWatchList.SelectedIndex = 0;
            cBoxCommType.SelectedIndex = 0;
            cBoxNumStreamVars.SelectedIndex = 0;
            cBoxCommType.SelectedIndex = 1;

        }


    }
}