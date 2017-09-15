using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormSelfTestEditor : Form
    {
        SelfTestDB st;
        FormMain formMain;

        public FormSelfTestEditor(FormMain fMain, SelfTestDB e)
        {
            InitializeComponent();

            this.st = e;
            this.formMain = fMain;

            tBoxSelfTestName.Text = st.name;
            tBoxSelfTestNumber.Text = st.number.ToString();
            tBoxDefineName.Text = st.embeddedName;

            PopulateSelfTestVariables();

        }

        private FormSelfTestEditor()
        {
        }


        public SelfTestDB GetEditedSelfTest()
        {
            st.name = tBoxSelfTestName.Text;
            st.number = Convert.ToInt32(tBoxSelfTestNumber.Text);
            st.embeddedName = tBoxDefineName.Text;

            //TODO compile the variable list

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


        private void PopulateSelfTestVariables()
        {
            //TODO PopulateSelfTestVariables Used and Unused variablkes
        }


    }
}