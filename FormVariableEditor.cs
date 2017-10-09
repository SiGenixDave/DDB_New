using System.Windows.Forms;

namespace DDB
{
    public partial class FormVariableEditor : Form
    {
        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormVariableEditor(VariableDB var, FormMain fMain, FormBitmaskPreview fBitmaskPreview, FormEnumPreview fEnumPreview)
        {
            InitializeComponent();

            // This form uses the user control "variable editor" to edit variables
            userControlVariableEditor1.setParentForm(this);

            userControlVariableEditor1.setFormMain(fMain);
            userControlVariableEditor1.UpdateVarDisplay(var);
            userControlVariableEditor1.setBitmaskHelpPreview(fBitmaskPreview);
            userControlVariableEditor1.setEnumHelpPreview(fEnumPreview);
        }

        private FormVariableEditor()
        {
        }
    }
}