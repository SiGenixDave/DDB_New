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
                    //SelfTestDB e = frmStEdit.GetEditedEvent();
                    //evPreview.UpdateForm(e);
                }
            }
        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            SelfTestDB s = new SelfTestDB("New Self Test Name", 0, "New Embedded Name", new List<SelfTestVariableDB>(), new List<SelfTestMessageDB>(), "<b>New Self Test</b>");
#if TODO
            using (FormEventEditor frmEvEdit = new FormEventEditor(formMain, e))
            {
                if (frmEvEdit.ShowDialog() == DialogResult.OK)
                {
                    e = frmEvEdit.GetEditedEvent();
                    evPreview.UpdateForm(e);
                    return e;
                }
            }
#endif
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
        {
            SelfTestDB e = (SelfTestDB)obj;
            FormHelpText fh = new FormHelpText(e, "Event \"" + e.name + "\"");
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
                SelfTestDB s = (SelfTestDB)obj;
                formHelpPreview.UpdateForm(s.descriptionText);
            }
        }

        public void ChangeDisplayName(int name)
        { }



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
    }
}
