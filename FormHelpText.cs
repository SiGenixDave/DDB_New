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
            ddbHelpObject.SaveHelpText(winFormHtmlEditor1.BodyHtml);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}