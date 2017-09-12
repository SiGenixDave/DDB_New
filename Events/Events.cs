using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{

    public class EventsBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormEventPreview evPreview;
        FormMain formMain;

        public EventsBusinessLogic(FormMain fMain, FormEventPreview preview)
        {
            formMain = fMain;
            evPreview = preview;
        }

        private EventsBusinessLogic()
        { }

        public object Copy(object obj)
        {
            EventDB ev = new EventDB((EventDB)obj);
            ev.name = "Copy of " + ev.name;
            return ev;
        }

        public void Modify(object obj)
        {
            using (FormEventEditor frmEvEdit = new FormEventEditor(formMain, (EventDB)obj))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    EventDB e = frmEvEdit.GetEditedEvent();
                    evPreview.UpdateForm(e);
                }
            }

        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            EventDB e = new EventDB("New Event Name", "Embedded Name", 0, 0, "");
            using (FormEventEditor frmEvEdit = new FormEventEditor(formMain, e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEvent();
                    evPreview.UpdateForm(e);
                    return e;
                }
            }

            return null;

        }

        public void Preview(object obj)
        {
            evPreview.UpdateForm((EventDB)obj);
        }

        public void Links()
        { }
        public void Import()
        { }
    }


    public class EventStructuresBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormEventStructurePreview evPreview;

        public EventStructuresBusinessLogic(FormEventStructurePreview preview)
        {
            evPreview = preview;
        }

        private EventStructuresBusinessLogic()
        { }

        public object Copy(object obj)
        {
            EventStructureDB ev = new EventStructureDB((EventStructureDB)obj);
            ev.name = "Copy of " + ev.name;
            return ev;
        }

        public void Modify(object obj)
        {
            using (FormEventStructureEditor frmEvEdit = new FormEventStructureEditor((EventStructureDB)obj))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    EventStructureDB e = frmEvEdit.GetEditedEventStructure();
                    evPreview.UpdateForm(e);
                }
            }

        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            EventStructureDB e = new EventStructureDB("New Structure Name", null);
            using (FormEventStructureEditor frmEvEdit = new FormEventStructureEditor(e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEventStructure();
                    evPreview.UpdateForm(e);
                    return e;
                }
            }

            return null;

        }

        public void Preview(object obj)
        {
            evPreview.UpdateForm((EventStructureDB)obj);
        }

        public void Links()
        { }
        public void Import()
        { }
    }









    public partial class FormMain
    {
        private void InitEvents()
        {
            if (GlobalSettings.getCustomerUseOnly())
            {
#if TODO
                btnEventCreate.Enabled = false;
                btnEventImport.Enabled = false;
                btnEventStructureCreate.Enabled = false;
                btnEventStructureImport.Enabled = false;
                btnEventVarCreate.Enabled = false;
                btnEventVarImport.Enabled = false; 
                lBoxEvents.MouseDoubleClick -= lBoxEvents_MouseDoubleClick;
                lBoxEventStructures.MouseDoubleClick -= lBoxEventStructures_MouseDoubleClick;
                lBoxEventVars.MouseDoubleClick -= lBoxEventVars_MouseDoubleClick;
#endif
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
            EventsBusinessLogic ebl = new EventsBusinessLogic(this, formEventPreview);
            ucEE_Events.setBusinessLogic(ebl);
            ucEE_Events.AddListBoxItems(EventList.GetEvents());
        }

        public object[] GetEvents()
        {
            return ucEE_Events.GetItems();
        }

        private void PopulateEventStructures()
        {
            EventStructuresBusinessLogic ebl = new EventStructuresBusinessLogic(formEventStructurePreview);
            ucEE_EventStructures.setBusinessLogic(ebl);
            ucEE_EventStructures.AddListBoxItems(EventStructureList.GetEventStructures());
        }

        public object[] GetEventStructures()
        {
            return ucEE_EventStructures.GetItems();
        }

        private void PopulateEventVariables()
        {
            //TODO EventVariablesBusinessLogic ebl = new EventVariablesBusinessLogic(formEventVariablePreview);
            //TODO ucEE_EventStructures.setBusinessLogic(ebl);
            ucEE_EventVariables.AddListBoxItems(EventVariableList.GetEventVariables());
        }

        public object[] GetEventVariables()
        {
            return ucEE_EventVariables.GetItems();
        }
#if TODO

        private void btnEventModifyHelpText_Click(object sender, EventArgs e)
        {
            EventDB ev = (EventDB)lBoxEvents.SelectedItem;
            FormHelpText fh = new FormHelpText(ev, "Event \"" + ev.name + "\"");
            fh.ShowDialog();

            formHelpPreview.UpdateForm(ev.helpText);

        }

        /////////////////////////////////
        
        private void btnEventVarImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Event Variables");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }


        private void CreateEventStructure()
        {
            EventStructureDB e = new EventStructureDB("New_Event_str", new List<int>());
            using (FormEventStructureEditor frmEvEdit = new FormEventStructureEditor(e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEventStructure();
                    //TODO EventList.AddNewEventStructure(e);
                    PopulateEventStructures();
                }
            }
        }

        private void ModifyEventStructure()
        {
            EventStructureDB e = (EventStructureDB)lBoxEventStructures.SelectedItem;
            using (FormEventStructureEditor frmEvStrEdit = new FormEventStructureEditor(e))
            {
                if (frmEvStrEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvStrEdit.GetEditedEventStructure();
                    PopulateEventStructures();
                    //TODO formEventStructurePreview.UpdateForm(e);
                }
            }
        }

        private void CopyEventStructure()
        {
            int indexCount = 0;
            while (indexCount < lBoxEventStructures.SelectedIndices.Count)
            {
                EventStructureDB e = (EventStructureDB)lBoxEventStructures.SelectedItems[indexCount];
                EventStructureDB eNew = new EventStructureDB("Copy of " + e.name, e.variableListFKey);
                EventList.AddNewEventStructure(eNew);
                indexCount++;
            }
            PopulateEventStructures();
            lBoxEventStructures.SelectedIndex = EventList.GetEventStructures().Length - 1;
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

            //TODO Check if structure is part of at least 1 event, if so, can't delete and return
            int index = 0;
            Boolean structPartOfEvent = false; 
            while (index < lBoxEventStructures.SelectedItems.Count)
            {
                foreach (EventDB e in EventList.GetEvents())
                {
                    EventStructureDB es = (EventStructureDB)(lBoxEventStructures.SelectedItems[index]);
                    if (e.structFKey == es.fKey)
                    {
                        MessageBox.Show("At least one of the event structures selected are part of an event, command aborted... please use Tools...Depenedencies to discover",
                                        "Event Structure(s) Delete Aborted",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                        structPartOfEvent = true;
                        break;
                    }

                }
                if (structPartOfEvent)
                {
                    break;
                }
                index++;
            }

            if (structPartOfEvent)
            {
                return;
            }

            int indexCount = 0;
            List<EventStructureDB> items = new List<EventStructureDB>();
            while (indexCount < lBoxEventStructures.SelectedIndices.Count)
            {
                items.Add((EventStructureDB)(lBoxEventStructures.SelectedItems[indexCount]));
                indexCount++;
            }

            while (items.Count != 0)
            {
                EventList.DeleteEventStructure(items[0]);
                items.RemoveAt(0);
            }

            int numEvents = EventList.GetEventStructures().Length;
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
            EventVariableDB e = new EventVariableDB("New Event Var DisplayName", "New Event Var EmbeddedName", 1, 0, 1, 0, 0, 0, "<b>New Event Var Description</b>");
            using (FormEventVariableEditor frmEvVarEdit = new FormEventVariableEditor(e))
            {
                if (frmEvVarEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvVarEdit.GetEditedEventVariable();
                    //TODO EventList.AddNewEventVariable(e);
                    PopulateEventVariables();
                }
            }
        }

        private void CopyEventVariable()
        {
            int indexCount = 0;
            while (indexCount < lBoxEventVars.SelectedIndices.Count)
            {
                EventVariableDB e = (EventVariableDB)lBoxEventVars.SelectedItems[indexCount];
                //TODO EventVariableDB eNew = new EventVariableDB("Copy of " + e.dispName, e);
                //EventList.AddNewEventVariable(eNew);
                indexCount++;
            }
            PopulateEventVariables();
            //TODO lBoxEventVars.SelectedIndex = EventList.GetEventVariables().Length - 1;
        }

        private void DeleteEventVariable()
        {
            
        }




        void ModifyEventVariable()
        {
            EventVariableDB e = (EventVariableDB)lBoxEventVars.SelectedItem;
            using (FormEventVariableEditor frmEvEdit = new FormEventVariableEditor(e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEventVariable();
                    //formEventPreview.UpdateForm(e);
                }
            }

        }
#endif

    }
}