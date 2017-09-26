using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDB
{
    public partial class UserControlVariableEditor : UserControl
    {
        private FormMain formMain;

        public UserControlVariableEditor()
        {
            InitializeComponent();
        }

        bool _gBoxChartScalingEnabled = true;
        [DefaultValue(true)]
        public bool xChartScalingGroupBox
        {
            get
            {
                return _gBoxChartScalingEnabled;
            }
            set
            {
                _gBoxChartScalingEnabled = value;
                gBoxChartScaling.Enabled = value;
            }
        }

        bool _gBoxVarModEnabled = true;
        [DefaultValue(true)]
        public bool xVarModGroupBox
        {
            get
            {
                return _gBoxVarModEnabled;
            }
            set
            {
                _gBoxVarModEnabled = value;
                gBoxVarMod.Enabled = value;
            }
        }

        public void setFormMain (FormMain fmain)
        {
            formMain = fmain;
        }


        public void UpdateVarDisplay(VariableDB watchVar)
        {
            if (watchVar != null)
            {
                tBoxDisplayName.Text = watchVar.dispName;
                tBoxEmbName.Text = watchVar.embName;
                tBoxMinChart.Text = watchVar.minChart.ToString();
                tBoxMaxChart.Text = watchVar.maxChart.ToString();
                tBoxMinValue.Text = watchVar.minVal.ToString();
                tBoxMaxValue.Text = watchVar.maxVal.ToString();
                cBoxDataType.SelectedIndex = watchVar.dataType;
                cBoxScaleType.SelectedIndex = watchVar.scaleType;
                cBoxUnits.SelectedIndex = watchVar.units;
                cBoxUnitConversion.SelectedIndex = watchVar.unitConversion;
                cBoxReadWriteFlags.SelectedIndex = watchVar.readWrite;
                cBoxFormatString.SelectedIndex = watchVar.formatString;
                chkEngViewOnly.Checked = watchVar.engineeringViewOnly == 1 ? true : false;

                //TODO formHelpPreview.UpdateForm(watchVar.helpText);

                EnableControlsOnSelectedScaleType(cBoxScaleType.SelectedItem.ToString(), watchVar);
            }
            else
            {
                // Handle the case where no watch vars selected
                tBoxDisplayName.Text = "";
                tBoxEmbName.Text = "";
                tBoxMinChart.Text = "";
                tBoxMaxChart.Text = "";
                tBoxMinValue.Text = "";
                tBoxMaxValue.Text = "";
            }
        }


        private VariableDB modifiedVar;
        private Boolean modifyInProgress;
        private Boolean modifyAccepted;
        public Boolean EnableEditor(object obj)
        {
            modifyInProgress = true;

            modifiedVar = (VariableDB)obj;
            modifyAccepted = false;

            while (modifyInProgress)
            {
                Application.DoEvents();
            }

            return modifyAccepted;
        }

        private void EnableControlsOnSelectedScaleType(String scaleTypeTxt, VariableDB w)
        {
            switch (scaleTypeTxt)
            {
                case "NONE":
                    lblFormatString.Visible = false;
                    cBoxFormatString.Visible = false;
                    lblWatchUnitConversion.Visible = false;
                    cBoxUnitConversion.Visible = false;
                    lblWatchScaleInfo.Visible = false;
                    cBoxScaleInfo.Visible = false;
                    lblWatchUnitsEnumBitmask.Text = "Units";
                    LoadUnitsIntoComboBox();
                    break;

                case "Scalar":
                    lblFormatString.Visible = true;
                    cBoxFormatString.Visible = true;
                    lblWatchUnitConversion.Visible = true;
                    cBoxUnitConversion.Visible = true;
                    lblWatchScaleInfo.Visible = true;
                    cBoxScaleInfo.Visible = true;

                    cBoxFormatString.SelectedIndex = w.formatString;
                    cBoxUnitConversion.SelectedIndex = w.unitConversion;
                    cBoxScaleInfo.SelectedIndex = w.scaleInfo;

                    lblWatchUnitsEnumBitmask.Text = "Units";
                    LoadUnitsIntoComboBox();
                    break;

                case "Enumeration":
                    lblFormatString.Visible = false;
                    cBoxFormatString.Visible = false;
                    lblWatchUnitConversion.Visible = false;
                    cBoxUnitConversion.Visible = false;
                    lblWatchScaleInfo.Visible = false;
                    cBoxScaleInfo.Visible = false;

                    lblWatchUnitsEnumBitmask.Text = "Enumeration";

                    LoadEnumsIntoComboBox(false);
                    break;

                case "Bitmask":
                    lblFormatString.Visible = false;
                    cBoxFormatString.Visible = false;
                    lblWatchUnitConversion.Visible = false;
                    cBoxUnitConversion.Visible = false;
                    lblWatchScaleInfo.Visible = false;
                    cBoxScaleInfo.Visible = false;

                    lblWatchUnitsEnumBitmask.Text = "Bitmask";
                    LoadBitmasksIntoComboBox(false);


                    break;
            }

        }

        private void LoadUnitsIntoComboBox()
        {
            cBoxUnits.Items.Clear();

            foreach (UnitsDB unit in formMain.GetUnits())
            {
                cBoxUnits.Items.Add(unit);
            }

            cBoxUnits.SelectedIndex = 0;

        }


        private void LoadBitmasksIntoComboBox(Boolean useExistingIndex)
        {

            cBoxUnits.Items.Clear();

            foreach (BitmaskDB b in formMain.GetBitmasks())
            {
                cBoxUnits.Items.Add(b);
            }
            if (!useExistingIndex)
            {
                cBoxUnits.SelectedIndex = 0;
            }

        }

        private void LoadEnumsIntoComboBox(Boolean useExistingIndex)
        {
            cBoxUnits.Items.Clear();

            foreach (EnumsDB e in formMain.GetEnums())
            {
                cBoxUnits.Items.Add(e);
            }

            if (!useExistingIndex)
            {
                cBoxUnits.SelectedIndex = 0;
            }

        }

        private void cBoxScaleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControlsOnSelectedScaleType(cBoxScaleType.SelectedItem.ToString(), modifiedVar);
        }

        private void cBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cBoxScaleType.SelectedItem.ToString() == "Bitmask")
            {
#if TODO
                formEnumPreview.UpdateForm(null);
                formBitmaskPreview.UpdateForm((BitmaskDB)cBoxWatchUnits.SelectedItem);
#endif
            }
            if (cBoxScaleType.SelectedItem.ToString() == "Enumeration")
            {
#if TODO
                formBitmaskPreview.UpdateForm(null);
                formEnumPreview.UpdateForm((EnumsDB)cBoxWatchUnits.SelectedItem);
#endif
            }

        }

        private void cBoxReadWriteFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxReadWriteFlags.SelectedIndex == 0)
            {
                gBoxVarMod.Enabled = false;
            }
            else
            {
                gBoxVarMod.Enabled = true;
            }
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            modifiedVar.dispName = tBoxDisplayName.Text;
            modifiedVar.embName = tBoxEmbName.Text;
            modifiedVar.minChart = Convert.ToInt32(tBoxMinChart.Text);
            modifiedVar.maxChart = Convert.ToInt32(tBoxMaxChart.Text);
            modifiedVar.minVal = Convert.ToInt32(tBoxMinValue.Text);
            modifiedVar.maxVal = Convert.ToInt32(tBoxMaxValue.Text);
            modifiedVar.dataType = cBoxDataType.SelectedIndex;
            modifiedVar.scaleType = cBoxScaleType.SelectedIndex;
            modifiedVar.units = cBoxUnits.SelectedIndex;
            modifiedVar.scaleInfo = cBoxScaleInfo.SelectedIndex;
            modifiedVar.unitConversion = cBoxUnitConversion.SelectedIndex;
            modifiedVar.formatString = cBoxFormatString.SelectedIndex;
            modifiedVar.engineeringViewOnly = chkEngViewOnly.Checked ? 1 : 0;
            AcceptOrCancelModification(true);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Watch Variable") == true)
            {
                AcceptOrCancelModification(false);
            }
        }


        public VariableDB VarCreate()
        {
            PopulateNewVarDefaults();
            VariableDB newVar = new VariableDB(tBoxDisplayName.Text, tBoxEmbName.Text, Convert.ToInt32(tBoxMinChart.Text),
                                            Convert.ToInt32(tBoxMaxChart.Text), Convert.ToInt32(tBoxMinValue.Text),
                                            Convert.ToInt32(tBoxMaxValue.Text), cBoxDataType.SelectedIndex, cBoxScaleType.SelectedIndex,
                                            cBoxUnits.SelectedIndex, cBoxScaleInfo.SelectedIndex, cBoxUnitConversion.SelectedIndex,
                                            cBoxFormatString.SelectedIndex, cBoxReadWriteFlags.SelectedIndex,
                                            chkEngViewOnly.Checked ? 1 : 0, "");

            return newVar;
        }


        private void AcceptOrCancelModification(Boolean accepted)
        {
            modifyInProgress = false;
            modifyAccepted = accepted;
        }

        private void PopulateNewVarDefaults()
        {
            tBoxDisplayName.Text = "New Display Var Name";
            tBoxEmbName.Text = "New Embedded Var Name";
            tBoxMinChart.Text = "0";
            tBoxMaxChart.Text = "255";
            tBoxMinValue.Text = "0";
            tBoxMaxValue.Text = "255";
            cBoxDataType.SelectedIndex = 0;
            cBoxScaleType.SelectedIndex = 0;
            cBoxUnits.SelectedIndex = 0;
            cBoxScaleInfo.SelectedIndex = 0;
            cBoxUnitConversion.SelectedIndex = 0;
            cBoxFormatString.SelectedIndex = 0;
            cBoxReadWriteFlags.SelectedIndex = 0;
            chkEngViewOnly.Checked = false;
        }



    }
}
