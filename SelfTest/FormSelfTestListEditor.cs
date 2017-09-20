using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public class SelfTestListsBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormSelfTestListEditor formEditor;

        public SelfTestListsBusinessLogic(FormSelfTestListEditor form)
        {
            formEditor = form;
        }

        public object Copy(object obj)
        {
            throw new NotImplementedException();
        }

        public void Modify(object obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public object Create()
        {
            throw new NotImplementedException();
        }

        public void Preview(object obj)
        {
            //throw new NotImplementedException();
        }

        public void Links()
        {}

        public void Import()
        {
            //TODO 
        }

        public void ChangeDisplayName(int nameId)
        {}

        public void HelpModify(object obj)
        {}

        // Called when selected index changes
        public void HelpPreview(object obj)
        {
            if (obj != null)
            {
                formEditor.PopulateTests(obj);
            }
        }
    }


    public partial class FormSelfTestListEditor : Form
    {
        SelfTestListsBusinessLogic stlbl;

        public FormSelfTestListEditor()
        {
            InitializeComponent();

            stlbl = new SelfTestListsBusinessLogic(this);

            ucDS_UsedTests.SetOtherSelector(ucDS_AvailableTests);
            ucDS_AvailableTests.SetOtherSelector(ucDS_UsedTests);
            userControlEntityEditor1.setBusinessLogic(stlbl);
            PopulateTestList();

        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Self Test Lists", ""))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        void PopulateTestList()
        {
            userControlEntityEditor1.AddListBoxItems(SelfTestListList.GetObjects());
        }

        public void PopulateTests(object obj)
        {
            SelfTestListDB stl = (SelfTestListDB)obj;

            if (stl.selfTestList == null)
            {
                return;
            }

            ucDS_UsedTests.ClearAllItems();
            foreach (SelfTestDB st in stl.selfTestList)
            {
                ucDS_UsedTests.AddListBoxItem(st);
            }

            ucDS_AvailableTests.ClearAllItems();
            foreach (SelfTestDB st in SelfTestList.GetObjects())
            {
                if (stl.selfTestList != null)
                {
                    if (!stl.selfTestList.Contains(st))
                    {
                        ucDS_AvailableTests.AddListBoxItem(st);
                    }
                }
                else
                {
                    ucDS_AvailableTests.AddListBoxItem(st);
                }
            }

        }
       

    }
}