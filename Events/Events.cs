using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{

    public class EventsBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormEventPreview evPreview;
        FormMain formMain;
        FormHelpPreview formHelpPreview;

        public EventsBusinessLogic(FormMain fMain, FormEventPreview preview, FormHelpPreview helpPreview)
        {
            formMain = fMain;
            evPreview = preview;
            formHelpPreview = helpPreview;
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
        public void HelpModify(object obj)
        {
            EventDB e = (EventDB)obj;
            FormHelpText fh = new FormHelpText(e, "Event \"" + e.name + "\"");
            fh.ShowDialog();

            HelpPreview(obj);

        }

        public void HelpPreview(object obj)
        {
            if (obj == null)
            {
                formHelpPreview.UpdateForm(String.Empty);
            }
            else
            {
                EventDB e = (EventDB)obj;
                formHelpPreview.UpdateForm(e.helpText);
            }
        }

        public void ChangeDisplayName(int name)
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
        public void HelpModify(object obj)
        { }
        public void HelpPreview(object obj)
        { }
        public void ChangeDisplayName(int name)
        { }

    }

    public class EventVariablesBusinessLogic : iEntityEditorBusinesssLogic
    {
        //TODO FormEventVariablePreview evPreview;
        object evPreview;

        //TODO public EventVariablesBusinessLogic(FormEventVariablePreview preview)
        public EventVariablesBusinessLogic(object preview)
        {
            evPreview = preview;
        }

        private EventVariablesBusinessLogic()
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
                    //TODO evPreview.UpdateForm(e);
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
                    //TODO evPreview.UpdateForm(e);
                    return e;
                }
            }

            return null;

        }

        public void Preview(object obj)
        {
            //TODO evPreview.UpdateForm((EventStructureDB)obj);
        }

        public void Links()
        { }
        public void Import()
        { }
        public void HelpModify(object obj)
        { }
        public void HelpPreview(object obj)
        {
#if TODO
            if (obj == null)
            {
                formHelpPreview.UpdateForm(String.Empty);
            }
            else
            {
                //TODO
            }
#endif        
        }
        public void ChangeDisplayName(int name)
        {
            NameType nameType = NameType.DISPLAY;
            if (name == 1)
            {
                nameType = NameType.ENMBEDDED;
            }

            GlobalSettings.setEventVariableDisplayType(nameType);

        }

    }

    public partial class FormMain
    {
        private void PopulateEventLists()
        {
            PopulateEvents();
            PopulateEventStructures();
            PopulateEventVariables();
        }

        private void PopulateEvents()
        {
            EventsBusinessLogic ebl = new EventsBusinessLogic(this, formEventPreview, formHelpPreview);
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
            EventVariablesBusinessLogic ebl = new EventVariablesBusinessLogic(null);
            ucEE_EventVariables.setBusinessLogic(ebl);
            ucEE_EventVariables.AddListBoxItems(EventVariableList.GetEventVariables());
        }

        public object[] GetEventVariables()
        {
            return ucEE_EventVariables.GetItems();
        }

        /////////////////////////////////
#if TODO        
        private void btnEventVarImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Event Variables");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
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