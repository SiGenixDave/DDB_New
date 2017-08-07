using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormMain
    {
        private void InitWatchVars()
        {
            RefreshWatchVariableList(-1);
            // Always disable the Actions and context menu that contains actions when in customer mode
            if (GlobalSettings.getCustomerUseOnly())
            {
                gBoxWatchActions.Enabled = false;
                conMenuWatchVarList.Enabled = false;
            }


        }




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

                btnWatchAccept.Enabled = false;
                btnWatchCancel.Enabled = false;
                btnWatchModifyHelpText.Enabled = false;
                btnWatchHelpAvailable.Enabled = false;
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

                    LoadEnumsIntoComboBox(false);
                    break;

                case "Bitmask":
                    lblFormatString.Visible = false;
                    cBoxWatchFormatString.Visible = false;
                    lblWatchUnitConversion.Visible = false;
                    cBoxWatchUnitConversion.Visible = false;
                    lblWatchScaleInfo.Visible = false;
                    cBoxWatchScaleInfo.Visible = false;

                    lblWatchUnitsEnumBitmask.Text = "Bitmask";
                    LoadBitmasksIntoComboBox(false);


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


        private void LoadBitmasksIntoComboBox(Boolean useExistingIndex)
        {
            cBoxWatchUnits.Items.Clear();

            int index = 0;
            while (index < BitmaskVarList.GetVarCount())
            {
                cBoxWatchUnits.Items.Add(BitmaskVarList.GetVar(index).dispName);
                index++;
            }
            if (!useExistingIndex)
            {
                cBoxWatchUnits.SelectedIndex = 0;
            }
        }

        private void LoadEnumsIntoComboBox(Boolean useExistingIndex)
        {
            cBoxWatchUnits.Items.Clear();

            int index = 0;
            while (index < EnumVarList.GetVarCount())
            {
                cBoxWatchUnits.Items.Add(EnumVarList.GetVar(index).dispName);
                index++;
            }
            if (!useExistingIndex)
            {
                cBoxWatchUnits.SelectedIndex = 0;
            }
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

            // Always save the help text when in customer mode because Accept and Cancel are disabled in customer mode
            if (GlobalSettings.getCustomerUseOnly())
            {
                w.helpText = w.preAcceptHelpText;
            }

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

        private void cBoxWatchUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxWatchScaleType.SelectedItem.ToString() == "Bitmask")
            {
                formEnumPreview.UpdateForm(null);
                formBitmaskPreview.UpdateForm(BitmaskVarList.GetVar(cBoxWatchUnits.SelectedIndex));
            }
            if (cBoxWatchScaleType.SelectedItem.ToString() == "Enumeration")
            {
                formBitmaskPreview.UpdateForm(null);
                formEnumPreview.UpdateForm(EnumVarList.GetVar(cBoxWatchUnits.SelectedIndex));
            }
        }

        private void cBoxWatchReadWriteFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxWatchReadWriteFlags.SelectedIndex == 0)
            {
                gBoxWatchVarMod.Enabled = false;
            }
            else
            {
                gBoxWatchVarMod.Enabled = true;
            }
        }

        private void copyWatchMenuItem_Click(object sender, EventArgs e)
        {
            CopyWatchVar();
        }

        private void modifyWatchMenuItem_Click(object sender, EventArgs e)
        {
            WatchModifyInProgress();
        }

        private void deleteWatchMenuItem_Click(object sender, EventArgs e)
        {
            DeleteWatchVar();
        }

        private void lBoxWatchVariables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WatchModifyInProgress();
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
                btnWatchModifyHelpText.Enabled = false;
            }
            else if (lBoxWatchVariables.SelectedIndices.Count == 1)
            {
                UpdateWatchVarDisplay(lBoxWatchVariables.SelectedIndex);

                conMenuWatchVarList.Items[1].Enabled = true;

                if (!GlobalSettings.getCustomerUseOnly())
                {
                    btnWatchModify.Enabled = true;
                    btnWatchDelete.Enabled = true;
                    btnWatchCopy.Enabled = true;
                }
                else
                {
                    // Enable modify help text only for customer
                    btnWatchModifyHelpText.Enabled = true;
                }
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

                btnWatchModifyHelpText.Enabled = false;

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
            w.minVal = Convert.ToInt32(tBoxWatchMinValue.Text);
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
            if (Cancel.Query("Watch Variable") == true)
            {
                // Restore the original attributes
                UpdateWatchVarDisplay(watchVarIndex);

                AcceptOrCancelModification();
            }
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

            tabControl1.Focus();
            grpBoxWatchAttrs.Focus();
            gBoxWatchActions.Enabled = false;
            grpBoxWatchVarList.Enabled = false;
            btnWatchModifyHelpText.Enabled = true;
            btnWatchAccept.Enabled = true;
            btnWatchCancel.Enabled = true;

            if (!GlobalSettings.getCustomerUseOnly())
            {
                grpBoxWatchAttrs.Enabled = true;
            }
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
            gBoxWatchActions.Enabled = true;

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

            lBoxWatchVariables.SelectedIndex = prevIndex;
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
            List<WatchVarTest> watchesToDelete = new List<WatchVarTest>();
            while (indexCount < lBoxWatchVariables.SelectedIndices.Count)
            {
                watchesToDelete.Add(WatchVarList.GetWatchVar(lBoxWatchVariables.SelectedIndices[indexCount]));
                indexCount++;
            }

            while (watchesToDelete.Count != 0)
            {
                WatchVarList.DeleteVar(watchesToDelete[0]);
                watchesToDelete.RemoveAt(0);
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