using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain
    {
        private void PopulateWatchVars()
        {
            WatchVariablesBusinessLogic wbl = new WatchVariablesBusinessLogic(this, formHelpPreview, ucVE_WatchVar);
            ucEE_WatchVariables.setBusinessLogic(wbl);
            ucEE_WatchVariables.AddListBoxItems(WatchVarList.GetWatchVars());
        }

        public void SetWatchGroupBoxEnable(Boolean enable)
        {
            grpBoxWatchAttrs.Enabled = enable;
        }

        public void SetWatchVarUserControlEnable(Boolean enable)
        {
            ucEE_WatchVariables.Enabled = enable;
        }

        public void SetWatchOtherTabsEnable(Boolean enable)
        {
            tabEvents.Enabled = enable;
            tabSelfTest.Enabled = enable;
            tabProjectDefinitions.Enabled = enable;
            tabProjectSettings.Enabled = enable;
        }

    }



    public class WatchVariablesBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormMain formMain;
        FormHelpPreview formHelpPreview;
        UserControlVariableEditor ucVE_WatchVar;

        public WatchVariablesBusinessLogic(FormMain fMain, FormHelpPreview hPreview, UserControlVariableEditor ucVE )
        {
            formMain = fMain;
            formHelpPreview = hPreview;
            ucVE_WatchVar = ucVE;
        }

        private WatchVariablesBusinessLogic()
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
            formMain.SetWatchGroupBoxEnable(true);
            formMain.SetWatchVarUserControlEnable(false);
            formMain.SetWatchOtherTabsEnable(false);
            ucVE_WatchVar.EnableEditor(obj);
            formMain.SetWatchGroupBoxEnable(false);
            formMain.SetWatchVarUserControlEnable(true);
            formMain.SetWatchOtherTabsEnable(true);
        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            formMain.SetWatchGroupBoxEnable(true);
            formMain.SetWatchVarUserControlEnable(false);
            formMain.SetWatchOtherTabsEnable(false); 
            object obj = ucVE_WatchVar.VarCreate();
            if (ucVE_WatchVar.EnableEditor(obj))
            {
                formMain.SetWatchGroupBoxEnable(false);
                formMain.SetWatchVarUserControlEnable(true);
                formMain.SetWatchOtherTabsEnable(true);
                return obj;
            }

            formMain.SetWatchGroupBoxEnable(false);
            formMain.SetWatchVarUserControlEnable(true);
            formMain.SetWatchOtherTabsEnable(true);
            return null;

        }

        public void Preview(object obj)
        {
            ucVE_WatchVar.UpdateVarDisplay((VariableDB)obj);
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
                formHelpPreview.UpdateForm(String.Empty);
            }
            else
            {
                VariableDB e = (VariableDB)obj;
                formHelpPreview.UpdateForm(e.helpText);
            }
        }

        public void ChangeDisplayName(int name)
        {
            NameType nameType = NameType.DISPLAY;
            if (name == 1)
            {
                nameType = NameType.ENMBEDDED;
            }

            GlobalSettings.setWatchDisplayType(nameType);

        }

    }



}