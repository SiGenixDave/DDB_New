using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormTextEntry : Form
    {
        private iTextEntry textEntry;
        private String originalUnitText;

        public FormTextEntry(String formTitle, String message, iTextEntry textEntry)
        {
            InitializeComponent();
            this.Text = formTitle;
            lblMessage.Text = message;
            this.textEntry = textEntry;
        }

        public FormTextEntry(String formTitle, String message, String existingtext, iTextEntry textEntry)
        {
            InitializeComponent();
            this.Text = formTitle;
            lblMessage.Text = message;
            tBoxEntry.Text = existingtext;
            originalUnitText = existingtext;
            this.textEntry = textEntry;
        }

        private FormTextEntry()
        { }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Unit " + "\"" + originalUnitText + "\""))
            {
                Close();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            textEntry.ConfirmedTextEntry(tBoxEntry.Text);
            Close();
        }
    }
}