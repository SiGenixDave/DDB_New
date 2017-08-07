using System;
using System.Windows.Forms;


namespace DDB
{
    public partial class FormHelpText : Form
    {
        private iDDBHelpObject ddbHelpObject;

        public FormHelpText(iDDBHelpObject ddbHelpObject)
        {
            InitializeComponent();
            this.ddbHelpObject = ddbHelpObject;
         }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}