using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    
    public class WatchVariablesBusinessLogic : iEntityEditorBusinesssLogic
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private FormMain m_FormMain;
        private FormHelpPreview m_FormHelpPreview;
        private UserControlVariableEditor m_UCVE_WatchVar;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public WatchVariablesBusinessLogic(FormMain fMain, FormHelpPreview hPreview, UserControlVariableEditor ucVE )
        {
            m_FormMain = fMain;
            m_FormHelpPreview = hPreview;
            m_UCVE_WatchVar = ucVE;
        }

        private WatchVariablesBusinessLogic()
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
            m_FormMain.SetWatchGroupBoxEnable(true);
            m_FormMain.SetWatchVarUserControlEnable(false);
            m_FormMain.SetWatchOtherTabsEnable(false);
            
            m_UCVE_WatchVar.EnableEditor(obj);
            
            m_FormMain.SetWatchGroupBoxEnable(false);
            m_FormMain.SetWatchVarUserControlEnable(true);
            m_FormMain.SetWatchOtherTabsEnable(true);
        }

        public void Delete(object obj)
        { }

        public object Create()
        {
            m_FormMain.SetWatchGroupBoxEnable(true);
            m_FormMain.SetWatchVarUserControlEnable(false);
            m_FormMain.SetWatchOtherTabsEnable(false); 
            
            object obj = m_UCVE_WatchVar.VarCreate(GlobalSettings.getWatchDisplayType);

            object retObj = null;
            if (m_UCVE_WatchVar.EnableEditor(obj))
            {
                retObj = obj;
            }

            m_FormMain.SetWatchGroupBoxEnable(false);
            m_FormMain.SetWatchVarUserControlEnable(true);
            m_FormMain.SetWatchOtherTabsEnable(true);
            return retObj;

        }

        public void Preview(object obj)
        {
            m_UCVE_WatchVar.UpdateVarDisplay((VariableDB)obj);
        }

        public void Links()
        {
            //TODO 
        }

        public void Import()
        {
            FormImport iForm = new FormImport("Watch Variables");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with vList box of units from the XML file        
        }

        public void HelpModify(object obj)
        {
            VariableDB var = (VariableDB)obj;
            FormHelpText fh = new FormHelpText(var, "Watch Variable \"" + var.dispName + "\"");
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
                VariableDB e = (VariableDB)obj;
                m_FormHelpPreview.UpdateForm(e.helpText);
            }
        }

        public void ChangeDisplayName(int name)
        {
            GlobalSettings.NameType nameType = GlobalSettings.NameType.DISPLAY;
            if (name == 1)
            {
                nameType = GlobalSettings.NameType.ENMBEDDED;
            }

            GlobalSettings.setWatchDisplayType(nameType);

        }

    }



}