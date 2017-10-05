using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{
    public class SelfTestsBusinessLogic : iEntityEditorBusinesssLogic
    {

        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private FormMain m_FormMain;
        private FormHelpPreview m_FormHelpPreview;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public SelfTestsBusinessLogic(FormMain fMain, FormHelpPreview helpPreview)
        {
            m_FormMain = fMain;
            m_FormHelpPreview = helpPreview;
        }

        private SelfTestsBusinessLogic()
        { }

        ////////////////////////////////////////////////////////////
        // Interface Implementations
        ////////////////////////////////////////////////////////////
        public object Copy(object obj)
        {
            SelfTestDB ev = new SelfTestDB((SelfTestDB)obj);
            ev.name = "Copy of " + ev.name;
            return ev;
        }

        public void Modify(object obj)
        {
            using (FormSelfTestEditor frmStEdit = new FormSelfTestEditor(m_FormMain, (SelfTestDB)obj))
            {
                if (frmStEdit.ShowDialog() == DialogResult.OK)
                {
                    // calling this code updates the self test object (form controls copied to object)
                    // avoids having to make a copy of the self test object prior to passing to form
                    frmStEdit.GetEditedSelfTest();
                }
            }
        }

        public void Delete(object obj)
        { }

        public object Create()
        {
            SelfTestDB s = new SelfTestDB("New Self Test Name", 0, "New Embedded Name", new List<VariableDB>(), new List<SelfTestMessageDB>(),
                                          new SelfTestMessageDB(0, "<b>New Self Test</b>"));
            using (FormSelfTestEditor frmStEdit = new FormSelfTestEditor(m_FormMain, s))
            {
                if (frmStEdit.ShowDialog() == DialogResult.OK)
                {
                    // calling this code updates the self test object (form controls copied to object)
                    // avoids having to make a copy of the self test object prior to passing to form
                    s = frmStEdit.GetEditedSelfTest();
                    return s;
                }
            }
            return null;
        }

        public void Preview(object obj)
        {
            //TODO m_FormEventPreview.UpdateForm((SelfTestDB)obj);
        }

        public void Links()
        { }

        public void Import()
        { }

        public void HelpModify(object obj)
        { }

        public void HelpPreview(object obj)
        {
            if (obj == null)
            {
                m_FormHelpPreview.UpdateForm(String.Empty);
            }
            else
            {
                SelfTestDB s = (SelfTestDB)obj;
                m_FormHelpPreview.UpdateForm(s.description.messageText);
            }
        }

        public void ChangeDisplayName(int name)
        {
            NameType nameType = NameType.DISPLAY;
            if (name == 1)
            {
                nameType = NameType.ENMBEDDED;
            }

            GlobalSettings.setSelfTestVariableDisplayType(nameType);
        }
    }


}