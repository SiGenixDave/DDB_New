using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain
    {
        private void InitEvents()
        {
            if (GlobalSettings.getCustomerUseOnly())
            {
                // remove the double click so the customer can't edit a watch variable
                this.lBoxWatchVariables.MouseDoubleClick -= this.lBoxWatchVariables_MouseDoubleClick;
            }
        }

        private void PopulateEventLists()
        {
            foreach (EventTest e in EventInfoTest.GetEvents())
            {
                lBoxEvents.Items.Add(e.name);
            }
            foreach (EventStructureTest e in EventInfoTest.GetEventStructures())
            {
                lBoxEventStructures.Items.Add(e.name);
            }
            foreach (EventVariableTest e in EventInfoTest.GetEventVariables())
            {
                lBoxEventVars.Items.Add(e.dispName);
            }        
        }

        private void btnEventCreate_Click(object sender, EventArgs e)
        {
        }

        private void btnEventCopy_Click(object sender, EventArgs e)
        {
        }

        private void btnEventModify_Click(object sender, EventArgs e)
        {
            ModifyEvent();
        }

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnEventImport_Click(object sender, EventArgs e)
        {
        }

        private void lBoxEvents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void lBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxEvents.SelectedIndices.Count == 0)
            {
                btnEventModify.Enabled = false;
                btnEventCopy.Enabled = false;
                btnEventDelete.Enabled = false;
            }
            else if (lBoxEvents.SelectedIndices.Count == 1)
            {
                // TODO conMenuEnums.Items[1].Enabled = true;

                btnEventModify.Enabled = true;
                btnEventCopy.Enabled = true;
                btnEventDelete.Enabled = true;

                //TODO formEnumPreview.UpdateForm(EnumVarList.GetVar(lBoxProjEnums.SelectedIndex));
            }
            else
            {
                // Disable the "Modify" in context menu
                //TODO conMenuEnums.Items[1].Enabled = false;

                btnEventModify.Enabled = false;
                btnEventCopy.Enabled = true;
                btnEventDelete.Enabled = true;
            }
        }

        private void btnEventStructureCreate_Click(object sender, EventArgs e)
        {
        }

        private void btnEventStructureCopy_Click(object sender, EventArgs e)
        {
        }

        private void btnEventStructureModify_Click(object sender, EventArgs e)
        {
        }

        private void btnEventStructureDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnEventStructureImport_Click(object sender, EventArgs e)
        {
        }

        private void lBoxEventStructures_DoubleClick(object sender, EventArgs e)
        {
        }

        private void lBoxEventStructures_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lBoxEventVars_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lBoxEventVars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEventVarCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnEventVarCopy_Click(object sender, EventArgs e)
        {

        }

        private void btnEventVarModify_Click(object sender, EventArgs e)
        {

        }

        private void btnEventVarDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEventVarImport_Click(object sender, EventArgs e)
        {

        }


        private void CreateEvent()
        {

        }

        private void ModifyEvent()
        {
            EventTest e = EventInfoTest.GetEvent(lBoxEvents.SelectedItem.ToString());
            FormEventEditor frmEvEdit = new FormEventEditor(e);
            frmEvEdit.ShowDialog();

        }

        private void CopyEvent()
        {

        }

        private void DeleteEvent()
        {

        }
    }
}