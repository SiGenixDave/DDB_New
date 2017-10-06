using System.Windows.Forms;

namespace DDB
{
    public partial class FormVariablePreview : Form
    {
        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormVariablePreview(FormMain fMain)
        {
            InitializeComponent();

            userControlVariableEditor1.setParentForm(this);
            userControlVariableEditor1.setFormMain(fMain);

            userControlVariableEditor1.Enabled = false;
        }

        private FormVariablePreview()
        { }

        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////
        public void UpdateForm(VariableDB var)
        {
            userControlVariableEditor1.UpdateVarDisplay(var);
        }

    }
}