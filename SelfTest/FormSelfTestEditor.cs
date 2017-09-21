using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormSelfTestEditor : Form
    {
        SelfTestDB st;
        FormMain formMain;
        FormHelpPreview fhp = new FormHelpPreview();

        const String STR_APPEND = "Append";
        const String STR_MODIFY = "Modify";
        const String STR_INSERT_BEFORE = "Insert Before";
        const String STR_INSERT_AFTER = "Insert After";
        const String STR_DELETE = "Delete";
        const String STR_REORDER = "Reorder";

        readonly String[] action = { STR_APPEND, STR_MODIFY, STR_INSERT_BEFORE, STR_INSERT_AFTER, STR_DELETE, STR_REORDER };
        readonly String[] customerOnlyAction = { STR_MODIFY };

        public FormSelfTestEditor(FormMain fMain, SelfTestDB e)
        {
            InitializeComponent();

            this.st = e;
            this.formMain = fMain;

            tBoxSelfTestName.Text = st.name;
            tBoxSelfTestNumber.Text = st.number.ToString();
            tBoxDefineName.Text = st.embeddedName;

            ucDS_UsedVars.SetOtherSelector(ucDS_AvailableVars);
            ucDS_AvailableVars.SetOtherSelector(ucDS_UsedVars);

            PopulateUsedVars();
            PopulateUnusedVars();
            PopulateActionCheckBox();

            if (GlobalSettings.getCustomerUseOnly())
            {
                tBoxSelfTestName.Enabled = false;
                tBoxSelfTestNumber.Enabled = false;
                tBoxDefineName.Enabled = false;
                ucDS_UsedVars.Enabled = false;
                ucDS_AvailableVars.Enabled = false;
            }

            fhp.Owner = this;

        }

        private FormSelfTestEditor()
        {
        }


        public SelfTestDB GetEditedSelfTest()
        {
            st.name = tBoxSelfTestName.Text;
            st.number = Convert.ToInt32(tBoxSelfTestNumber.Text);
            st.embeddedName = tBoxDefineName.Text;

            st.variableList.Clear();
            if ((st.number >= 200) && (st.number <= 299))
            {
                foreach (SelfTestVariableDB stv in ucDS_UsedVars.GetItems())
                {
                    st.variableList.Add(stv);
                }
            }

            return st;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Self Test", st.name))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }


        private void PopulateUsedVars()
        {
            if (st.variableList == null)
            {
                return;
            }

            foreach (SelfTestVariableDB var in st.variableList)
            {
                ucDS_UsedVars.AddListBoxItem(var);
            }
        }

        private void PopulateUnusedVars()
        {
            SelfTestVariableDB[] allVars = SelfTestVariableList.GetSelfTestVariables();

            foreach (SelfTestVariableDB var in SelfTestVariableList.GetSelfTestVariables())
            {
                if (st.variableList != null)
                {
                    if (!st.variableList.Contains(var))
                    {
                        ucDS_AvailableVars.AddListBoxItem(var);
                    }
                }
                else
                {
                    ucDS_AvailableVars.AddListBoxItem(var);
                }
            }
        }


        private void rbTestDescription_CheckedChanged(object sender, EventArgs e)
        {
            cBoxTestStep.Enabled = false;
            cBoxMessageAction.Enabled = false;
            lblAction.Enabled = false;
            lblStepNumber.Enabled = false;
        }

        private void rbMessage_CheckedChanged(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            cBoxTestStep.Enabled = true;
            cBoxMessageAction.Enabled = true;
            lblAction.Enabled = true;
            lblStepNumber.Enabled = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            FormHelpText fh;

            if (rbTestDescription.Checked)
            {
                fh = new FormHelpText(st, "Self Test \"" + st.name + "\"" + " Test Description");
                fh.ShowDialog();
            }
            else if (rbMessage.Checked)
            {
                switch (cBoxMessageAction.SelectedItem.ToString())
                {
                    case STR_APPEND:
                        AppendTestStep();
                        break;

                    case STR_MODIFY:
                        ModifyTestStep();
                        break;
                    
                    case STR_INSERT_BEFORE:
                        InsertTestStep(true);
                        break;
                    
                    case STR_INSERT_AFTER:
                        InsertTestStep(false);
                        break;
                    
                    case STR_DELETE:
                        DeleteTestStep();
                        break;

                    case STR_REORDER:
                        ReorderTestSteps();
                        break;
                }
            }

        }

        private void cBoxMessageAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBoxMessageAction.SelectedItem.ToString())
            {
                case STR_APPEND:
                    PopulateTestStepAppend();
                    break;
                case STR_MODIFY:
                case STR_INSERT_BEFORE:
                case STR_INSERT_AFTER:
                case STR_DELETE:
                    PopulateTestStepInsertModifyDelete();
                    SetTestStepSelection();
                    break;
                case STR_REORDER:
                    cBoxTestStep.Items.Clear();
                    btnGo.Enabled = true;
                    break;
                default:
                    break;

            }
        }


        private void PopulateTestStepAppend()
        {
            cBoxTestStep.Items.Clear();
            btnGo.Enabled = true;

            int newStepNumber;

            // Find the last test step number, add 1 and then populate
            if ((st.messageList == null) || (st.messageList.Count == 0))
            {
                newStepNumber = 1;
            }
            else
            {
                newStepNumber = st.messageList.Count + 1;
            }

            SelfTestMessageDB stm = new SelfTestMessageDB(newStepNumber, String.Empty);
            cBoxTestStep.Items.Add(stm);
            cBoxTestStep.SelectedItem = stm;
        }

        private Int32 prevSelectedTestStepIndex = 0;
        private void PopulateTestStepInsertModifyDelete()
        {
            prevSelectedTestStepIndex = cBoxTestStep.SelectedIndex;
            cBoxTestStep.Items.Clear();

            // Find the last test step number, add 1 and then populate
            if ((st.messageList == null) || (st.messageList.Count == 0))
            {
                btnGo.Enabled = false;
            }
            else
            {
                btnGo.Enabled = true;
                foreach (SelfTestMessageDB stm in st.messageList)
                {
                    cBoxTestStep.Items.Add(stm);
                }
            }

        }

        private void SetTestStepSelection()
        {
            if (cBoxTestStep.Items.Count <= 0)
            {
                return;
            }

            if (prevSelectedTestStepIndex < 0)
            {
                cBoxTestStep.SelectedItem = cBoxTestStep.Items[0];
            }
            else if (prevSelectedTestStepIndex < cBoxTestStep.Items.Count)
            {
                cBoxTestStep.SelectedItem = cBoxTestStep.Items[prevSelectedTestStepIndex];
            }
            else
            {
                cBoxTestStep.SelectedItem = cBoxTestStep.Items[prevSelectedTestStepIndex - 1];
            }

        }

        private void PopulateActionCheckBox()
        {
            cBoxMessageAction.Items.Clear();
            if (GlobalSettings.getCustomerUseOnly())
            {
                cBoxMessageAction.Items.AddRange(customerOnlyAction);
            }
            else
            {
                cBoxMessageAction.Items.AddRange(action);
            }
        }


        private void ReNumberTestSteps()
        {
            // Assume steps are ordered properly
            Int32 testStep = 1;
            foreach (SelfTestMessageDB stm in st.messageList)
            {
                stm.number = testStep;
                testStep++;
            }
        }

        private void AppendTestStep()
        {
            SelfTestMessageDB potentialNewTestStep = (SelfTestMessageDB)cBoxTestStep.SelectedItem;
            using (FormHelpText fh = new FormHelpText(potentialNewTestStep,
                                               "Appended (new) Self Test Message --- Number " + potentialNewTestStep.ToString()))
            {
                if (fh.ShowDialog() == DialogResult.OK)
                {
                    st.messageList.Add(potentialNewTestStep);
                    // Since the user accepted, force the combo box to be updated to the next step
                    PopulateTestStepAppend();

                    CompileHelpTextAndShow();
                }
            }
        }

        private void ModifyTestStep()
        {
            FormHelpText fh = new FormHelpText((SelfTestMessageDB)cBoxTestStep.SelectedItem,
                                               "Self Test Message \"" + cBoxTestStep.SelectedItem.ToString() + "\"");
            fh.ShowDialog();

            CompileHelpTextAndShow();
        }

        private void InsertTestStep(Boolean before)
        {
            // Get the current test step number
            SelfTestMessageDB curr = (SelfTestMessageDB)(cBoxTestStep.SelectedItem);
            Int32 testStepNum = curr.number;
            SelfTestMessageDB potentialNewTestStep = new SelfTestMessageDB(before == true ? testStepNum : testStepNum + 1, "");

            using (FormHelpText fh = new FormHelpText(potentialNewTestStep,
                       "Insert (new) Self Test Message --- Number " + potentialNewTestStep.ToString()))
            {
                if (fh.ShowDialog() == DialogResult.OK)
                {
                    if (before)
                    {
                        testStepNum--;
                    }
                    // Insert the new test step
                    st.messageList.Insert(testStepNum, potentialNewTestStep);

                    // Renumber the following test steps
                    ReNumberTestSteps();
                    // Since the user accepted, force the combo box to be updated to the next step
                    PopulateTestStepInsertModifyDelete();
                    SetTestStepSelection();

                    CompileHelpTextAndShow();
                }
            }

        }

        private void DeleteTestStep()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected Test Step?",
                      "Delete Test Step Confirmation",
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Warning);

            // User really didn't want to delete the test step... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            SelfTestMessageDB stm = (SelfTestMessageDB)cBoxTestStep.SelectedItem;
            Int32 testNum = stm.number;

            st.messageList.Remove(stm);

            ReNumberTestSteps();

            PopulateTestStepInsertModifyDelete();
            SetTestStepSelection();

            CompileHelpTextAndShow();

        }

        private void ReorderTestSteps()
        {
            if (checkBoxViewEntireTest.Checked)
            {
                fhp.Visible = false;
            }

            using (FormReorderTestSteps fReorder = new FormReorderTestSteps(st))
            {
                if (fReorder.ShowDialog() == DialogResult.OK)
                {
                    st.messageList = fReorder.GetEditedSelfTestList();
                    ReNumberTestSteps();
                }
            }

            if (checkBoxViewEntireTest.Checked)
            {
                fhp.Visible = true;
                CompileHelpTextAndShow();
            }
                
        }

        private void checkBoxViewEntireTest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewEntireTest.Checked)
            {
                fhp.Visible = true;
                CompileHelpTextAndShow();
            }
            else
            {
                fhp.Visible = false;
            }

        }

        private void CompileHelpTextAndShow()
        {
            String helpText = st.descriptionText;

            foreach (SelfTestMessageDB s in st.messageList)
            {
                helpText += s.messageText;
            }

            fhp.UpdateForm(helpText);
        }

        private void tBoxSelfTestNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 testNumber = Convert.ToInt32(tBoxSelfTestNumber.Text);
                if ((testNumber >= 200 && testNumber <= 299) && (!GlobalSettings.getCustomerUseOnly()))
                {
                    ucDS_AvailableVars.Enabled = true;
                    ucDS_UsedVars.Enabled = true;
                }
                else
                {
                    ucDS_AvailableVars.Enabled = false;
                    ucDS_UsedVars.Enabled = false;
                }
            }
            catch
            {
                ucDS_AvailableVars.Enabled = false;
                ucDS_UsedVars.Enabled = false;
            }
        }

    }
}