using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DDB
{
    public partial class FormMain
    {
        private void btnProjUnitsCreate_Click(object sender, EventArgs e)
        {
            CreateUnits();
        }

        private void btnProjUnitsCopy_Click(object sender, EventArgs e)
        {
            CopyUnits();
        }

        private void btnProjUnitsModify_Click(object sender, EventArgs e)
        {
            ModifyUnits();
        }

        private void btnProUnitsDelete_Click(object sender, EventArgs e)
        {
            DeleteUnits();
        }

        private void lBoxProjUnits_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyUnits();
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
                btnProUnitsLinks.Enabled = false;
            }
            else if (lBoxProjUnits.SelectedIndices.Count == 1)
            {
                conMenuUnits.Items[1].Enabled = true;

                btnProUnitsModify.Enabled = true;
                btnProUnitsCopy.Enabled = true;
                btnProUnitsDelete.Enabled = true;
                btnProUnitsLinks.Enabled = true;

            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuUnits.Items[1].Enabled = false;

                btnProUnitsModify.Enabled = false;
                btnProUnitsCopy.Enabled = true;
                btnProUnitsDelete.Enabled = true;
                btnProUnitsLinks.Enabled = true;
            }
        }

        private void gBoxProjUnits_Enter(object sender, EventArgs e)
        {
            formEnumPreview.UpdateForm(null);
            formBitmaskPreview.UpdateForm(null);
        }

        private void gBoxProjUnits_Leave(object sender, EventArgs e)
        {
            lBoxProjUnits.SelectedIndex = -1;
        }


        private void copyUnitsMenuItem_Click(object sender, EventArgs e)
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
                Units u = (Units)lBoxProjUnits.SelectedItems[indexCount];
                Units myNewUnit = new Units("Copy of " + u.name, true);
                UnitsList.AddUnits(myNewUnit);
                lBoxProjUnits.Items.Add(myNewUnit);
                indexCount++;
            }
        }

        private void ModifyUnits()
        {
            UnitModifyObject unitModify = new UnitModifyObject((Units)lBoxProjUnits.SelectedItem);
            if (unitModify.GetUserAcceptance())
            {
                Units modifiedUnit = unitModify.GetUnit();
                lBoxProjUnits.Items[lBoxProjUnits.SelectedIndex] = modifiedUnit;
            }
        }

        private void CreateUnits()
        {
            UnitCreateObject unitCreate = new UnitCreateObject();
            if (unitCreate.GetUserAcceptance())
            {
                Units u = unitCreate.GetUnit();
                UnitsList.AddUnits(u);
                lBoxProjUnits.Items.Add(u);
            }
        }

        private void DeleteUnits()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected Unit(s)?",
                                  "Delete Units(s) Confirmation",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int prevSelected = lBoxProjUnits.SelectedIndices[0];

            int indexCount = 0;
            List<Units> unitsToDelete = new List<Units>();
            while (indexCount < lBoxProjUnits.SelectedIndices.Count)
            {
                unitsToDelete.Add((Units)(lBoxProjUnits.SelectedItems[indexCount]));
                indexCount++;
            }

            while (unitsToDelete.Count != 0)
            {
                UnitsList.Delete(unitsToDelete[0]);
                unitsToDelete.RemoveAt(0);
            }

            PopulateUnits(prevSelected);
        }
    }
}