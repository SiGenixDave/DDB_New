using System.Windows.Forms;

namespace DDB
{
    public partial class FormVariablePreview : Form
    {
        private FormMain formMain;

        public FormVariablePreview(FormMain fMain)
        {
            InitializeComponent();

            formMain = fMain;

            userControlVariableEditor1.setParentForm(this);
            userControlVariableEditor1.setFormMain(formMain);

            userControlVariableEditor1.Enabled = false;
        }

        public void UpdateForm(VariableDB var)
        {
            userControlVariableEditor1.UpdateVarDisplay(var);
        }


        private FormVariablePreview()
        {
        }
    }
}