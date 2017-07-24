using System;
using System.Windows.Forms;
using DDB.Test;

namespace DDB
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            ////////////////////////////////////////////////////////
            /// FOR TEST ONLY
            WatchVarList.Init();
            BitmaskVarList.Init();
            RefreshWatchVariableList(-1);
            PopulateUnits();
            PopulateBitmasks();
            //////////////////////////////////////////////////////////
            cBoxWatchList.SelectedIndex = 0;
        }

        private void PopulateUnits()
        {
            String[] units = UnitsTest.GetUnits();
            cBoxWatchUnits.Items.Clear();
            lBoxProjUnits.Items.Clear();
            foreach (String u in units)
            {
                cBoxWatchUnits.Items.Add(u);
                lBoxProjUnits.Items.Add(u);
            }
        }

        private void PopulateBitmasks()
        {
            String[] bitmasks = BitmaskVarList.GetBitmasks();
            lBoxProjBitmasks.Items.Clear();
            foreach (String b in bitmasks)
            {
                lBoxProjBitmasks.Items.Add(b);
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

    }
}