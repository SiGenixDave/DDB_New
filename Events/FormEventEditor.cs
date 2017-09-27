using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEventEditor : Form
    {
        private EventDB ev;
        private FormMain formMain;

        public FormEventEditor(FormMain fMain, EventDB e)
        {
            InitializeComponent();

            this.ev = e;
            this.formMain = fMain;

            PopulateEventStructures();
            PopulateEventLogs();

            tBoxEventName.Text = ev.name;
            tBoxDefineName.Text = ev.embeddedName;
            cBoxEventLogs.SelectedItem = ev.eventLogDB;
            cBoxEventStructs.SelectedItem = ev.eventStructureDB;
        }

        private FormEventEditor()
        {
        }

        public EventDB GetEditedEvent()
        {
            ev.name = tBoxEventName.Text;
            ev.embeddedName = tBoxDefineName.Text;
            ev.eventLogDB = (EventLogDB)cBoxEventLogs.SelectedItem;
            ev.eventStructureDB = (EventStructureDB)(cBoxEventStructs.SelectedItem);

            return ev;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Event", ev.name))
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

        private void PopulateEventStructures()
        {
            foreach (EventStructureDB e in formMain.GetEventStructures())
            {
                cBoxEventStructs.Items.Add(e);
            }
        }

        private void PopulateEventLogs()
        {
            foreach (EventLogDB el in EventLogList.GetEventLogs())
            {
                cBoxEventLogs.Items.Add(el);
            }
        }
    }
}