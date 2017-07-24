using System;
using System.Windows.Forms;
using DDB.Test;
using System.Collections.Generic;

namespace DDB
{
    public partial class FormMain
    {
        private void btnProUnitsCreate_Click(object sender, EventArgs e)
        {
            CreateUnits();
        }

        private void btnProUnitsCopy_Click(object sender, EventArgs e)
        {
            CopyUnits();
        }

        private void btnProUnitsModify_Click(object sender, EventArgs e)
        {
            ModifyUnits();
        }

        private void btnProUnitsDelete_Click(object sender, EventArgs e)
        {
            DeleteUnits();
        }

        private void btnProjUnitsImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Units");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        private void lBoxProjUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxProjUnits.SelectedIndices.Count == 0)
            {
                btnProUnitsModify.Enabled = false;
                btnProUnitsCopy.Enabled = false;
                btnProUnitsDelete.Enabled = false;
            }
            else if (lBoxProjUnits.SelectedIndices.Count == 1)
            {
                conMenuUnits.Items[1].Enabled = true;

                btnProUnitsModify.Enabled = true;
                btnProUnitsCopy.Enabled = true;
                btnProUnitsDelete.Enabled = true;
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuUnits.Items[1].Enabled = false;

                btnProUnitsModify.Enabled = false;
                btnProUnitsCopy.Enabled = true;
                btnProUnitsDelete.Enabled = true;
            }
        }

        private void copyUnitsMenuItem1_Click(object sender, EventArgs e)
        {
            CopyUnits();
        }

        private void modifyUnitsMenuItem_Click(object sender, EventArgs e)
        {
            ModifyUnits();
        }

        private void deleteUnitsMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUnits();
        }

        private void CopyUnits()
        {
            int indexCount = 0;
            while (indexCount < lBoxProjUnits.SelectedIndices.Count)
            {
                String u = UnitsTest.GetUnit(lBoxProjUnits.SelectedIndices[indexCount]);
                u = "Copy of " + u;
                UnitsTest.AddUnits(u);
                lBoxProjUnits.Items.Add(u);
                indexCount++;
            }
        }

        private void ModifyUnits()
        {
            UnitModifyObject unitModify = new UnitModifyObject(lBoxProjUnits.SelectedItem.ToString());
            if (unitModify.GetUserAcceptance())
            {
                String modifiedUnitName = unitModify.GetUnit();
                lBoxProjUnits.Items[lBoxProjUnits.SelectedIndex] = modifiedUnitName;
                UnitsTest.ModifyUnits(lBoxProjUnits.SelectedIndex, modifiedUnitName);
            }
        }

        private void CreateUnits()
        {
            UnitCreateObject unitCreate = new UnitCreateObject();
            if (unitCreate.GetUserAcceptance())
            {
                String newUnitName = unitCreate.GetUnit();
                UnitsTest.AddUnits(newUnitName);
                lBoxProjUnits.Items.Add(newUnitName);
            }
        }

        private void DeleteUnits()
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
            List<String> unitsToDelete = new List<String>();
            while (indexCount < lBoxProjUnits.SelectedIndices.Count)
            {
                unitsToDelete.Add(UnitsTest.GetUnit(lBoxProjUnits.SelectedIndices[indexCount]));
                indexCount++;
            }

            while (unitsToDelete.Count != 0)
            {
                UnitsTest.Delete(unitsToDelete[0]);
                unitsToDelete.RemoveAt(0);
            }


            PopulateUnits();
        }
    }
}