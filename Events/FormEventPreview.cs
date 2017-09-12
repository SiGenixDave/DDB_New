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
        }

        public void UpdateForm(EventDB e)
        {
#if TODO
            if (e == null)
            {
                lblEventName.Text = "";
                lblCdefineName.Text = "";
                lblEventStructure.Text = "";
                lblEventLog.Text = "";
            }
            else
            {
                lblEventName.Text = e.name;
                lblCdefineName.Text = e.embeddedName;
                lblEventStructure.Text = EventList.GetEventStructureName(e.structFKey);
                lblEventLog.Text = (e.logFKey == 0) ? "Propulsion" : "Engineering";
            }
#endif
        }
    }
}
