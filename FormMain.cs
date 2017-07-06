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
        }

    }
}