using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DDB
{
    public partial class FormMain
    {
        private void lBoxProjEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxProjEnums.SelectedIndices.Count == 0)
            {
                btnProjEnumsModify.Enabled = false;
                btnProjEnumsCopy.Enabled = false;
                btnProjEnumsDelete.Enabled = false;
            }
            else if (lBoxProjEnums.SelectedIndices.Count == 1)
            {
                conMenuEnums.Items[1].Enabled = true;

                btnProjEnumsModify.Enabled = true;
                btnProjEnumsCopy.Enabled = true;
                btnProjEnumsDelete.Enabled = true;

                formEnumPreview.UpdateForm(EnumVarList.GetVar(lBoxProjEnums.SelectedIndex));
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuEnums.Items[1].Enabled = false;

                btnProjEnumsModify.Enabled = false;
                btnProjEnumsCopy.Enabled = true;
                btnProjEnumsDelete.Enabled = true;
            }

        }

        private int savedEnums = 0;
        private void gBoxProjEnums_Enter(object sender, EventArgs e)
        {
            lBoxProjEnums.SelectedIndex = savedEnums;
            formBitmaskPreview.UpdateForm(null);
        }

        private void gBoxProjEnums_Leave(object sender, EventArgs e)
        {
            savedEnums = lBoxProjEnums.SelectedIndex;
            lBoxProjEnums.SelectedIndex = -1;
        }


        private void lBoxProjEnums_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyEnums();
        }

        private void btnProjEnumsImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Enumerations");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        private void btnProjEnumsDelete_Click(object sender, EventArgs e)
        {
            DeleteEnums();
        }

        private void btnProjEnumsModify_Click(object sender, EventArgs e)
        {
            ModifyEnums();
        }

        private void btnProjEnumsCopy_Click(object sender, EventArgs e)
        {
            CopyEnums();
        }

        private void btnProjEnumsCreate_Click(object sender, EventArgs e)
        {
            CreateEnums();
        }

        private void copyEnumsMenuItem_Click(object sender, EventArgs e)
        {
            CopyEnums();
        }

        private void modifyEnumsMenuItem_Click(object sender, EventArgs e)
        {
            ModifyEnums();
        }

        private void deleteEnumsMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEnums();
        }

        private void CopyEnums()
        {
            int indexCount = 0;
            while (indexCount < lBoxProjEnums.SelectedIndices.Count)
            {

                EnumsTest enm = new EnumsTest(EnumVarList.GetVar(lBoxProjEnums.SelectedIndices[indexCount]));
                String b = enm.dispName;
                b = "Copy of " + b;
                enm.dispName = b;
                EnumVarList.AddVar(enm);
                lBoxProjEnums.Items.Add(b);
                indexCount++;
            }
        }

        private void ModifyEnums()
        {
            int savedIndex = lBoxProjEnums.SelectedIndex;

            EnumsTest emt = EnumVarList.GetVar(lBoxProjEnums.SelectedIndex);

            FormEnumsEditor enumEdit = new FormEnumsEditor(emt);
            enumEdit.ShowDialog();

            formEnumPreview.UpdateForm(EnumVarList.GetVar(lBoxProjEnums.SelectedIndex));

            PopulateEnums(lBoxProjEnums.SelectedIndex);

            lBoxProjEnums.SelectedIndex = savedIndex;
        }

        private void CreateEnums()
        {
            EnumsTest et = new EnumsTest("New Enum", new int[] {0}, new String[] {"eName"});
            lBoxProjEnums.Items.Add(et.dispName);
            EnumVarList.AddVar(et);
        }

        private void DeleteEnums()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected enumeration(s)?",
                                  "Delete Enumeration(s) Confirmation",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int prevIndex = lBoxProjEnums.SelectedIndices[0];

            int indexCount = 0;
            List<EnumsTest> enumsToDelete = new List<EnumsTest>();
            while (indexCount < lBoxProjEnums.SelectedIndices.Count)
            {
                enumsToDelete.Add(EnumVarList.GetVar(lBoxProjEnums.SelectedIndices[indexCount]));
                indexCount++;
            }

            while (enumsToDelete.Count != 0)
            {
                EnumVarList.DeleteVar(enumsToDelete[0]);
                enumsToDelete.RemoveAt(0);
            }

            PopulateEnums(prevIndex);
        }



    }
}