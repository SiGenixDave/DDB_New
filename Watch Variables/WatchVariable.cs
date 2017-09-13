using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{

    public class WatchVariablesBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormMain formMain;
        FormHelpPreview formHelpPreview;

        public WatchVariablesBusinessLogic(FormMain fMain, FormHelpPreview hPreview)
        {
            formMain = fMain;
            formHelpPreview = hPreview;
        }

        private WatchVariablesBusinessLogic()
        { }

        public object Copy(object obj)
        {
            WatchVarDB var = new WatchVarDB((WatchVarDB)obj);
            var.dispName = "Copy of " + var.dispName;
            var.embName = "Copy of " + var.embName;
            return var;
        }

        public void Modify(object obj)
        {
            formMain.EnableWatchEditor(obj);
        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            object obj = formMain.WatchVarCreate();
            if (formMain.EnableWatchEditor(obj))
            {
                return obj;
            }

            return null;

        }

        public void Preview(object obj)
        {
            formMain.UpdateWatchVarDisplay((WatchVarDB)obj);
        }

        public void Links()
        { }
        public void Import()
        { }
        public void HelpModify(object obj)
        {
            WatchVarDB var = (WatchVarDB)obj;
            FormHelpText fh = new FormHelpText(var, "Watch Variable \"" + var.dispName + "\"");
            fh.ShowDialog();

            HelpPreview(obj);

        }

        public void HelpPreview(object obj)
        {
            WatchVarDB e = (WatchVarDB)obj;
            formHelpPreview.UpdateForm(e.helpText);
        }

        public void ChangeDisplayName(int name)
        {
            NameType nameType = NameType.DISPLAY;
            if (name == 1)
            {
                nameType = NameType.ENMBEDDED;
            }

            GlobalSettings.setWatchDisplayType(nameType);

        }

    }

    public partial class FormMain
    {
        private void PopulateWatchVars()
        {
            WatchVariablesBusinessLogic wbl = new WatchVariablesBusinessLogic(this,formHelpPreview);
            ucEE_WatchVariables.setBusinessLogic(wbl);
            ucEE_WatchVariables.AddListBoxItems(WatchVarList.GetWatchVars());

            foreach (UnitsDB u in UnitsList.GetUnits())
            {
                cBoxWatchUnits.Items.Add(u);
            }
        }

        public void UpdateWatchVarDisplay(WatchVarDB watchVar)
        {
            if (watchVar != null)
            {
                tBoxWatchDisplayName.Text = watchVar.dispName;
                tBoxWatchEmbName.Text = watchVar.embName;
                tBoxWatchMinChart.Text = watchVar.minChart.ToString();
                tBoxWatchMaxChart.Text = watchVar.maxChart.ToString();
                tBoxWatchMinValue.Text = watchVar.minVal.ToString();
                tBoxWatchMaxValue.Text = watchVar.maxVal.ToString();
                cBoxWatchDataType.SelectedIndex = watchVar.dataType;
                cBoxWatchScaleType.SelectedIndex = watchVar.scaleType;
                cBoxWatchUnits.SelectedIndex = watchVar.units;
                cBoxWatchUnitConversion.SelectedIndex = watchVar.unitConversion;
                cBoxWatchReadWriteFlags.SelectedIndex = watchVar.readWrite;
                cBoxWatchFormatString.SelectedIndex = watchVar.formatString;
                chkWatchEngViewOnly.Checked = watchVar.engineeringViewOnly == 1 ? true : false;

                //TODOformHelpPreview.UpdateForm(currentWatchVar.helpText);

                EnableControlsOnSelectedScaleType(cBoxWatchScaleType.SelectedItem.ToString(), watchVar);
            }
#if DAS
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
            }
#endif
        }


        private WatchVarDB modifiedWatchVar;
        private Boolean watchModifyInProgress;
        private Boolean watchModifyAccepted;
        public Boolean EnableWatchEditor(object obj)
        {
            watchModifyInProgress = true;

            modifiedWatchVar = (WatchVarDB)obj;
            grpBoxWatchAttrs.Enabled = true;
            ucEE_WatchVariables.Enabled = false;
            watchModifyAccepted = false;

            while (watchModifyInProgress)
            {
                Application.DoEvents();
            }

            return watchModifyAccepted;
        }

        private void EnableControlsOnSelectedScaleType(String scaleTypeTxt, WatchVarDB w)
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
                
            foreach (UnitsDB unit in ucEE_Units.GetItems())
            {
                cBoxWatchUnits.Items.Add(unit);
            }

            cBoxWatchUnits.SelectedIndex = 0;

        }


        private void LoadBitmasksIntoComboBox(Boolean useExistingIndex)
        {

            cBoxWatchUnits.Items.Clear();

            foreach (BitmaskDB b in ucEE_Bitmasks.GetItems())
            {
                cBoxWatchUnits.Items.Add(b);
            }
            if (!useExistingIndex)
            {
                cBoxWatchUnits.SelectedIndex = 0;
            }

        }

        private void LoadEnumsIntoComboBox(Boolean useExistingIndex)
        {
            cBoxWatchUnits.Items.Clear();

            foreach (EnumsDB e in ucEE_Enumerations.GetItems())
            {
                cBoxWatchUnits.Items.Add(e);
            }

            if (!useExistingIndex)
            {
                cBoxWatchUnits.SelectedIndex = 0;
            }

        }



        
        private void cBoxWatchScaleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControlsOnSelectedScaleType(cBoxWatchScaleType.SelectedItem.ToString(), modifiedWatchVar);
        }

        private void cBoxWatchUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cBoxWatchScaleType.SelectedItem.ToString() == "Bitmask")
            {
                formEnumPreview.UpdateForm(null);
                formBitmaskPreview.UpdateForm((BitmaskDB)cBoxWatchUnits.SelectedItem);
            }
            if (cBoxWatchScaleType.SelectedItem.ToString() == "Enumeration")
            {
                formBitmaskPreview.UpdateForm(null);
                formEnumPreview.UpdateForm((EnumsDB)cBoxWatchUnits.SelectedItem);
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

        
        private void btnWatchAccept_Click(object sender, EventArgs e)
        {
            modifiedWatchVar.dispName = tBoxWatchDisplayName.Text;
            modifiedWatchVar.embName = tBoxWatchEmbName.Text;
            modifiedWatchVar.minChart = Convert.ToInt32(tBoxWatchMinChart.Text);
            modifiedWatchVar.maxChart = Convert.ToInt32(tBoxWatchMaxChart.Text);
            modifiedWatchVar.minVal = Convert.ToInt32(tBoxWatchMinValue.Text);
            modifiedWatchVar.maxVal = Convert.ToInt32(tBoxWatchMaxValue.Text);
            modifiedWatchVar.dataType = cBoxWatchDataType.SelectedIndex;
            modifiedWatchVar.scaleType = cBoxWatchScaleType.SelectedIndex;
            modifiedWatchVar.units = cBoxWatchUnits.SelectedIndex;
            modifiedWatchVar.scaleInfo = cBoxWatchScaleInfo.SelectedIndex;
            modifiedWatchVar.unitConversion = cBoxWatchUnitConversion.SelectedIndex;
            modifiedWatchVar.formatString = cBoxWatchFormatString.SelectedIndex;
            modifiedWatchVar.engineeringViewOnly = chkWatchEngViewOnly.Checked ? 1 : 0;
            AcceptOrCancelModification(true);
        }


        private void btnWatchCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Watch Variable") == true)
            {
                AcceptOrCancelModification(false);
            }
        }

        private void btnWatchImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Watch Variables");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }


        public WatchVarDB WatchVarCreate()
        {
            PopulateNewVarDefaults();
            WatchVarDB newWatchVar = new WatchVarDB(tBoxWatchDisplayName.Text, tBoxWatchEmbName.Text, Convert.ToInt32(tBoxWatchMinChart.Text),
                                            Convert.ToInt32(tBoxWatchMaxChart.Text), Convert.ToInt32(tBoxWatchMinValue.Text),
                                            Convert.ToInt32(tBoxWatchMaxValue.Text), cBoxWatchDataType.SelectedIndex, cBoxWatchScaleType.SelectedIndex,
                                            cBoxWatchUnits.SelectedIndex, cBoxWatchScaleInfo.SelectedIndex, cBoxWatchUnitConversion.SelectedIndex,
                                            cBoxWatchFormatString.SelectedIndex, cBoxWatchReadWriteFlags.SelectedIndex,
                                            chkWatchEngViewOnly.Checked ? 1 : 0, "");

            return newWatchVar;
        }


        private void AcceptOrCancelModification(Boolean accepted)
        {
            ucEE_WatchVariables.Enabled = true;
            grpBoxWatchAttrs.Enabled = false;

            watchModifyInProgress = false;

            watchModifyAccepted = accepted;
            ucEE_WatchVariables.SetSelectedItem(modifiedWatchVar);
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
        }

    }
}