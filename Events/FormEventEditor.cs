using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEventEditor : Form
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        // Event being edited
        private EventDB m_EventBeingEdited;

        // Used to current event structures
        private FormMain m_FormMain;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormEventEditor(FormMain fMain, EventDB e)
        {
            InitializeComponent();

            m_EventBeingEdited = e;
            m_FormMain = fMain;

            PopulateEventStructures();
            PopulateEventLogs();

            tBoxEventName.Text = m_EventBeingEdited.name;
            tBoxDefineName.Text = m_EventBeingEdited.embeddedName;
            cBoxEventLogs.SelectedItem = m_EventBeingEdited.eventLogDB;
            cBoxEventStructs.SelectedItem = m_EventBeingEdited.eventStructureDB;
        }

        // Disallow default constructor
        private FormEventEditor()
        { }

        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////
        public EventDB GetEditedEvent()
        {
            m_EventBeingEdited.name = tBoxEventName.Text;
            m_EventBeingEdited.embeddedName = tBoxDefineName.Text;
            m_EventBeingEdited.eventLogDB = (EventLogDB)cBoxEventLogs.SelectedItem;
            m_EventBeingEdited.eventStructureDB = (EventStructureDB)(cBoxEventStructs.SelectedItem);

            return m_EventBeingEdited;
        }

        ////////////////////////////////////////////////////////////
        // Private methods
        ////////////////////////////////////////////////////////////
        private void PopulateEventStructures()
        {
            foreach (EventStructureDB e in m_FormMain.GetEventStructures())
            {
                cBoxEventStructs.Items.Add(e);
            }
        }

        private void PopulateEventLogs()
        {
            // The event logs are copied to the event log list when updated since they are modified
            // in a datagrid control and not a combo box
            foreach (EventLogDB el in EventLogList.GetEventLogs())
            {
                cBoxEventLogs.Items.Add(el);
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
            if (Cancel.Query("Event", m_EventBeingEdited.name))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void FormEventEditor_KeyDown(object sender, KeyEventArgs e)
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

        private void tBoxEventName_TextChanged(object sender, EventArgs e)
        {
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxEventName.Text.Length > 0) && (tBoxEventName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxEventName.Text, tBoxEventName.Font);

                tBoxEventName.Width = size.Width + 10;
                tBoxEventName.Height = size.Height;
            }
        }

        private void tBoxDefineName_TextChanged(object sender, EventArgs e)
        {
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxDefineName.Text.Length > 0) && (tBoxDefineName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxDefineName.Text, tBoxDefineName.Font);

                tBoxDefineName.Width = size.Width;
                tBoxDefineName.Height = size.Height;
            }
        }
    }
}