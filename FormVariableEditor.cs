using System.Windows.Forms;

namespace DDB
{
    public partial class FormVariableEditor : Form
    {
        private VariableDB var;
        private FormMain formMain;

        public FormVariableEditor(VariableDB v, FormMain fMain)
        {
            InitializeComponent();

            var = v;
            formMain = fMain;

            userControlVariableEditor1.setParentForm(this);
            userControlVariableEditor1.setFormMain(formMain);

            userControlVariableEditor1.UpdateVarDisplay(var);
        }

        public FormVariableEditor(FormMain fMain, GetUserSelection getUS)
        {
            InitializeComponent();

            formMain = fMain;

            var = userControlVariableEditor1.VarCreate(getUS);

            userControlVariableEditor1.setParentForm(this);
            userControlVariableEditor1.setFormMain(formMain);

            userControlVariableEditor1.UpdateVarDisplay(var);
        }

        private FormVariableEditor()
        {
        }
    }
}