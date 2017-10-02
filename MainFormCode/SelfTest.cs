using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{
    public class SelfTestsBusinessLogic : iEntityEditorBusinesssLogic
    {
        private FormEventPreview evPreview;
        private FormMain formMain;
        private FormHelpPreview formHelpPreview;

        public SelfTestsBusinessLogic(FormMain fMain, FormEventPreview preview, FormHelpPreview helpPreview)
        {
            formMain = fMain;
            evPreview = preview;
            formHelpPreview = helpPreview;
        }

        private SelfTestsBusinessLogic()
        { }

        public object Copy(object obj)
        {
            SelfTestDB ev = new SelfTestDB((SelfTestDB)obj);
            ev.name = "Copy of " + ev.name;
            return ev;
        }

        public void Modify(object obj)
        {
            using (FormSelfTestEditor frmStEdit = new FormSelfTestEditor(formMain, (SelfTestDB)obj))
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
            using (FormSelfTestEditor frmStEdit = new FormSelfTestEditor(formMain, s))
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
                formHelpPreview.UpdateForm(String.Empty);
            }
            else
            {
                SelfTestDB s = (SelfTestDB)obj;
                formHelpPreview.UpdateForm(s.description.messageText);
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

    public class SelfTestVariablesBusinessLogic : iEntityEditorBusinesssLogic
    {
        private FormVariablePreview formVarPreview;
        private FormMain formMain;
        private FormHelpPreview formHelpPreview;

        public SelfTestVariablesBusinessLogic(FormMain fMain, FormHelpPreview helpPreview, FormVariablePreview fPreview)
        {
            formMain = fMain;
            formHelpPreview = helpPreview;
            formVarPreview = fPreview;
        }

        private SelfTestVariablesBusinessLogic()
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
            VariableDB var = new VariableDB("New Self Test Variable", "newStVar", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>New Self Test Var Description</b>", GlobalSettings.getEventVariableDisplayType);
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
            FormHelpText fh = new FormHelpText(var, "Self Test Variable \"" + var.dispName + "\"");
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
                VariableDB s = (VariableDB)obj;
                formHelpPreview.UpdateForm(s.helpText);
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

    public partial class FormMain
    {
        private void PopulateSelfTestLists()
        {
            PopulateSelfTests();
        }

        private void PopulateSelfTests()
        {
            SelfTestsBusinessLogic sbl = new SelfTestsBusinessLogic(this, formEventPreview, formHelpPreview);
            ucEE_SelfTest.setBusinessLogic(sbl);
            ucEE_SelfTest.AddListBoxItems(SelfTestList.GetObjects());

            SelfTestVariablesBusinessLogic svbl = new SelfTestVariablesBusinessLogic(this, formHelpPreview, formVariablePreview);
            ucEE_SelfTestVariables.setBusinessLogic(svbl);
            ucEE_SelfTestVariables.AddListBoxItems(SelfTestVariableList.GetSelfTestVariables());
        }

        private void btnEditSelfTestLists_Click(object sender, EventArgs e)
        {
            FormSelfTestListEditor formSTLE = new FormSelfTestListEditor();
            formSTLE.ShowDialog();
        }
    }
}