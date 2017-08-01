using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace DDB
{
    public partial class FormMain
    {
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

            URLAliasColumnVisibility();
        }

        private void cListBoxFunctionFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cListBoxFunctionFlags.SelectedIndex == 4)
            {
                URLAliasColumnVisibility();
            }

        }

        private void URLAliasColumnVisibility()
        {
            if (cListBoxFunctionFlags.GetItemChecked(4))
            {
                dGridURL.Columns[1].Visible = true;
            }
            else
            {
                dGridURL.Columns[1].Visible = false;
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
            DeleteItems();
        }

        private void AddNewURL()
        {
            int index = dGridURL.Rows.Add("New URL", "New URL {Alias}");
            dGridURL.CurrentCell = dGridURL.Rows[index].Cells[0];
            dGridURL.BeginEdit(true);
        }

        private void DeleteItems()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected URL(s)?",
                                  "Delete URL(s) Confirmation",
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
    }
}
