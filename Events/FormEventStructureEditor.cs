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
        EventStructureTest evt;
        public FormEventStructureEditor(EventStructureTest ev)
        {
            InitializeComponent();
            evt = ev;

            tBoxStructName.Text = ev.name;

            PopulateUsedVars();
            PopulateUnusedVars();

        }

        public EventStructureTest GetEditedEventStructure()
        {
            evt.name = tBoxStructName.Text;

            // TODO get all of the vars from the Used list and add their indexes

            return evt;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }


        public void MoveItem(int direction)
        {
            // Checking selected item
            //if (lBoxUsedVars.SelectedItem == null || lBoxUsedVars.SelectedIndex < 0)
            //    return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lBoxUsedVars.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lBoxUsedVars.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lBoxUsedVars.SelectedItem;

            // Removing removable element
            lBoxUsedVars.Items.Remove(selected);
            // Insert it in new position
            lBoxUsedVars.Items.Insert(newIndex, selected);
            // Restore selection
            lBoxUsedVars.SetSelected(newIndex, true);
        }

        private void lBoxUsedVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxUsedVars.SelectedIndices.Count == 1)
            {
                if (lBoxUsedVars.SelectedIndex == 0)
                {
                    btnMoveUp.Enabled = false;
                    btnMoveDown.Enabled = true;
                }
                else if (lBoxUsedVars.SelectedIndex == lBoxUsedVars.Items.Count - 1)
                {
                    btnMoveUp.Enabled = true;
                    btnMoveDown.Enabled = false;
                }
                else
                {
                    btnMoveUp.Enabled = true;
                    btnMoveDown.Enabled = true;
                }

            }
            else
            {
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;
            }

        }

        private void lBoxUsedVars_Enter(object sender, EventArgs e)
        {
            lBoxAvailableVars.SelectedIndex = -1;
        }

        private void lBoxAvailableVars_Enter(object sender, EventArgs e)
        {
            lBoxUsedVars.SelectedIndex = -1;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MoveHorizontal(lBoxUsedVars, lBoxAvailableVars);
            MoveHorizontal(lBoxAvailableVars, lBoxUsedVars);
        }

        private void MoveHorizontal(ListBox from, ListBox to)
        {
            int index = 0;
            List<String> selIndices = new List<String>();
            while (index < from.SelectedIndices.Count)
            {
                to.Items.Add(from.Items[from.SelectedIndices[index]]);
                selIndices.Add(from.Items[from.SelectedIndices[index]].ToString());
                index++;
            }
            index = 0;
            while (index < selIndices.Count)
            {
                from.Items.Remove(selIndices[index]);
                index++;
            }

        }

        private void lBoxUsedVars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MoveHorizontal(lBoxUsedVars, lBoxAvailableVars);
        }

        private void lBoxAvailableVars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MoveHorizontal(lBoxAvailableVars, lBoxUsedVars);
        }

        private void PopulateUsedVars()
        {
            int index = 0;
            while (index < evt.varId.Count)
            {
                EventVariableTest ev = EventInfoTest.GetEventVariable(evt.varId[index]);
                lBoxUsedVars.Items.Add(ev.dispName);
                index++;
            }

        }

        private void PopulateUnusedVars()
        {
            EventVariableTest []allVars = EventInfoTest.GetEventVariables();

            int index = 0;
            while (index < allVars.Length)
            {
                if (!evt.varId.Contains(index))
                {
                    EventVariableTest ev = EventInfoTest.GetEventVariable(index);
                    lBoxAvailableVars.Items.Add(ev.dispName);
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
            if (Cancel.Query("Event Structure" , evt.name))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

    }
}
