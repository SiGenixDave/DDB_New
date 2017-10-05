using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEventStructureEditor : Form
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private EventStructureDB m_EventStructure;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormEventStructureEditor(EventStructureDB ev)
        {
            InitializeComponent();
            m_EventStructure = ev;

            // Let each combo box "know" about the other one so that objects (vars) can be exchanged
            ucDS_AvailEventVars.SetOtherSelector(ucDS_UsedEventVars);
            ucDS_UsedEventVars.SetOtherSelector(ucDS_AvailEventVars);

            tBoxStructName.Text = m_EventStructure.name;

            // Populate the combo boxers
            PopulateUsedVars();
            PopulateUnusedVars();
        }

        private FormEventStructureEditor()
        { }

        ////////////////////////////////////////////////////////////
        // Public Methods
        ////////////////////////////////////////////////////////////
        // Invoked by calling form to populate the object with the user selected 
        // data after "Accept" clicked
        public EventStructureDB GetEditedEventStructure()
        {
            m_EventStructure.name = tBoxStructName.Text;

            m_EventStructure.variableList.Clear();

            foreach (VariableDB var in ucDS_UsedEventVars.GetItems())
            {
                m_EventStructure.variableList.Add(var);
            }

            return m_EventStructure;
        }

        ////////////////////////////////////////////////////////////
        // Private Methods
        ////////////////////////////////////////////////////////////
        private void PopulateUsedVars()
        {
            if (m_EventStructure.variableList == null)
            {
                return;
            }

            foreach (VariableDB ev in m_EventStructure.variableList)
            {
                ucDS_UsedEventVars.AddListBoxItem(ev);
            }
        }

        private void PopulateUnusedVars()
        {
            VariableDB[] allVars = EventVariableList.GetEventVariables();

            foreach (VariableDB var in EventVariableList.GetEventVariables())
            {
                if (m_EventStructure.variableList != null)
                {
                    if (!m_EventStructure.variableList.Contains(var))
                    {
                        ucDS_AvailEventVars.AddListBoxItem(var);
                    }
                }
                else
                {
                    ucDS_AvailEventVars.AddListBoxItem(var);
                }
            }
        }

        ////////////////////////////////////////////////////////////
        // Control event methods
        ////////////////////////////////////////////////////////////
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Event Structure", m_EventStructure.name))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void tBoxStructName_TextChanged(object sender, EventArgs e)
        {
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxStructName.Text.Length > 0) && (tBoxStructName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxStructName.Text, tBoxStructName.Font);

                tBoxStructName.Width = size.Width + 10;
                tBoxStructName.Height = size.Height;
            }
        }

        private void FormEventStructureEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnAccept_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(null, null);
            }
        }
    }
}