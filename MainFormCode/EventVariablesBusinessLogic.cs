﻿using System;
using System.Windows.Forms;

namespace DDB
{
    public class EventVariablesBusinessLogic : iEntityEditorBusinesssLogic
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private FormVariablePreview m_FormVariablePreview;
        private FormMain m_FormMain;
        private FormHelpPreview m_FormHelpPreview;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public EventVariablesBusinessLogic(FormMain fMain, FormVariablePreview vPreview, FormHelpPreview hPreview)
        {
            m_FormMain = fMain;
            m_FormVariablePreview = vPreview;
            m_FormHelpPreview = hPreview;
        }

        private EventVariablesBusinessLogic()
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
            GlobalSettings.NameType nameType = GlobalSettings.NameType.DISPLAY;
            if (name == 1)
            {
                nameType = GlobalSettings.NameType.ENMBEDDED;
            }

            GlobalSettings.setEventVariableDisplayType(nameType);
        }
    }
}