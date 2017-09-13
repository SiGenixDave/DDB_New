using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEventVariableEditor : Form
    {
        EventVariableDB ev;

        public FormEventVariableEditor(EventVariableDB e)
        {
            InitializeComponent();

            this.ev = e;
        }

        private FormEventVariableEditor()
        {
        }


        public EventVariableDB GetEditedEventVariable()
        {
            //ev.name = tBoxEventName.Text;
            //ev.embeddedName = tBoxDefineName.Text;
            //ev.logFKey = cBoxEventLogs.SelectedIndex;
            //ev.structFKey = cBoxEventStructs.SelectedIndex;
            return ev;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Event Variable", ev.dispName))
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
#if TODO
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxEventName.Text.Length > 0) && (tBoxEventName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxEventName.Text, tBoxEventName.Font);

                tBoxEventName.Width = size.Width + 10;
                tBoxEventName.Height = size.Height;
            }
#endif
        }

        private void tBoxDefineName_TextChanged(object sender, EventArgs e)
        {
#if TODO
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxDefineName.Text.Length > 0) && (tBoxDefineName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxDefineName.Text, tBoxDefineName.Font);

                tBoxDefineName.Width = size.Width + 10;
                tBoxDefineName.Height = size.Height;
            }
#endif
        }


     }
}