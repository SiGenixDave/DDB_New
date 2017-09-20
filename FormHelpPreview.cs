using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormHelpPreview : Form
    {
        public FormHelpPreview()
        {
            InitializeComponent();
            webBrowser1.Navigate("about:blank");
        }

        public void UpdateForm(String helpText)
        {
            if (String.IsNullOrEmpty(helpText))
            {
                webBrowser1.Document.OpenNew(true);
                // Required to force the web browser control to clear
                webBrowser1.Document.Write("&nbsp;");
            }
            else
            {
                webBrowser1.Document.OpenNew(true);
                webBrowser1.Document.Write(helpText);
            }
        }
    }
}