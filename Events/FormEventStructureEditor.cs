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
    public partial class FormEventStructureEditor : Form
    {
        EventStructureDB mEventStructure;
        
        public FormEventStructureEditor(EventStructureDB ev)
        {
            InitializeComponent();
            mEventStructure = ev;
            
            ucDS_AvailEventVars.SetOtherSelector(ucDS_UsedEventVars);
            ucDS_UsedEventVars.SetOtherSelector(ucDS_AvailEventVars);

            tBoxStructName.Text = mEventStructure.name;

            PopulateUsedVars();
            PopulateUnusedVars();

        }

        public EventStructureDB GetEditedEventStructure()
        {
            mEventStructure.name = tBoxStructName.Text;

            mEventStructure.variableList.Clear();

            foreach (EventVariableDB var in ucDS_UsedEventVars.GetItems())
            {
                mEventStructure.variableList.Add(var);
            }

            return mEventStructure;
        }

        private void PopulateUsedVars()
        {
            if (mEventStructure.variableList == null)
            {
                return;
            }

            foreach (EventVariableDB ev in mEventStructure.variableList)
            {
                ucDS_UsedEventVars.AddListBoxItem(ev);
            }
        }

        private void PopulateUnusedVars()
        {
            EventVariableDB[] allVars = EventVariableList.GetEventVariables();

            foreach (EventVariableDB var in EventVariableList.GetEventVariables())
            {
                if (mEventStructure.variableList != null)
                {
                    if (!mEventStructure.variableList.Contains(var))
                    {
                        ucDS_AvailEventVars.AddListBoxItem(var);
                    }
                }
                else
                {
                    ucDS_AvailEventVars.AddListBoxItem(var);
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Event Structure" , mEventStructure.name))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void tBoxStructName_TextChanged(object sender, EventArgs e)
        {
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxStructName.Text.Length > 0) && (tBoxStructName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxStructName.Text, tBoxStructName.Font);

                tBoxStructName.Width = size.Width + 10;
                tBoxStructName.Height = size.Height;
            }
        }

    }

}
