using System;
using System.Windows.Forms;
using DDB.Test;
using System.Drawing;

namespace DDB
{
    public partial class FormMain : Form
    {
        FormBitmaskPreview formBitmaskPreview = new FormBitmaskPreview();
        FormEnumPreview formEnumPreview = new FormEnumPreview();

        public FormMain()
        {
            InitializeComponent();

            ////////////////////////////////////////////////////////
            /// FOR TEST ONLY
            WatchVarList.Init();
            BitmaskVarList.Init();
            EnumVarList.Init();
            ProjectSettingsTest.Init();
            RefreshWatchVariableList(-1);
            PopulateUnits(-1);
            PopulateBitmasks(-1);
            PopulateEnums(-1);
            PopulateProjectSettings();
            //////////////////////////////////////////////////////////
            cBoxWatchList.SelectedIndex = 0;
            cBoxCommType.SelectedIndex = 0;
        }

        private void PopulateUnits(int select)
        {
            String[] units = UnitsTest.GetUnits();
            cBoxWatchUnits.Items.Clear();
            lBoxProjUnits.Items.Clear();
            foreach (String u in units)
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
            String[] bitmasks = BitmaskVarList.GetBitmasks();
            lBoxProjBitmasks.Items.Clear();
            foreach (String b in bitmasks)
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
            String[] enums = EnumVarList.GetNames();
            lBoxProjEnums.Items.Clear();
            foreach (String e in enums)
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
            }
        }

        private void previewBitmasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewBitmasksToolStripMenuItem.Checked)
            {
                formBitmaskPreview.Show();
            }
            else
            {
                formBitmaskPreview.Hide();
            }
        }

        private void previewEnumerationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previewEnumerationsToolStripMenuItem.Checked)
            {
                formEnumPreview.Show();
            }
            else
            {
                formEnumPreview.Hide();
            }
        }



    }
}