using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain
    {
        private void btnProBitmasksModify_Click(object sender, EventArgs e)
        {
            ModifyBitmasks();
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

        private void lBoxProjBitmasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxProjBitmasks.SelectedIndices.Count == 0)
            {
                btnProBitmasksModify.Enabled = false;
                btnProBitmasksCopy.Enabled = false;
                btnProBitmasksDelete.Enabled = false;
            }
            else if (lBoxProjBitmasks.SelectedIndices.Count == 1)
            {
                conMenuBitmasks.Items[1].Enabled = true;

                btnProBitmasksModify.Enabled = true;
                btnProBitmasksCopy.Enabled = true;
                btnProBitmasksDelete.Enabled = true;
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuBitmasks.Items[1].Enabled = false;

                btnProBitmasksModify.Enabled = false;
                btnProBitmasksCopy.Enabled = true;
                btnProBitmasksDelete.Enabled = true;
            }
        }

        private void copyBitmasksMenuItem_Click(object sender, EventArgs e)
        {
            CopyBitmasks();
        }

        private void modifyBitmasksMenuItem_Click(object sender, EventArgs e)
        {
            ModifyBitmasks();
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

                BitmaskTest bt = new BitmaskTest(BitmaskVarList.GetVar(lBoxProjBitmasks.SelectedIndices[indexCount]));
                String b = bt.dispName;
                b = "Copy of " + b;
                bt.dispName = b;
                BitmaskVarList.AddVar(bt);
                lBoxProjBitmasks.Items.Add(b);
                indexCount++;
            }
        }

        private void ModifyBitmasks()
        {
            BitmaskTest bmt = BitmaskVarList.GetVar(lBoxProjBitmasks.SelectedIndex);

            FormBitmaskEditor bmEdit = new FormBitmaskEditor(bmt);
            bmEdit.ShowDialog();
        }

        private void CreateBitmasks()
        {
            BitmaskTest bmt = new BitmaskTest("New Bitmask");
            lBoxProjBitmasks.Items.Add(bmt.dispName);
            BitmaskVarList.AddVar(bmt);
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

            int indexCount = 0;
            List<BitmaskTest> bmsToDelete = new List<BitmaskTest>();
            while (indexCount < lBoxProjBitmasks.SelectedIndices.Count)
            {
                bmsToDelete.Add(BitmaskVarList.GetVar(lBoxProjBitmasks.SelectedIndices[indexCount]));
                indexCount++;
            }

            while (bmsToDelete.Count != 0)
            {
                BitmaskVarList.DeleteVar(bmsToDelete[0]);
                bmsToDelete.RemoveAt(0);
            }

            PopulateBitmasks();
        }

    }
}