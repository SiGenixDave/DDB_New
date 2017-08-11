using System;
using System.Windows.Forms;
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

        private int savedUnitsIndex = 0;
        private void gBoxProjUnits_Enter(object sender, EventArgs e)
        {
            lBoxProjUnits.SelectedIndex = savedUnitsIndex;
            formEnumPreview.UpdateForm(null);
            formBitmaskPreview.UpdateForm(null);
        }

        private void gBoxProjUnits_Leave(object sender, EventArgs e)
        {
            savedUnitsIndex = lBoxProjUnits.SelectedIndex;
            lBoxProjUnits.SelectedIndex = -1;
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
                UnitsTest u = (UnitsTest)lBoxProjUnits.SelectedItems[indexCount];
                u.name = "Copy of " + u.name;
                UnitsTestList.AddUnits(u);
                lBoxProjUnits.Items.Add(u);
                indexCount++;
            }
        }

        private void ModifyUnits()
        {
            UnitModifyObject unitModify = new UnitModifyObject((UnitsTest)lBoxProjUnits.SelectedItem);
            if (unitModify.GetUserAcceptance())
            {
                UnitsTest modifiedUnit = unitModify.GetUnit();
                lBoxProjUnits.Items[lBoxProjUnits.SelectedIndex] = modifiedUnit;
                UnitsTestList.ModifyUnits(modifiedUnit);
            }
        }

        private void CreateUnits()
        {
            UnitCreateObject unitCreate = new UnitCreateObject();
            if (unitCreate.GetUserAcceptance())
            {
                UnitsTest u = UnitsTestList.AddUnits(unitCreate.GetUnitName());
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
            List<UnitsTest> unitsToDelete = new List<UnitsTest>();
            while (indexCount < lBoxProjUnits.SelectedIndices.Count)
            {
                unitsToDelete.Add((UnitsTest)(lBoxProjUnits.SelectedItems[indexCount]));
                indexCount++;
            }

            while (unitsToDelete.Count != 0)
            {
                UnitsTestList.Delete(unitsToDelete[0]);
                unitsToDelete.RemoveAt(0);
            }

            PopulateUnits(prevSelected);
        }
    }
}