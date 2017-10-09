using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{
    public class SelfTestVariablesBusinessLogic : iEntityEditorBusinesssLogic
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private FormVariablePreview m_FormVariablePreview;
        private FormMain m_FormMain;
        private FormHelpPreview m_FormHelpPreview;
        private FormBitmaskPreview m_FormBitmaskPreview;
        private FormEnumPreview m_FormEnumPreview;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public SelfTestVariablesBusinessLogic(FormMain fMain, FormHelpPreview helpPreview, FormVariablePreview fPreview, FormBitmaskPreview bPreview, FormEnumPreview ePreview)
        {
            m_FormMain = fMain;
            m_FormHelpPreview = helpPreview;
            m_FormVariablePreview = fPreview;
            m_FormBitmaskPreview = bPreview;
            m_FormEnumPreview = ePreview;
        }

        private SelfTestVariablesBusinessLogic()
        { }

        ////////////////////////////////////////////////////////////
        // Interface Implementations
        ////////////////////////////////////////////////////////////
        public object Copy(object obj)
        {
            VariableDB var = new VariableDB((VariableDB)obj);
            var.dispName = "Copy of " + var.dispName;
            var.embName = "Copy of " + var.embName;
            return var;
        }

        public void Modify(object obj)
        {
            using (FormVariableEditor frmEdit = new FormVariableEditor((VariableDB)obj, m_FormMain, m_FormBitmaskPreview, m_FormEnumPreview))
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
            VariableDB var = new VariableDB("New Self Test Variable", "newStVar", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>New Self Test Var Description</b>", GlobalSettings.getEventVariableDisplayType);
            using (FormVariableEditor frmEdit = new FormVariableEditor((VariableDB)var, m_FormMain, m_FormBitmaskPreview, m_FormEnumPreview))
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
            FormHelpText fh = new FormHelpText(var, "Self Test Variable \"" + var.dispName + "\"");
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
                VariableDB s = (VariableDB)obj;
                m_FormHelpPreview.UpdateForm(s.helpText);
            }
        }

        public void ChangeDisplayName(GlobalSettings.NameType nameType)
        {
            GlobalSettings.setSelfTestVariableDisplayType(nameType);
        }
    }

}