using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormSelfTestListEditor : Form
    {
        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormSelfTestListEditor()
        {
            InitializeComponent();

            ucDS_UsedTests.SetOtherSelector(ucDS_AvailableTests);
            ucDS_AvailableTests.SetOtherSelector(ucDS_UsedTests);

            PopulateTestList();
        }

        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////        
        public void PopulateTests(object obj)
        {
            SelfTestGroupDB stl = (SelfTestGroupDB)obj;

            ucDS_UsedTests.ClearAllItems();
            ucDS_AvailableTests.ClearAllItems();

            if (stl.selfTestList != null)
            {
                foreach (SelfTestDB st in stl.selfTestList)
                {
                    ucDS_UsedTests.AddListBoxItem(st);
                }
            }

            foreach (SelfTestDB st in SelfTestList.GetObjects())
            {
                Boolean testNumberInRange = (st.number >= stl.minTestNumber && st.number <= stl.maxTestNumber);

                if (testNumberInRange)
                {
                    if (stl.selfTestList == null)
                    {
                        // no tests in list so add
                        ucDS_AvailableTests.AddListBoxItem(st);
                    }
                    else if (!stl.selfTestList.Contains(st))
                    {
                        ucDS_AvailableTests.AddListBoxItem(st);
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////
        // Private methods
        ////////////////////////////////////////////////////////////
        private void PopulateTestList()
        {
            cBoxTestList.Items.AddRange(SelfTestGroupList.GetObjects());
            cBoxTestList.SelectedIndex = 0;
        }

        ////////////////////////////////////////////////////////////
        // Control event methods
        ////////////////////////////////////////////////////////////
        private void cBoxTestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTests(cBoxTestList.SelectedItem);
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

    }
}