using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormHelpText : Form
    {
        private iDDBHelpObject ddbHelpObject;

        public FormHelpText(iDDBHelpObject ddbHelpObject, String formTitle)
        {
            InitializeComponent();
            this.ddbHelpObject = ddbHelpObject;
            winFormHtmlEditor1.BodyHtml = ddbHelpObject.GetHelpText();
            this.Text = formTitle;
        }

        private FormHelpText()
        { }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // This saves the help text to the object
            ddbHelpObject.SaveHelpText(winFormHtmlEditor1.BodyHtml);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("HTML Help Text for ", this.Text))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}