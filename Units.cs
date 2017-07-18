using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDB.Test;

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

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CopyUnits();
        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyUnits();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
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
                String newUnitName= unitCreate.GetUnit();
                UnitsTest.AddUnits(newUnitName);
                lBoxProjUnits.Items.Add(newUnitName);
            }

        }

        private void DeleteUnits()
        {
            int indexCount = 0;
            while (indexCount < lBoxProjUnits.SelectedIndices.Count)
            {
                String u = UnitsTest.GetUnit(lBoxProjUnits.SelectedIndices[indexCount]);
                UnitsTest.Delete(u);
                indexCount++;
            }

            PopulateUnits();
        }

    }
}
