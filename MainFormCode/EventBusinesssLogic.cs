using System;
using System.Windows.Forms;

namespace DDB
{
    public class EventBusinesssLogic : iEntityEditorBusinesssLogic
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private FormEventPreview m_FormEventPreview;
        private FormMain m_FormMain;
        private FormHelpPreview m_FormHelpPreview;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public EventBusinesssLogic(FormMain fMain, FormEventPreview preview, FormHelpPreview helpPreview)
        {
            m_FormMain = fMain;
            m_FormEventPreview = preview;
            m_FormHelpPreview = helpPreview;
        }

        private EventBusinesssLogic()
        { }

        ////////////////////////////////////////////////////////////
        // Interface Implementations
        ////////////////////////////////////////////////////////////
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

        public void ChangeDisplayName(GlobalSettings.NameType nameType)
        { }

    }

}