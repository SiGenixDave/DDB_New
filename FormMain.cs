using System;
using System.Windows.Forms;
using DDB.Test;
using System.Drawing;

namespace DDB
{
    public partial class FormMain : Form
    {
        FormBitmaskPreview formBitmaskPreview = new FormBitmaskPreview();

        public FormMain()
        {
            InitializeComponent();

            ////////////////////////////////////////////////////////
            /// FOR TEST ONLY
            WatchVarList.Init();
            BitmaskVarList.Init();
            RefreshWatchVariableList(-1);
            PopulateUnits(-1);
            PopulateBitmasks(-1);
            //////////////////////////////////////////////////////////
            cBoxWatchList.SelectedIndex = 0;
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

    }
}