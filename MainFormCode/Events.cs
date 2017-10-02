using System;
using System.Windows.Forms;

namespace DDB
{
    public class EventsBnessLog : iEntityEditorBusinesssLogic
    {
        private FormEventPreview m_FormEventPreview;
        private FormMain m_FormMain;
        private FormHelpPreview m_FormHelpPreview;

        public EventsBnessLog(FormMain fMain, FormEventPreview preview, FormHelpPreview helpPreview)
        {
            m_FormMain = fMain;
            m_FormEventPreview = preview;
            m_FormHelpPreview = helpPreview;
        }

        private EventsBnessLog()
        { }

        public object Copy(object obj)
        {
            EventDB ev = new EventDB((EventDB)obj);
            ev.name = "Copy of " + ev.name;
            return ev;
        }

        public void Modify(object obj)
        {
            using (FormEventEditor frmEvEdit = new FormEventEditor(m_FormMain, (EventDB)obj))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    EventDB e = frmEvEdit.GetEditedEvent();
                    m_FormEventPreview.UpdateForm(e);
                }
            }
        }

        public void Delete(object obj)
        { }

        public object Create()
        {
            EventDB e = new EventDB("New Event Name", "Embedded Name", EventLogList.GetEventObject(0), EventStructureList.GetEventObject(0), "");
            using (FormEventEditor frmEvEdit = new FormEventEditor(m_FormMain, e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEvent();
                    m_FormEventPreview.UpdateForm(e);
                    return e;
                }
            }

            return null;
        }

        public void Preview(object obj)
        {
            m_FormEventPreview.UpdateForm((EventDB)obj);
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
                m_FormHelpPreview.UpdateForm(String.Empty);
            }
            else
            {
                EventDB e = (EventDB)obj;
                m_FormHelpPreview.UpdateForm(e.helpText);
            }
        }

        public void ChangeDisplayName(int name)
        { }

    }

    public class EventStructuresBnessLog : iEntityEditorBusinesssLogic
    {
        private FormEventStructurePreview m_FormEventStructurePreview;

        public EventStructuresBnessLog(FormEventStructurePreview preview)
        {
            m_FormEventStructurePreview = preview;
        }

        private EventStructuresBnessLog()
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
                    m_FormEventStructurePreview.UpdateForm(e);
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
                    m_FormEventStructurePreview.UpdateForm(e);
                    return e;
                }
            }

            return null;
        }

        public void Preview(object obj)
        {
            m_FormEventStructurePreview.UpdateForm((EventStructureDB)obj);
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

    public class EventVariablesBnessLog : iEntityEditorBusinesssLogic
    {
        private FormVariablePreview m_FormVariablePreview;
        private FormMain m_FormMain;
        private FormHelpPreview m_FormHelpPreview;

        public EventVariablesBnessLog(FormMain fMain, FormVariablePreview vPreview, FormHelpPreview hPreview)
        {
            m_FormMain = fMain;
            m_FormVariablePreview = vPreview;
            m_FormHelpPreview = hPreview;
        }

        private EventVariablesBnessLog()
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
            using (FormVariableEditor frmEdit = new FormVariableEditor((VariableDB)obj, m_FormMain))
            {
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    m_FormVariablePreview.UpdateForm((VariableDB)obj);
                }
            }
        }

        public void Delete(object obj)
        { }

        public object Create()
        {
            VariableDB var = new VariableDB("New Event Variable", "newEvVar", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, 
                                            "<b>New Event Var Description</b>", GlobalSettings.getEventVariableDisplayType);
            using (FormVariableEditor frmEdit = new FormVariableEditor((VariableDB)var, m_FormMain))
            {
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    m_FormVariablePreview.UpdateForm((VariableDB)var);
                    return var;
                }
            }

            return null;
        }

        public void Preview(object obj)
        {
            m_FormVariablePreview.UpdateForm((VariableDB)obj);
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
                m_FormHelpPreview.UpdateForm(String.Empty);
            }
            else
            {
                VariableDB var = (VariableDB)obj;
                m_FormHelpPreview.UpdateForm(var.helpText);
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