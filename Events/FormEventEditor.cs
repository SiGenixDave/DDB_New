﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEventEditor : Form
    {
        EventTest ev;
        String helpText;

        public FormEventEditor(EventTest e)
        {
            InitializeComponent();

            PopulateEventStructures();
            PopulateEventLogs();

            this.ev = e;
            tBoxEventName.Text = ev.name;
            tBoxDefineName.Text = ev.cDefineName;
            cBoxEventLogs.SelectedIndex = ev.logId;
            cBoxEventStructs.SelectedIndex = ev.structId;
            helpText = ev.helpText;

            if (GlobalSettings.getCustomerUseOnly())
            {
                tBoxEventName.Enabled = false;
                tBoxDefineName.Enabled = false;
                cBoxEventLogs.Enabled = false;
                cBoxEventStructs.Enabled = false;
            }
        }

        private FormEventEditor()
        {
        }


        public EventTest GetEditedEvent()
        {
            ev.name = tBoxEventName.Text;
            ev.cDefineName = tBoxDefineName.Text;
            ev.logId = cBoxEventLogs.SelectedIndex;
            ev.structId = cBoxEventStructs.SelectedIndex;
            ev.helpText = helpText;

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

                tBoxEventName.Width = size.Width;
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
            foreach (EventStructureTest e in EventInfoTest.GetEventStructures())
            {
                cBoxEventStructs.Items.Add(e.name);
            }
        }


        private void PopulateEventLogs()
        {
            cBoxEventLogs.Items.Add("Propulsion");
            cBoxEventLogs.Items.Add("Engineering");
        }

        private void btnWatchModifyHelpText_Click(object sender, EventArgs e)
        {
            FormHelpText fh = new FormHelpText(null);
            fh.ShowDialog();
        }
    }
}