using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            ////////////////////////////////////////////////////////
            /// FOR TEST ONLY
            WatchVarList.Init(this);
            RefreshWatchVariableList(-1);
            //////////////////////////////////////////////////////////
            cBoxWatchList.SelectedIndex = 0;

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


    }
}