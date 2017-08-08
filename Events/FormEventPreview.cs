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
    public partial class FormEventPreview : Form
    {
        public FormEventPreview()
        {
            InitializeComponent();
            webBrowser1.Navigate("about:blank");
        }

        public void UpdateForm(EventTest e)
        {
            if (e == null)
            {
                lblEventName.Text = "";
                lblCdefineName.Text = "";
                lblEventStructure.Text = "";
                lblEventLog.Text = "";
                webBrowser1.Document.OpenNew(true);
                // Required to force the web browser control to clear
                webBrowser1.Document.Write("&nbsp;");
            }
            else
            {
                lblEventName.Text = e.name;
                lblCdefineName.Text = e.cDefineName;
                lblEventStructure.Text = EventInfoTest.GetEventStructures()[e.structId].name;
                lblEventLog.Text = (e.logId == 0) ? "Propulsion" : "Engineering";

                webBrowser1.Document.OpenNew(true);
                webBrowser1.Document.Write(e.helpText);
            }
        }
    }
}
