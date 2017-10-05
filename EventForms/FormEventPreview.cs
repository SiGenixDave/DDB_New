using System.Windows.Forms;

namespace DDB
{
    public partial class FormEventPreview : Form
    {

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormEventPreview()
        {
            InitializeComponent();
        }


        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////
        public void UpdateForm(EventDB e)
        {
            if (e == null)
            {
                lblEventName.Text = "";
                lblCdefineName.Text = "";
                lblEventStructure.Text = "";
                lblEventLog.Text = "";
            }
            else
            {
                lblEventName.Text = e.name;
                lblCdefineName.Text = e.embeddedName;
                lblEventStructure.Text = e.eventStructureDB.ToString();
                lblEventLog.Text = e.eventLogDB.ToString();
            }
        }
    }
}