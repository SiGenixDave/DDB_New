using System;
using System.Windows.Forms;

namespace DDB
{
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
            EventVariablesBusinessLogic ebl = new EventVariablesBusinessLogic(this, formVariablePreview, formHelpPreview);
            ucEE_EventVariables.setBusinessLogic(ebl);
            ucEE_EventVariables.AddListBoxItems(EventVariableList.GetEventVariables());
        }

        public object[] GetEventVariables()
        {
            return ucEE_EventVariables.GetItems();
        }

    }

    public class EventsBusinessLogic : iEntityEditorBusinesssLogic
    {
        private FormEventPreview evPreview;
        private FormMain formMain;
        private FormHelpPreview formHelpPreview;

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
        { }

        public object Create()
        {
            EventDB e = new EventDB("New Event Name", "Embedded Name", EventLogList.GetEventObject(0), EventStructureList.GetEventObject(0), "");
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
        private FormEventStructurePreview evPreview;

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
        { }

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
        private FormVariablePreview formVarPreview;
        private FormMain formMain;
        private FormHelpPreview formHelpPreview;

        public EventVariablesBusinessLogic(FormMain fMain, FormVariablePreview vPreview, FormHelpPreview hPreview)
        {
            formMain = fMain;
            formVarPreview = vPreview;
            formHelpPreview = hPreview;
        }

        private EventVariablesBusinessLogic()
        { }

        public object Copy(object obj)
        {
            VariableDB var = new VariableDB((VariableDB)obj);
            var.dispName = "Copy of " + var.dispName;
            var.embName = "Copy of " + var.embName;
            return var;
        }

        public void Modify(object obj)
        {
            using (FormVariableEditor frmEdit = new FormVariableEditor((VariableDB)obj, formMain))
            {
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    formVarPreview.UpdateForm((VariableDB)obj);
                }
            }
        }

        public void Delete(object obj)
        { }

        public object Create()
        {
            VariableDB var = new VariableDB("New Event Variable", "newEvVar", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>New Event Var Description</b>", GlobalSettings.getEventVariableDisplayType);
            using (FormVariableEditor frmEdit = new FormVariableEditor((VariableDB)var, formMain))
            {
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    formVarPreview.UpdateForm((VariableDB)var);
                    return var;
                }
            }

            return null;
        }

        public void Preview(object obj)
        {
            formVarPreview.UpdateForm((VariableDB)obj);
        }

        public void Links()
        { }

        public void Import()
        { }

        public void HelpModify(object obj)
        {
            VariableDB var = (VariableDB)obj;
            FormHelpText fh = new FormHelpText(var, "Event Variable \"" + var.dispName + "\"");
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
                VariableDB var = (VariableDB)obj;
                formHelpPreview.UpdateForm(var.helpText);
            }
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
}