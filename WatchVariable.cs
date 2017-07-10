using System;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain
    {
        private void UpdateWatchVarDisplay(int index)
        {
            if (index != -1)
            {
                WatchVarTest w = WatchVarList.GetWatchVar(index);
                tBoxWatchDisplayName.Text = w.dispName;
                tBoxWatchEmbName.Text = w.embName;
                tBoxWatchMinChart.Text = w.minChart.ToString();
                tBoxWatchMaxChart.Text = w.maxChart.ToString();
                tBoxWatchMinValue.Text = w.minVal.ToString();
                tBoxWatchMaxValue.Text = w.maxVal.ToString();
                cBoxWatchDataType.SelectedIndex = w.type;
                cBoxWatchUnits.SelectedIndex = w.units;
                cBoxWatchReadWriteFlags.SelectedIndex = w.readWrite;
                tBoxWatchHelpText.Text = w.helpText;
                lBoxWatchVariables.SelectedIndex = index;
            }
            else
            {
                tBoxWatchDisplayName.Text = "";
                tBoxWatchEmbName.Text = "";
                tBoxWatchMinChart.Text = "";
                tBoxWatchMaxChart.Text = "";
                tBoxWatchMinValue.Text = "";
                tBoxWatchMaxValue.Text = "";
                cBoxWatchDataType.SelectedIndex = 0;
                cBoxWatchUnits.SelectedIndex = 0;
                cBoxWatchReadWriteFlags.SelectedIndex = 0;
                tBoxWatchHelpText.Text = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyWatchVar();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchModifyInProgress();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteWatchVar();
        }

        private void lBoxWatchVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxWatchVariables.SelectedIndices.Count == 0)
            {
                UpdateWatchVarDisplay(-1);
                btnWatchModify.Enabled = false;
                btnWatchDelete.Enabled = false;
                btnWatchCopy.Enabled = false;

                conMenuWatchVarList.Items[1].Enabled = false;
            
            }
            else if (lBoxWatchVariables.SelectedIndices.Count == 1)
            {
                UpdateWatchVarDisplay(lBoxWatchVariables.SelectedIndex);
                
                conMenuWatchVarList.Items[1].Enabled = true;
                
                btnWatchModify.Enabled = true;
                btnWatchDelete.Enabled = true;
                btnWatchCopy.Enabled = true;
            }
            else
            {
                // Disable the "Modify" in context menu
                conMenuWatchVarList.Items[1].Enabled = false;
                
                btnWatchModify.Enabled = false;
                btnWatchDelete.Enabled = true;
                btnWatchCopy.Enabled = true;
                // Set the contents of the Watch Info based on the first selected index
                int firstSelectedIndex = int.MaxValue;
                int indexCount = 0;
                while (indexCount < lBoxWatchVariables.SelectedIndices.Count)
                {
                    if (lBoxWatchVariables.SelectedIndices[indexCount] < firstSelectedIndex)
                    {
                        firstSelectedIndex = lBoxWatchVariables.SelectedIndices[indexCount];
                    }
                    indexCount++;
                }

                UpdateWatchVarDisplay(firstSelectedIndex);


            }

        }

        private void btnWatchModify_Click(object sender, EventArgs e)
        {
            WatchModifyInProgress();
        }

        private void btnWatchCreate_Click(object sender, EventArgs e)
        {
            WatchVarCreate();
        }

        private void btnWatchCopy_Click(object sender, EventArgs e)
        {
            CopyWatchVar();
        }

        private void btnWatchDelete_Click(object sender, EventArgs e)
        {
            DeleteWatchVar();
        }

        private void btnWatchSortAtoZ_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnWatchSortZtoA_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnWatchFilterApply_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void btnWatchAccept_Click(object sender, EventArgs e)
        {
            if (newVarBeingCreated)
            {
                WatchVarTest w = new WatchVarTest(tBoxWatchDisplayName.Text, tBoxWatchEmbName.Text, Convert.ToInt32(tBoxWatchMinChart.Text),
                                            Convert.ToInt32(tBoxWatchMaxChart.Text), Convert.ToInt32(tBoxWatchMinValue.Text),
                                            Convert.ToInt32(tBoxWatchMaxValue.Text), cBoxWatchUnits.SelectedIndex,
                                            cBoxWatchDataType.SelectedIndex, cBoxWatchUnits.SelectedIndex, tBoxWatchHelpText.Text);
                WatchVarList.AddVar(w);
            }
            else
            {
                // This will update the object reference
                WatchVarTest w = WatchVarList.GetWatchVar(lBoxWatchVariables.SelectedIndex);
                w.dispName = tBoxWatchDisplayName.Text;
                w.embName = tBoxWatchEmbName.Text;
                w.minChart = Convert.ToInt32(tBoxWatchMinChart.Text);
                w.maxChart = Convert.ToInt32(tBoxWatchMaxChart.Text);
                w.minVal =  Convert.ToInt32(tBoxWatchMinValue.Text);
                w.maxVal = Convert.ToInt32(tBoxWatchMaxValue.Text);
                w.units = cBoxWatchUnits.SelectedIndex;
                w.type = cBoxWatchDataType.SelectedIndex;
                w.units = cBoxWatchUnits.SelectedIndex;
                w.helpText = tBoxWatchHelpText.Text;

            }
            AcceptOrCancelModification();
        }

        private void btnWatchCancel_Click(object sender, EventArgs e)
        {
            // Restore the original attributes
            UpdateWatchVarDisplay(lBoxWatchVariables.SelectedIndex);

            AcceptOrCancelModification();
        }

        private void WatchModifyInProgress()
        {
            btnWatchModify.Enabled = false;
            btnWatchCreate.Enabled = false;
            btnWatchCopy.Enabled = false;
            btnWatchDelete.Enabled = false;
            grpBoxWatchVarList.Enabled = false;
            grpBoxWatchAttrs.Enabled = true;
        }

        private bool newVarBeingCreated;

        private void WatchVarCreate()
        {
            newVarBeingCreated = true;
            PopulateNewVarDefaults();
            WatchModifyInProgress();
        }

        private void AcceptOrCancelModification()
        {
            grpBoxWatchVarList.Enabled = true;
            grpBoxWatchAttrs.Enabled = false;
            btnWatchModify.Enabled = true;
            btnWatchCreate.Enabled = true;
            btnWatchCopy.Enabled = true;
            btnWatchDelete.Enabled = true;
            newVarBeingCreated = false;
            RefreshWatchVariableList(lBoxWatchVariables.SelectedIndex);
        }

        private void PopulateNewVarDefaults()
        {
            tBoxWatchDisplayName.Text = "New Display Var Name";
            tBoxWatchEmbName.Text = "New Embedded Var Name";
            tBoxWatchMinChart.Text = "0";
            tBoxWatchMaxChart.Text = "255";
            tBoxWatchMinValue.Text = "0";
            tBoxWatchMaxValue.Text = "255";
            cBoxWatchDataType.SelectedIndex = 0;
            cBoxWatchUnits.SelectedIndex = 0;
            cBoxWatchReadWriteFlags.SelectedIndex = 0;
        }

        private void RefreshWatchVariableList(int prevIndex)
        {
            lBoxWatchVariables.Items.Clear();
            int index = 0;
            WatchVarTest w;
            while (index < WatchVarList.GetWatchVarCount())
            {
                w = WatchVarList.GetWatchVar(index);
                lBoxWatchVariables.Items.Add(w.dispName);
                index++;
            }

            UpdateWatchVarDisplay(prevIndex);
        }

        private void CopyWatchVar()
        {
            int indexCount = 0;
            while (indexCount < lBoxWatchVariables.SelectedIndices.Count)
            {
                WatchVarTest w = WatchVarList.GetWatchVarCopy(lBoxWatchVariables.SelectedIndices[indexCount]);
                w.embName = "Copy of " + w.embName;
                w.dispName = "Copy of " + w.dispName;
                WatchVarList.AddVar(w); 
                indexCount++;
            }

            RefreshWatchVariableList(WatchVarList.GetWatchVarCount() - 1);
        }

        private void DeleteWatchVar()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected variable(s)?",
                                              "Delete Variable(s) Confirmation", 
                                              MessageBoxButtons.OKCancel, 
                                              MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int indexCount = 0;
            while (indexCount < lBoxWatchVariables.SelectedIndices.Count)
            {
                WatchVarTest w = WatchVarList.GetWatchVar(lBoxWatchVariables.SelectedIndices[indexCount]);
                WatchVarList.DeleteVar(w);
                
                indexCount++;
            }

            int numWatchVars = WatchVarList.GetWatchVarCount();
            if (lBoxWatchVariables.SelectedIndex < numWatchVars)
            {
                RefreshWatchVariableList(lBoxWatchVariables.SelectedIndex);
            }
            else
            {
                RefreshWatchVariableList(lBoxWatchVariables.SelectedIndex - 1);
            }
        }


    }
}