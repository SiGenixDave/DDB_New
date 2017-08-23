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

        public void UpdateForm(EventTest e)
        {
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
                lblCdefineName.Text = e.cDefineName;
                lblEventStructure.Text = EventInfoTest.GetEventStructures()[e.structId].name;
                lblEventLog.Text = (e.logId == 0) ? "Propulsion" : "Engineering";

            }

        }
    }
}
