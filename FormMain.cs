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
            BitmaskVarList.Init();
            EnumVarList.Init();
            ProjectSettingsTest.Init();
            EventInfoTest.Init();
            InitWatchVars();
            InitEvents();
            InitProjectSettings();
            PopulateUnits(-1);
            PopulateBitmasks(-1);
            PopulateEnums(-1);
            PopulateProjectSettings();
            PopulateEventLists();
            //////////////////////////////////////////////////////////
            cBoxWatchList.SelectedIndex = 0;
            cBoxCommType.SelectedIndex = 0;
            cBoxCommType.SelectedIndex = 1;

        }

        private void PopulateUnits(int select)
        {
            UnitsTest[] units = UnitsTestList.GetUnits();
            cBoxWatchUnits.Items.Clear();
            lBoxProjUnits.Items.Clear();
            foreach (UnitsTest u in units)
            {
                cBoxWatchUnits.Items.Add(u);
                lBoxProjUnits.Items.Add(u);
            }

            if (select >= lBoxProjUnits.Items.Count)
            {
                lBoxProjUnits.SelectedIndex = lBoxProjUnits.Items.Count - 1;
            }
            else
            {
                lBoxProjUnits.SelectedIndex = select;
            }
        }

        private void PopulateBitmasks(int select)
        {
            BitmaskTest[] bitmasks = BitmaskVarList.GetBitmasks();
            lBoxProjBitmasks.Items.Clear();
            foreach (BitmaskTest b in bitmasks)
            {
                lBoxProjBitmasks.Items.Add(b);
            }

            if (select >= lBoxProjBitmasks.Items.Count)
            {
                lBoxProjBitmasks.SelectedIndex = lBoxProjBitmasks.Items.Count - 1;
            }
            else
            {
                lBoxProjBitmasks.SelectedIndex = select;
            }
        }

        private void PopulateEnums(int select)
        {
            EnumsTest[] enums = EnumVarList.GetEnums();
            lBoxProjEnums.Items.Clear();
            foreach (EnumsTest e in enums)
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
            URLTest[] urls = ProjectSettingsTest.GetURLs();

            foreach (URLTest u in urls)
            {
                dGridURL.Rows.Add(u.name, u.alias);
            }

            EventLogTest[] eventLogs = ProjectSettingsTest.GetEventLogs();

            foreach (EventLogTest e in eventLogs)
            {
                dGridEventLog.Rows.Add(e.embIndex, e.name);
            }

            int ff = ProjectSettingsTest.GetFunctionFlags();

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


    }
}