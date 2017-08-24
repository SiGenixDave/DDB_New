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
                btnProjEnumsLinks.Enabled = false;
            }
            else if (lBoxProjEnums.SelectedIndices.Count == 1)
            {
                conMenuEnums.Items[1].Enabled = true;

                btnProjEnumsModify.Enabled = true;
                btnProjEnumsCopy.Enabled = true;
                btnProjEnumsDelete.Enabled = true;
                btnProjEnumsLinks.Enabled = true;

                formEnumPreview.UpdateForm(EnumList.GetVar(lBoxProjEnums.SelectedIndex));
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuEnums.Items[1].Enabled = false;

                btnProjEnumsModify.Enabled = false;
                btnProjEnumsCopy.Enabled = true;
                btnProjEnumsDelete.Enabled = true;
                btnProjEnumsLinks.Enabled = true;
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
            ModifyEnums(false);
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
            ModifyEnums(false);
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
            ModifyEnums(false);
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

                Enums enm = (Enums)lBoxProjEnums.SelectedItems[indexCount];
                enm = EnumList.CreateVar(enm.dispName, enm.intValues.ToArray(), enm.strValues.ToArray());
                enm.dispName = "Copy of " + enm.dispName;
                EnumList.AddVar(enm);
                lBoxProjEnums.Items.Add(enm);
                indexCount++;
            }
        }

        private Boolean ModifyEnums(Boolean modifyNewEnum)
        {
            Enums emt = EnumList.GetVar(lBoxProjEnums.SelectedIndex);

            using (FormEnumsEditor emEdit = new FormEnumsEditor(emt, modifyNewEnum))
            {
                DialogResult dr = emEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    formEnumPreview.UpdateForm((Enums)lBoxProjEnums.SelectedItem);

                    PopulateEnums(lBoxProjEnums.SelectedIndex);

                    return true;

                }
            }

            return false;
        }

        private void CreateEnums()
        {
            Enums et = EnumList.CreateVar("New Enum", new int[] {0}, new String[] {"Description"});
            lBoxProjEnums.Items.Add(et);
            EnumList.AddVar(et);

            // Needed to restore selected items if user aborts
            List<int> selEnums = new List<int>();
            int indexCount = 0;
            while (indexCount < lBoxProjEnums.SelectedIndices.Count)
            {
                selEnums.Add(lBoxProjEnums.SelectedIndices[indexCount]);
                indexCount++;
            }

            // For some reason, one must set the listbox SelectedIndex to -1 prior to changing the listbox index programatically???
            lBoxProjEnums.SelectedIndex = -1;
            lBoxProjEnums.SelectedIndex = lBoxProjEnums.Items.Count - 1;
            if (!ModifyEnums(true))
            {
               lBoxProjEnums.Items.Remove(et);
                EnumList.DeleteVar(et);

                // Restore the selected index(s) prior to the cancel
                indexCount = 0;
                lBoxProjEnums.SelectedIndices.Clear();
                while (indexCount < selEnums.Count)
                {
                    lBoxProjEnums.SelectedIndices.Add(selEnums[indexCount]);
                    indexCount++;
                }
            }


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
            List<Enums> enumsToDelete = new List<Enums>();
            while (indexCount < lBoxProjEnums.SelectedIndices.Count)
            {
                enumsToDelete.Add((Enums)(lBoxProjEnums.SelectedItems[indexCount]));
                indexCount++;
            }

            while (enumsToDelete.Count != 0)
            {
                EnumList.DeleteVar(enumsToDelete[0]);
                enumsToDelete.RemoveAt(0);
            }

            PopulateEnums(prevIndex);
        }



    }
}