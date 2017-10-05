using System;
using System.Windows.Forms;

namespace DDB
{
    public class EventStructuresBusinessLogic : iEntityEditorBusinesssLogic
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private FormEventStructurePreview m_FormEventStructurePreview;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public EventStructuresBusinessLogic(FormEventStructurePreview preview)
        {
            m_FormEventStructurePreview = preview;
        }

        private EventStructuresBusinessLogic()
        { }

        ////////////////////////////////////////////////////////////
        // Interface Implementations
        ////////////////////////////////////////////////////////////
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

}