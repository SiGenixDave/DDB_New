using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace DDB
{
    public partial class FormMain
    {
        private void InitProjectSettings()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(this.Font, FontStyle.Bold);
            dGridURL.Columns[0].HeaderCell.Style = style;
            dGridURL.Columns[1].HeaderCell.Style = style;
            dGridEventLog.Columns[0].HeaderCell.Style = style;
            dGridEventLog.Columns[1].HeaderCell.Style = style;
        }

        private void cBoxCommType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCommType.SelectedIndex == 0)
            {
                gBoxURLs.Visible = false;
                gBoxTargetCommunication.Size = new Size(150, 100);
            }
            else
            {
                gBoxURLs.Visible = true;
                gBoxTargetCommunication.Size = new Size(462, 224);
            }

        }

        private void cListBoxFunctionFlags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cListBoxFunctionFlags.SelectedIndex == 4)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    dGridURL.Columns[1].Visible = true;
                }
                else
                {
                    dGridURL.Columns[1].Visible = false;
                }
            }
        }


        private void btnProjSettingsAddURL_Click(object sender, EventArgs e)
        {
            AddNewURL();
        }

        private void addNewURLMenuItem_Click(object sender, EventArgs e)
        {
            AddNewURL();
        }

        private void deleteURLMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUrls();
        }

        private void btnProjSettingsAddEventLog_Click(object sender, EventArgs e)
        {
            AddNewEventLog();
        }

        private void addNewEventLogMenuItem_Click(object sender, EventArgs e)
        {
            AddNewEventLog();
        }

        private void deleteEventLogMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEventLogs();
        }

        private void AddNewURL()
        {
            int index = dGridURL.Rows.Add("New URL", "New URL {Alias}");
            dGridURL.CurrentCell = dGridURL.Rows[index].Cells[0];
            dGridURL.BeginEdit(true);
        }

        private void DeleteUrls()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected URL(stl)?",
                                  "Delete URL(stl) Confirmation",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            foreach (DataGridViewRow item in dGridURL.SelectedRows)
            {
                dGridURL.Rows.RemoveAt(item.Index);
            }
        }

        private void AddNewEventLog()
        {
            // Scan the datagridView for the highest value and insert the next highest and select
            // the cell with description
            int highestValue = int.MinValue;

            int rowindex = 0;
            foreach (DataGridViewRow r in dGridEventLog.Rows)
            {
                int i;
                int.TryParse(r.Cells[0].Value.ToString(), out i);
                if (i > highestValue)
                {
                    highestValue = i;
                }
                rowindex++;
            }


            DataGridViewRow row = (DataGridViewRow)dGridEventLog.Rows[0].Clone();
            row.Cells[0].Value = highestValue + 1;
            row.Cells[1].Value = "New Event Log";
            dGridEventLog.Rows.Add(row);
            dGridEventLog.CurrentCell = dGridEventLog.Rows[rowindex].Cells[1];
            dGridEventLog.BeginEdit(true);
        }

        private void DeleteEventLogs()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected Event Log(stl)?",
                                  "Delete Event Log(stl) Confirmation",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            foreach (DataGridViewRow item in dGridEventLog.SelectedRows)
            {
                dGridEventLog.Rows.RemoveAt(item.Index);
            }
        }

        private void SaveEventLogs()
        {
            List<EventLogDB> eList = new List<EventLogDB>();
            EventLogDB.key = 0;
            foreach (DataGridViewRow r in dGridEventLog.Rows)
            {
                int embValue;
                int.TryParse(r.Cells[0].Value.ToString(), out embValue);

                String name = r.Cells[1].Value.ToString();
                EventLogDB e = new EventLogDB(name, embValue);
                eList.Add(e);
            }

            EventLogList.Update(eList.ToArray());
        }

    }
}
