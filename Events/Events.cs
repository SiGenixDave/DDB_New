using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain
    {
        private void InitEvents()
        {
            if (GlobalSettings.getCustomerUseOnly())
            {
                btnEventCreate.Enabled = false;
                btnEventImport.Enabled = false;
                lBoxEvents.MouseDoubleClick -= lBoxEvents_MouseDoubleClick;
                lBoxEventStructures.MouseDoubleClick -= lBoxEventStructures_MouseDoubleClick;
                lBoxEventVars.MouseDoubleClick -= lBoxEventVars_MouseDoubleClick;
            }
        }

        private void PopulateEventLists()
        {
            PopulateEvents();
            PopulateEventStructures();
            PopulateEventVariables();
        }

        private void PopulateEvents()
        {
            lBoxEvents.Items.Clear();
            foreach (EventTest e in EventInfoTest.GetEvents())
            {
                lBoxEvents.Items.Add(e);
            }
        }

        private void PopulateEventStructures()
        {
            lBoxEventStructures.Items.Clear();
            foreach (EventStructureTest e in EventInfoTest.GetEventStructures())
            {
                lBoxEventStructures.Items.Add(e);
            }
        }

        private void PopulateEventVariables()
        {
            lBoxEventVars.Items.Clear();
            foreach (EventVariableTest e in EventInfoTest.GetEventVariables())
            {
                lBoxEventVars.Items.Add(e);
            }
        }

        private void btnEventCreate_Click(object sender, EventArgs e)
        {
            CreateEvent();
        }

        private void btnEventCopy_Click(object sender, EventArgs e)
        {
            CopyEvent();
        }

        private void btnEventModify_Click(object sender, EventArgs e)
        {
            ModifyEvent();
        }

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent();
        }

        private void btnEventImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Events");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        private void lBoxEvents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyEvent();
        }

        private void lBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxEvents.SelectedIndices.Count == 0)
            {
                btnEventModify.Enabled = false;
                btnEventCopy.Enabled = false;
                btnEventDelete.Enabled = false;
                btnEventModifyHelpText.Enabled = false;

                formEventPreview.UpdateForm(null);
                formHelpPreview.UpdateForm(null);
            }
            else if (lBoxEvents.SelectedIndices.Count == 1)
            {
                conMenuEventLogs.Items[1].Enabled = true;
                btnEventModifyHelpText.Enabled = true;
                if (!GlobalSettings.getCustomerUseOnly())
                {
                    btnEventModify.Enabled = true;
                    btnEventCopy.Enabled = true;
                    btnEventDelete.Enabled = true;
                }
                EventTest ev = (EventTest)lBoxEvents.SelectedItem;
                formEventPreview.UpdateForm(ev);
                formHelpPreview.UpdateForm(ev.helpText);

                lBoxEvents.Focus();
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuEventLogs.Items[1].Enabled = false;

                btnEventModify.Enabled = false;
                btnEventModifyHelpText.Enabled = false;
                if (!GlobalSettings.getCustomerUseOnly())
                {
                    btnEventCopy.Enabled = true;
                    btnEventDelete.Enabled = true;
                }
                formEventPreview.UpdateForm(null);
                formHelpPreview.UpdateForm(null);
            }

        }

        private void copyEventLogMenuItem_Click(object sender, EventArgs e)
        {
            CopyEvent();
        }

        private void modifyEventLogMenuItem_Click(object sender, EventArgs e)
        {
            ModifyEvent();
        }

        private void deleteEventLogMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEvent();
        }

        private void btnEventModifyHelpText_Click(object sender, EventArgs e)
        {
            EventTest ev = (EventTest)lBoxEvents.SelectedItem;
            FormHelpText fh = new FormHelpText(ev, "Event \"" + ev.name + "\"");
            fh.ShowDialog();

            formHelpPreview.UpdateForm(ev.helpText);
        }

        /////////////////////////////////

        private void btnEventStructureCreate_Click(object sender, EventArgs e)
        {
            CreateEventStructure();
        }

        private void btnEventStructureCopy_Click(object sender, EventArgs e)
        {
            CopyEventStructure();
        }

        private void btnEventStructureModify_Click(object sender, EventArgs e)
        {
            ModifyEventStructure();
        }

        private void btnEventStructureDelete_Click(object sender, EventArgs e)
        {
            DeleteEventStructure();
        }

        private void btnEventStructureImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Event Structures");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        private void lBoxEventStructures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxEventStructures.SelectedIndices.Count == 0)
            {
                btnEventStructureModify.Enabled = false;
                btnEventStructureCopy.Enabled = false;
                btnEventStructureDelete.Enabled = false;

                formEventPreview.UpdateForm(null);
            }
            else if (lBoxEventStructures.SelectedIndices.Count == 1)
            {
                conMenuEventStructures.Items[1].Enabled = true;

                btnEventStructureModify.Enabled = true;
                btnEventStructureCopy.Enabled = true;
                btnEventStructureDelete.Enabled = true;

                //TODO formEventStructurePreview.UpdateForm(EventInfoTest.GetEvent(lBoxEvents.SelectedIndex));

                lBoxEventStructures.Focus();
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuEventStructures.Items[1].Enabled = false;

                btnEventStructureModify.Enabled = false;
                btnEventStructureCopy.Enabled = true;
                btnEventStructureDelete.Enabled = true;
            }
        }

        private void lBoxEventStructures_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyEventStructure();
        }

        private void copyEventStrMenuItem_Click(object sender, EventArgs e)
        {
            CopyEventStructure();
        }

        private void modifyEventStrMenuItem_Click(object sender, EventArgs e)
        {
            ModifyEventStructure();
        }

        private void deleteEventStrMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEventStructure();
        }

        private void lBoxEventVars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyEventVariable();
        }

        private void lBoxEventVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxEventVars.SelectedIndices.Count == 0)
            {
                btnEventVarModify.Enabled = false;
                btnEventVarCopy.Enabled = false;
                btnEventVarDelete.Enabled = false;

                //TODO formEventPreview.UpdateForm(null);
            }
            else if (lBoxEventVars.SelectedIndices.Count == 1)
            {
                //TODO conMenuEventVariables.Items[1].Enabled = true;

                btnEventVarModify.Enabled = true;
                btnEventVarCopy.Enabled = true;
                btnEventVarDelete.Enabled = true;

                //TODO formEventVariablePreview.UpdateForm(EventInfoTest.GetEvent(lBoxEvents.SelectedIndex));

                lBoxEventVars.Focus();

            }
            else
            {
                // Disable the "Modify" in context menu
                //TODO conMenuEventVariables.Items[1].Enabled = false;

                btnEventVarModify.Enabled = false;
                btnEventVarCopy.Enabled = true;
                btnEventVarDelete.Enabled = true;
            }

        }

        private void btnEventVarCreate_Click(object sender, EventArgs e)
        {
            CreateEventVariable();
        }

        private void btnEventVarCopy_Click(object sender, EventArgs e)
        {
            CopyEventVariable();
        }

        private void btnEventVarModify_Click(object sender, EventArgs e)
        {
            ModifyEventVariable();
        }

        private void btnEventVarDelete_Click(object sender, EventArgs e)
        {
            DeleteEventVariable();
        }

        private void btnEventVarImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Event Variables");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        private void gBoxEvents_Enter(object sender, EventArgs e)
        {
            formEventPreview.UpdateForm(null);
            formHelpPreview.UpdateForm(null);
        }

        private void gBoxEvents_Leave(object sender, EventArgs e)
        {
            lBoxEvents.SelectedIndex = -1;
        }


        private void gBoxEventStructures_Enter(object sender, EventArgs e)
        {
            // TODO formEventStructurePreview.UpdateForm(null);
        }

        private void gBoxEventStructures_Leave(object sender, EventArgs e)
        {
            lBoxEventStructures.SelectedIndex = -1;
        }

        private void gBoxEventVariables_Enter(object sender, EventArgs e)
        {
            //TODO formEventVariablePreview.UpdateForm(null);
        }

        private void gBoxEventVariables_Leave(object sender, EventArgs e)
        {
            lBoxEventVars.SelectedIndex = -1;
        }

        private void CreateEvent()
        {
            EventTest e = new EventTest("New Event Name", "'C' #define name", 0, 0, "");
            using (FormEventEditor frmEvEdit = new FormEventEditor(e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEvent();
                    EventInfoTest.AddNewEvent(e);
                    PopulateEvents();
                }
            }
        }

        private void ModifyEvent()
        {
            EventTest e = (EventTest)lBoxEvents.SelectedItem;
            using (FormEventEditor frmEvEdit = new FormEventEditor(e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEvent();
                    formEventPreview.UpdateForm(e);
                }
            }
        }

        private void CopyEvent()
        {
            int indexCount = 0;
            while (indexCount < lBoxEvents.SelectedIndices.Count)
            {
                EventTest e = (EventTest)lBoxEvents.SelectedItems[indexCount];
                EventTest eNew = new EventTest("Copy of " + e.name, "Copy of " + e.cDefineName, e.logId, e.structId, e.helpText);
                EventInfoTest.AddNewEvent(eNew);
                indexCount++;
            }
            PopulateEvents();
            lBoxEvents.SelectedIndex = EventInfoTest.GetEvents().Length - 1;
        }

        private void DeleteEvent()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected event(s)?",
                                                          "Delete Event(s) Confirmation",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int indexCount = 0;
            List<EventTest> items = new List<EventTest>();
            while (indexCount < lBoxEvents.SelectedIndices.Count)
            {
                items.Add((EventTest)lBoxEvents.SelectedItems[indexCount]);
                indexCount++;
            }

            while (items.Count != 0)
            {
                EventInfoTest.DeleteEvent(items[0]);
                items.RemoveAt(0);
            }

            int numEvents = EventInfoTest.GetEvents().Length;
            int selIndex = lBoxEvents.SelectedIndex;
            PopulateEvents();
            if (selIndex < numEvents)
            {
                lBoxEvents.SelectedIndex = selIndex;
            }
            else
            {
                lBoxEvents.SelectedIndex = selIndex - 1;
            }
        }

        private void CreateEventStructure()
        {
            EventStructureTest e = new EventStructureTest("New_Event_str", new List<int>());
            using (FormEventStructureEditor frmEvEdit = new FormEventStructureEditor(e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEventStructure();
                    EventInfoTest.AddNewEventStructure(e);
                    PopulateEventStructures();
                }
            }
        }

        private void ModifyEventStructure()
        {
            EventStructureTest e = (EventStructureTest)lBoxEventStructures.SelectedItem;
            using (FormEventStructureEditor frmEvStrEdit = new FormEventStructureEditor(e))
            {
                if (frmEvStrEdit.ShowDialog() == DialogResult.OK)
                {
                    //TODO formEventStructurePreview.UpdateForm(e);
                }
            }
        }

        private void CopyEventStructure()
        {
            int indexCount = 0;
            while (indexCount < lBoxEventStructures.SelectedIndices.Count)
            {
                EventStructureTest e = (EventStructureTest)lBoxEventStructures.SelectedItems[indexCount];
                EventStructureTest eNew = new EventStructureTest("Copy of " + e.name, e.varId);
                EventInfoTest.AddNewEventStructure(eNew);
                indexCount++;
            }
            PopulateEventStructures();
            lBoxEventStructures.SelectedIndex = EventInfoTest.GetEventStructures().Length - 1;
        }

        private void DeleteEventStructure()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected Event Structure(s)?",
                                                          "Delete Event Structure(s) Confirmation",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int indexCount = 0;
            List<EventStructureTest> items = new List<EventStructureTest>();
            while (indexCount < lBoxEventStructures.SelectedIndices.Count)
            {
                items.Add((EventStructureTest)(lBoxEventStructures.SelectedItems[indexCount]));
                indexCount++;
            }

            while (items.Count != 0)
            {
                EventInfoTest.DeleteEventStructure(items[0]);
                items.RemoveAt(0);
            }

            int numEvents = EventInfoTest.GetEventStructures().Length;
            int selIndex = lBoxEventStructures.SelectedIndex;
            PopulateEventStructures();
            if (selIndex < numEvents)
            {
                lBoxEventStructures.SelectedIndex = selIndex;
            }
            else
            {
                lBoxEventStructures.SelectedIndex = selIndex - 1;
            }
        }

        private void CreateEventVariable()
        {
            EventVariableTest e = new EventVariableTest("New Event Var DisplayName", "New Event Var EmbeddedName", 1, 0, 1, 0, 0, 0, "<b>New Event Var Description</b>");
            using (FormEventVariableEditor frmEvVarEdit = new FormEventVariableEditor(e))
            {
                if (frmEvVarEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvVarEdit.GetEditedEventVariable();
                    EventInfoTest.AddNewEventVariable(e);
                    PopulateEventVariables();
                }
            }
        }

        private void CopyEventVariable()
        {
            int indexCount = 0;
            while (indexCount < lBoxEventVars.SelectedIndices.Count)
            {
                EventVariableTest e = (EventVariableTest)lBoxEventVars.SelectedItems[indexCount];
                EventVariableTest eNew = new EventVariableTest("Copy of " + e.dispName, e);
                EventInfoTest.AddNewEventVariable(eNew);
                indexCount++;
            }
            PopulateEventVariables();
            lBoxEventVars.SelectedIndex = EventInfoTest.GetEventVariables().Length - 1;
        }

        private void DeleteEventVariable()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected Event Variables(s)?",
                                                          "Delete Event Variables(s) Confirmation",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int indexCount = 0;
            List<EventVariableTest> items = new List<EventVariableTest>();
            while (indexCount < lBoxEventVars.SelectedIndices.Count)
            {
                items.Add((EventVariableTest)lBoxEventVars.SelectedItems[indexCount]);
                indexCount++;
            }

            while (items.Count != 0)
            {
                EventInfoTest.DeleteEventVariable(items[0]);
                items.RemoveAt(0);
            }

            int numEvVars = EventInfoTest.GetEventVariables().Length;
            int selIndex = lBoxEventVars.SelectedIndex;
            PopulateEventVariables();
            if (selIndex < numEvVars)
            {
                lBoxEventVars.SelectedIndex = selIndex;
            }
            else
            {
                lBoxEventVars.SelectedIndex = selIndex - 1;
            }
        }




        void ModifyEventVariable()
        {
            EventVariableTest e = (EventVariableTest)lBoxEventVars.SelectedItem;
            using (FormEventVariableEditor frmEvEdit = new FormEventVariableEditor(e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEventVariable();
                    //formEventPreview.UpdateForm(e);
                }
            }

        }

    }
}