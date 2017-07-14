using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormHelpText : Form
    {
        iDDBHelpObject ddbHelpObject;
        
        public FormHelpText(iDDBHelpObject ddbHelpObject)
        {
            InitializeComponent();
            this.ddbHelpObject = ddbHelpObject;
            textBox1.Text = ddbHelpObject.GetHelpText();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ddbHelpObject.SaveHelpText(textBox1.Text);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
