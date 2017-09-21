using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDB
{

    public class SelfTestsBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormEventPreview evPreview;
        FormMain formMain;
        FormHelpPreview formHelpPreview;

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
        {}

        public object Create()
        {
            SelfTestDB s = new SelfTestDB("New Self Test Name", 0, "New Embedded Name", new List<SelfTestVariableDB>(), new List<SelfTestMessageDB>(), 
                                          new SelfTestMessageDB(0 ,"<b>New Self Test</b>"));
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
            //TODO evPreview.UpdateForm((SelfTestDB)obj);
        }

        public void Links()
        { }
        public void Import()
        { }
        public void HelpModify(object obj)
        {}

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

            //TODO SelfTestsBusinessLogic sbl = new SelfTestsBusinessLogic(this, formEventPreview, formHelpPreview);
            //TODO ucEE_SelfTest.setBusinessLogic(sbl); 
            ucEE_SelfTestVariables.AddListBoxItems(SelfTestVariableList.GetSelfTestVariables());
        }

        private void btnEditSelfTestLists_Click(object sender, EventArgs e)
        {
            FormSelfTestListEditor formSTLE = new FormSelfTestListEditor();
            formSTLE.ShowDialog();
        }

    }
}
