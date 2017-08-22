﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain
    {
        private void btnProBitmasksModify_Click(object sender, EventArgs e)
        {
            ModifyBitmasks(false);
        }

        private void btnProBitmasksCreate_Click(object sender, EventArgs e)
        {
            CreateBitmasks();
        }

        private void btnProBitmasksCopy_Click(object sender, EventArgs e)
        {
            CopyBitmasks();
        }

        private void btnProBitmasksDelete_Click(object sender, EventArgs e)
        {
            DeleteBitmasks();
        }

        private void btnProBitmasksImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Bitmasks");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        private void lBoxProjBitmasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyBitmasks(false);
        }

        private void lBoxProjBitmasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxProjBitmasks.SelectedIndices.Count == 0)
            {
                btnProBitmasksModify.Enabled = false;
                btnProBitmasksCopy.Enabled = false;
                btnProBitmasksDelete.Enabled = false;
                btnProBitmasksLinks.Enabled = false;
            }
            else if (lBoxProjBitmasks.SelectedIndices.Count == 1)
            {
                conMenuBitmasks.Items[1].Enabled = true;

                btnProBitmasksModify.Enabled = true;
                btnProBitmasksCopy.Enabled = true;
                btnProBitmasksDelete.Enabled = true;
                btnProBitmasksLinks.Enabled = true;

                formBitmaskPreview.UpdateForm((BitmaskTest)lBoxProjBitmasks.SelectedItem);
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuBitmasks.Items[1].Enabled = false;

                btnProBitmasksModify.Enabled = false;
                btnProBitmasksCopy.Enabled = true;
                btnProBitmasksDelete.Enabled = true;
                btnProBitmasksLinks.Enabled = true;
            }
        }

        private int savedBitmaskIndex = 0;
        private void gBoxProjBitmask_Enter(object sender, EventArgs e)
        {
            lBoxProjBitmasks.SelectedIndex = savedBitmaskIndex;
            formEnumPreview.UpdateForm(null);
        }

        private void gBoxProjBitmask_Leave(object sender, EventArgs e)
        {
            savedBitmaskIndex = lBoxProjBitmasks.SelectedIndex;
            lBoxProjBitmasks.SelectedIndex = -1;
        }


        private void copyBitmasksMenuItem_Click(object sender, EventArgs e)
        {
            CopyBitmasks();
        }

        private void modifyBitmasksMenuItem_Click(object sender, EventArgs e)
        {
            ModifyBitmasks(false);
        }

        private void deleteBitmasksMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBitmasks();
        }

        private void CopyBitmasks()
        {
            int indexCount = 0;
            while (indexCount < lBoxProjBitmasks.SelectedIndices.Count)
            {
                BitmaskTest bt = new BitmaskTest((BitmaskTest)lBoxProjBitmasks.SelectedItems[indexCount]);
                String b = bt.dispName;
                b = "Copy of " + b;
                bt.dispName = b;
                BitmaskVarList.AddVar(bt);
                lBoxProjBitmasks.Items.Add(bt);
                indexCount++;
            }
        }

        private Boolean ModifyBitmasks(Boolean createNewBitmask)
        {
            BitmaskTest bmt = BitmaskVarList.GetVar(lBoxProjBitmasks.SelectedIndex);

            using (FormBitmaskEditor bmEdit = new FormBitmaskEditor(bmt, createNewBitmask))
            {
                DialogResult dr = bmEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    formBitmaskPreview.UpdateForm((BitmaskTest)lBoxProjBitmasks.SelectedItem);

                    PopulateBitmasks(lBoxProjBitmasks.SelectedIndex);

                    return true;

                }
            }

            return false;
        }

        private void CreateBitmasks()
        {
            BitmaskTest bmt = BitmaskVarList.CreateVar("New Bitmask");
            lBoxProjBitmasks.Items.Add(bmt);

            // Used to restore the selected bitmasks if the user decides to ABort the creation of a new variable
            List<int> selBMs = new List<int>();
            int indexCount = 0;
            while (indexCount < lBoxProjBitmasks.SelectedIndices.Count)
            {
                selBMs.Add(lBoxProjBitmasks.SelectedIndices[indexCount]);
                indexCount++;
            }

            // For some reason, one must set the listbox SelectedIndex to -1 prior to changing the listbox index programatically???
            lBoxProjBitmasks.SelectedIndex = -1;
            lBoxProjBitmasks.SelectedIndex = lBoxProjBitmasks.Items.Count - 1;
            if (!ModifyBitmasks(true))
            {
                lBoxProjBitmasks.Items.Remove(bmt);
                BitmaskVarList.DeleteVar(bmt);

                // Restore the selected index(s) prior to the cancel
                indexCount = 0;
                lBoxProjBitmasks.SelectedIndices.Clear();
                while (indexCount < selBMs.Count)
                {
                    lBoxProjBitmasks.SelectedIndices.Add(selBMs[indexCount]);
                    indexCount++;
                }
            }
        }

        private void DeleteBitmasks()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected bitmasks(s)?",
                                  "Delete Bitmask(s) Confirmation",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int prevIndex = lBoxProjBitmasks.SelectedIndices[0];

            int indexCount = 0;
            List<BitmaskTest> bmsToDelete = new List<BitmaskTest>();
            while (indexCount < lBoxProjBitmasks.SelectedIndices.Count)
            {
                bmsToDelete.Add((BitmaskTest)lBoxProjBitmasks.SelectedItems[indexCount]);
                indexCount++;
            }

            while (bmsToDelete.Count != 0)
            {
                BitmaskVarList.DeleteVar(bmsToDelete[0]);
                bmsToDelete.RemoveAt(0);
            }

            PopulateBitmasks(prevIndex);
        }

    }
}