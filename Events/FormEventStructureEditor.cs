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

            int index = 0;
            mEventStructure.variableListFKey.Clear();

            object[] usedVars = ucDS_UsedEventVars.GetItems();
            while (index < usedVars.Length)
            {
                EventVariableDB evVar = (EventVariableDB)usedVars[index];
                mEventStructure.variableListFKey.Add(evVar.fKey);
                index++;
            }

            return mEventStructure;
        }

         private void PopulateUsedVars()
        {
            int index = 0;

            if (mEventStructure.variableListFKey == null)
            {
                return;
            }

            while (index < mEventStructure.variableListFKey.Count)
            {
                EventVariableDB ev = EventVariableList.GetEventObject(mEventStructure.variableListFKey[index]);
                ucDS_UsedEventVars.AddListBoxItem(ev);
                index++;
            }
        }

        private void PopulateUnusedVars()
        {
            EventVariableDB[] allVars = EventVariableList.GetEventVariables();

            int index = 0;
            while (index < allVars.Length)
            {
                if (mEventStructure.variableListFKey != null)
                {
                    if (!mEventStructure.variableListFKey.Contains(index))
                    {
                        EventVariableDB ev = EventVariableList.GetEventObject(index);
                        ucDS_AvailEventVars.AddListBoxItem(ev);
                    }
                }
                else
                {
                    EventVariableDB ev = EventVariableList.GetEventObject(index);
                    ucDS_AvailEventVars.AddListBoxItem(ev);
                }
                index++;
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
