using System;
using System.Windows.Forms;
using System.Drawing;

namespace DDB
{
    public partial class FormMain
    {
        private void UpdateWatchVarDisplay(int index)
        {
            if (index != -1)
            {
                currentWatchVar = WatchVarList.GetWatchVar(index);
                tBoxWatchDisplayName.Text = currentWatchVar.dispName;
                tBoxWatchEmbName.Text = currentWatchVar.embName;
                tBoxWatchMinChart.Text = currentWatchVar.minChart.ToString();
                tBoxWatchMaxChart.Text = currentWatchVar.maxChart.ToString();
                tBoxWatchMinValue.Text = currentWatchVar.minVal.ToString();
                tBoxWatchMaxValue.Text = currentWatchVar.maxVal.ToString();
                cBoxWatchDataType.SelectedIndex = currentWatchVar.dataType;
                cBoxWatchScaleType.SelectedIndex = currentWatchVar.scaleType;
                cBoxWatchUnits.SelectedIndex = currentWatchVar.units;
                cBoxWatchUnitConversion.SelectedIndex = currentWatchVar.unitConversion;
                cBoxWatchReadWriteFlags.SelectedIndex = currentWatchVar.readWrite;
                cBoxWatchFormatString.SelectedIndex = currentWatchVar.formatString;
                chkWatchEngViewOnly.Checked = currentWatchVar.engineeringViewOnly == 1 ? true : false;

                EnableControlsOnSelectedScaleType(cBoxWatchScaleType.SelectedItem.ToString(), currentWatchVar);
                if (currentWatchVar.helpText == "")
                {
                    btnWatchHelpAvailable.BackColor = Color.Red;
                }
                else
                {
                    btnWatchHelpAvailable.BackColor = Color.Green;
                }


            }
            else
            {
                // Handle the case where no watch vars selected
                tBoxWatchDisplayName.Text = "";
                tBoxWatchEmbName.Text = "";
                tBoxWatchMinChart.Text = "";
                tBoxWatchMaxChart.Text = "";
                tBoxWatchMinValue.Text = "";
                tBoxWatchMaxValue.Text = "";
            }
        }

        private void EnableControlsOnSelectedScaleType(String scaleTypeTxt, WatchVarTest w)
        {
            switch (scaleTypeTxt)
            {
                case "NONE":
                    lblFormatString.Visible = false;
                    cBoxWatchFormatString.Visible = false;
                    lblWatchUnitConversion.Visible = false;
                    cBoxWatchUnitConversion.Visible = false;
                    lblWatchScaleInfo.Visible = false;
                    cBoxWatchScaleInfo.Visible = false;
                    lblWatchUnitsEnumBitmask.Text = "Units";
                    LoadUnitsIntoComboBox();
                    break;

                case "Scalar":
                    lblFormatString.Visible = true;
                    cBoxWatchFormatString.Visible = true;
                    lblWatchUnitConversion.Visible = true;
                    cBoxWatchUnitConversion.Visible = true;
                    lblWatchScaleInfo.Visible = true;
                    cBoxWatchScaleInfo.Visible = true;

                    cBoxWatchFormatString.SelectedIndex = w.formatString;
                    cBoxWatchUnitConversion.SelectedIndex = w.unitConversion;
                    cBoxWatchScaleInfo.SelectedIndex = w.scaleInfo;
                    
                    lblWatchUnitsEnumBitmask.Text = "Units";
                    LoadUnitsIntoComboBox();
                    break;

                case "Enumeration":
                    lblFormatString.Visible = false;
                    cBoxWatchFormatString.Visible = false;
                    lblWatchUnitConversion.Visible = false;
                    cBoxWatchUnitConversion.Visible = false;
                    lblWatchScaleInfo.Visible = false;
                    cBoxWatchScaleInfo.Visible = false;

                    lblWatchUnitsEnumBitmask.Text = "Enumeration";

                    LoadEnumsIntoComboBox();
                    break;

                case "Bitmask":
                    lblFormatString.Visible = false;
                    cBoxWatchFormatString.Visible = false;
                    lblWatchUnitConversion.Visible = false;
                    cBoxWatchUnitConversion.Visible = false;
                    lblWatchScaleInfo.Visible = false;
                    cBoxWatchScaleInfo.Visible = false;

                    lblWatchUnitsEnumBitmask.Text = "Bitmask";
                    LoadBitmasksIntoComboBox();
                    break;
            }


        }

        private void LoadUnitsIntoComboBox()
        {
            cBoxWatchUnits.Items.Clear();
            cBoxWatchUnits.Items.Add("NONE");
            cBoxWatchUnits.Items.Add("Amps");
            cBoxWatchUnits.Items.Add("Volts");
            cBoxWatchUnits.Items.Add("MPH");
            cBoxWatchUnits.Items.Add("m/sec2");
            cBoxWatchUnits.SelectedIndex = 0;
        }
        private void LoadEnumsIntoComboBox()
        {
            cBoxWatchUnits.Items.Clear();
            cBoxWatchUnits.Items.Add("Enum1");
            cBoxWatchUnits.Items.Add("Enum2");
            cBoxWatchUnits.Items.Add("Enum3");
            cBoxWatchUnits.Items.Add("Enum4");
            cBoxWatchUnits.SelectedIndex = 0;
        }
        private void LoadBitmasksIntoComboBox()
        {
            cBoxWatchUnits.Items.Clear();
            cBoxWatchUnits.Items.Add("Bitmask1");
            cBoxWatchUnits.Items.Add("Bitmask2");
            cBoxWatchUnits.Items.Add("Bitmask3");
            cBoxWatchUnits.Items.Add("Bitmask4");
            cBoxWatchUnits.SelectedIndex = 0;
        }


        private void btnWatchModifyHelpText_Click(object sender, EventArgs e)
        {
            WatchVarTest w;
            if (newVarBeingCreated)
            {
                w = newWatchVar;
            }
            else
            {
                w = WatchVarList.GetWatchVar(lBoxWatchVariables.SelectedIndex);
            }
            FormHelpText fh = new FormHelpText(w);
            fh.ShowDialog();
            // Code returned here after help form closes
            if (w.preAcceptHelpText == "")
            {
                btnWatchHelpAvailable.BackColor = Color.Red;
            }
            else
            {
                btnWatchHelpAvailable.BackColor = Color.Green;
            }

        }

        private void cBoxWatchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWatchVariableList(lBoxWatchVariables.SelectedIndex);
        }

        private void cBoxWatchScaleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            WatchVarTest w = newVarBeingCreated == true ? newWatchVar : currentWatchVar;
            EnableControlsOnSelectedScaleType(cBoxWatchScaleType.SelectedItem.ToString(), w);
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

        private WatchVarTest currentWatchVar;
        private void btnWatchModify_Click(object sender, EventArgs e)
        {
            WatchVarTest w;
            if (newVarBeingCreated)
            {
                w = newWatchVar;
            }
            else
            {
                w = WatchVarList.GetWatchVar(lBoxWatchVariables.SelectedIndex);
            }
            w.preAcceptHelpText = w.helpText;
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

        private WatchVarTest newWatchVar;

        private void btnWatchAccept_Click(object sender, EventArgs e)
        {
            WatchVarTest w = newVarBeingCreated == true ? newWatchVar : currentWatchVar;
            w.dispName = tBoxWatchDisplayName.Text;
            w.embName = tBoxWatchEmbName.Text;
            w.minChart = Convert.ToInt32(tBoxWatchMinChart.Text);
            w.maxChart = Convert.ToInt32(tBoxWatchMaxChart.Text);
            w.minVal =  Convert.ToInt32(tBoxWatchMinValue.Text);
            w.maxVal = Convert.ToInt32(tBoxWatchMaxValue.Text);
            w.dataType = cBoxWatchDataType.SelectedIndex;
            w.scaleType = cBoxWatchScaleType.SelectedIndex;
            w.units = cBoxWatchUnits.SelectedIndex;
            w.scaleInfo = cBoxWatchScaleInfo.SelectedIndex;
            w.unitConversion = cBoxWatchUnitConversion.SelectedIndex;
            w.formatString = cBoxWatchFormatString.SelectedIndex;
            w.engineeringViewOnly = chkWatchEngViewOnly.Checked ? 1 : 0;
            w.helpText = w.preAcceptHelpText;
            if (newVarBeingCreated)
            {
                WatchVarList.AddVar(newWatchVar);
            }
            
            AcceptOrCancelModification();
        }

        private void btnWatchCancel_Click(object sender, EventArgs e)
        {
            // Restore the original attributes
            UpdateWatchVarDisplay(watchVarIndex);

            AcceptOrCancelModification();
        }

        private void btnWatchImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Watch Variables");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file

        }

        private void WatchModifyInProgress()
        {
            watchVarIndex = lBoxWatchVariables.SelectedIndex;

            btnWatchModify.Enabled = false;
            btnWatchCreate.Enabled = false;
            btnWatchCopy.Enabled = false;
            btnWatchDelete.Enabled = false;
            btnWatchImport.Enabled = false;
            grpBoxWatchVarList.Enabled = false;
            grpBoxWatchAttrs.Enabled = true;
        }

        private bool newVarBeingCreated;
        private Int32 watchVarIndex;

        private void WatchVarCreate()
        {
            newVarBeingCreated = true;
            PopulateNewVarDefaults();
            newWatchVar = new WatchVarTest(tBoxWatchDisplayName.Text, tBoxWatchEmbName.Text, Convert.ToInt32(tBoxWatchMinChart.Text),
                                            Convert.ToInt32(tBoxWatchMaxChart.Text), Convert.ToInt32(tBoxWatchMinValue.Text),
                                            Convert.ToInt32(tBoxWatchMaxValue.Text), cBoxWatchDataType.SelectedIndex, cBoxWatchScaleType.SelectedIndex,
                                            cBoxWatchUnits.SelectedIndex, cBoxWatchScaleInfo.SelectedIndex, cBoxWatchUnitConversion.SelectedIndex,
                                            cBoxWatchFormatString.SelectedIndex, cBoxWatchReadWriteFlags.SelectedIndex,
                                            chkWatchEngViewOnly.Checked ? 1 : 0, "");
            WatchModifyInProgress();
        }

        private void AcceptOrCancelModification()
        {
            grpBoxWatchVarList.Enabled = true;
            grpBoxWatchAttrs.Enabled = false;
            if (lBoxWatchVariables.SelectedIndex != -1)
            {
                btnWatchModify.Enabled = true;
                btnWatchCopy.Enabled = true;
                btnWatchDelete.Enabled = true;
            }
            btnWatchCreate.Enabled = true;
            btnWatchImport.Enabled = true;
            if (newVarBeingCreated)
            {
                RefreshWatchVariableList(WatchVarList.GetWatchVarCount() - 1);
            }

            newVarBeingCreated = false;
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
            cBoxWatchScaleType.SelectedIndex = 0;
            cBoxWatchUnits.SelectedIndex = 0;
            cBoxWatchScaleInfo.SelectedIndex = 0;
            cBoxWatchUnitConversion.SelectedIndex = 0;
            cBoxWatchFormatString.SelectedIndex = 0;
            cBoxWatchReadWriteFlags.SelectedIndex = 0;
            chkWatchEngViewOnly.Checked = false;
            btnWatchHelpAvailable.BackColor = Color.Red;
        }

        private void RefreshWatchVariableList(int prevIndex)
        {
            lBoxWatchVariables.Items.Clear();
            int index = 0;
            WatchVarTest w;
            while (index < WatchVarList.GetWatchVarCount())
            {
                w = WatchVarList.GetWatchVar(index);
                switch (cBoxWatchList.SelectedIndex)
                { 
                    case 0:
                    default:
                        lBoxWatchVariables.Items.Add(w.dispName);
                        break;
                    case 1:
                        lBoxWatchVariables.Items.Add(w.embName);
                        break;
                }
                index++;
            }
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