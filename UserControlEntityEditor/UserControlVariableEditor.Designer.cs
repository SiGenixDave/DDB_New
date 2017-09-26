namespace DDB
{
    partial class UserControlVariableEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBoxUnitConversion = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cBoxScaleInfo = new System.Windows.Forms.ComboBox();
            this.lblWatchUnitConversion = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWatchScaleInfo = new System.Windows.Forms.Label();
            this.cBoxFormatString = new System.Windows.Forms.ComboBox();
            this.lblFormatString = new System.Windows.Forms.Label();
            this.chkEngViewOnly = new System.Windows.Forms.CheckBox();
            this.cBoxScaleType = new System.Windows.Forms.ComboBox();
            this.lblWatchUnitsEnumBitmask = new System.Windows.Forms.Label();
            this.cBoxUnits = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxReadWriteFlags = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxDataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gBoxVarMod = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxMaxValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxMinValue = new System.Windows.Forms.TextBox();
            this.gBoxChartScaling = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxMaxChart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxMinChart = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxEmbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxDisplayName = new System.Windows.Forms.TextBox();
            this.gBoxVarMod.SuspendLayout();
            this.gBoxChartScaling.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxUnitConversion
            // 
            this.cBoxUnitConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUnitConversion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxUnitConversion.FormattingEnabled = true;
            this.cBoxUnitConversion.Items.AddRange(new object[] {
            "METERSTOYARDS",
            "YARDSTOINCHES",
            "MPHTOKPH",
            "KPHTOMPH",
            "MILESTOKILOMETERS"});
            this.cBoxUnitConversion.Location = new System.Drawing.Point(350, 261);
            this.cBoxUnitConversion.Name = "cBoxUnitConversion";
            this.cBoxUnitConversion.Size = new System.Drawing.Size(143, 21);
            this.cBoxUnitConversion.TabIndex = 43;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(295, 370);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 34);
            this.btnAccept.TabIndex = 27;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cBoxScaleInfo
            // 
            this.cBoxScaleInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxScaleInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxScaleInfo.FormattingEnabled = true;
            this.cBoxScaleInfo.Items.AddRange(new object[] {
            "DIV1",
            "DIV10",
            "DIV100",
            "DIV1000",
            "MUL10",
            "MUL100",
            "MUL1000"});
            this.cBoxScaleInfo.Location = new System.Drawing.Point(350, 222);
            this.cBoxScaleInfo.Name = "cBoxScaleInfo";
            this.cBoxScaleInfo.Size = new System.Drawing.Size(143, 21);
            this.cBoxScaleInfo.TabIndex = 42;
            // 
            // lblWatchUnitConversion
            // 
            this.lblWatchUnitConversion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchUnitConversion.Location = new System.Drawing.Point(240, 261);
            this.lblWatchUnitConversion.Name = "lblWatchUnitConversion";
            this.lblWatchUnitConversion.Size = new System.Drawing.Size(103, 38);
            this.lblWatchUnitConversion.TabIndex = 41;
            this.lblWatchUnitConversion.Text = "Unit Conversion";
            this.lblWatchUnitConversion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(400, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 34);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWatchScaleInfo
            // 
            this.lblWatchScaleInfo.AutoSize = true;
            this.lblWatchScaleInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchScaleInfo.Location = new System.Drawing.Point(280, 226);
            this.lblWatchScaleInfo.Name = "lblWatchScaleInfo";
            this.lblWatchScaleInfo.Size = new System.Drawing.Size(63, 13);
            this.lblWatchScaleInfo.TabIndex = 40;
            this.lblWatchScaleInfo.Text = "Scale Info";
            this.lblWatchScaleInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxFormatString
            // 
            this.cBoxFormatString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFormatString.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFormatString.FormattingEnabled = true;
            this.cBoxFormatString.Items.AddRange(new object[] {
            "General Number",
            "Fixed",
            "Standard",
            "Scientific",
            "Hexadecimal",
            "Binary",
            "8Dot8"});
            this.cBoxFormatString.Location = new System.Drawing.Point(350, 297);
            this.cBoxFormatString.Name = "cBoxFormatString";
            this.cBoxFormatString.Size = new System.Drawing.Size(143, 21);
            this.cBoxFormatString.TabIndex = 39;
            // 
            // lblFormatString
            // 
            this.lblFormatString.AutoSize = true;
            this.lblFormatString.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatString.Location = new System.Drawing.Point(258, 297);
            this.lblFormatString.Name = "lblFormatString";
            this.lblFormatString.Size = new System.Drawing.Size(85, 13);
            this.lblFormatString.TabIndex = 38;
            this.lblFormatString.Text = "Format String";
            this.lblFormatString.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkEngViewOnly
            // 
            this.chkEngViewOnly.AutoSize = true;
            this.chkEngViewOnly.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEngViewOnly.Location = new System.Drawing.Point(13, 370);
            this.chkEngViewOnly.Name = "chkEngViewOnly";
            this.chkEngViewOnly.Size = new System.Drawing.Size(170, 17);
            this.chkEngViewOnly.TabIndex = 37;
            this.chkEngViewOnly.Text = "Engineering Only Visibility";
            this.chkEngViewOnly.UseVisualStyleBackColor = true;
            // 
            // cBoxScaleType
            // 
            this.cBoxScaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxScaleType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxScaleType.FormattingEnabled = true;
            this.cBoxScaleType.Items.AddRange(new object[] {
            "NONE",
            "Scalar",
            "Enumeration",
            "Bitmask"});
            this.cBoxScaleType.Location = new System.Drawing.Point(350, 151);
            this.cBoxScaleType.Name = "cBoxScaleType";
            this.cBoxScaleType.Size = new System.Drawing.Size(143, 21);
            this.cBoxScaleType.TabIndex = 36;
            this.cBoxScaleType.SelectedIndexChanged += new System.EventHandler(this.cBoxScaleType_SelectedIndexChanged);
            // 
            // lblWatchUnitsEnumBitmask
            // 
            this.lblWatchUnitsEnumBitmask.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchUnitsEnumBitmask.Location = new System.Drawing.Point(250, 193);
            this.lblWatchUnitsEnumBitmask.Name = "lblWatchUnitsEnumBitmask";
            this.lblWatchUnitsEnumBitmask.Size = new System.Drawing.Size(93, 17);
            this.lblWatchUnitsEnumBitmask.TabIndex = 35;
            this.lblWatchUnitsEnumBitmask.Text = "Units";
            this.lblWatchUnitsEnumBitmask.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxUnits
            // 
            this.cBoxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUnits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxUnits.FormattingEnabled = true;
            this.cBoxUnits.Location = new System.Drawing.Point(350, 188);
            this.cBoxUnits.Name = "cBoxUnits";
            this.cBoxUnits.Size = new System.Drawing.Size(143, 21);
            this.cBoxUnits.TabIndex = 33;
            this.cBoxUnits.SelectedIndexChanged += new System.EventHandler(this.cBoxUnits_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Scale Type";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxReadWriteFlags
            // 
            this.cBoxReadWriteFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxReadWriteFlags.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxReadWriteFlags.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxReadWriteFlags.FormattingEnabled = true;
            this.cBoxReadWriteFlags.Items.AddRange(new object[] {
            "Read Only",
            "Maintenence [R/W]",
            "Engineering [R/W]",
            "Factory [R/W]"});
            this.cBoxReadWriteFlags.Location = new System.Drawing.Point(12, 338);
            this.cBoxReadWriteFlags.Name = "cBoxReadWriteFlags";
            this.cBoxReadWriteFlags.Size = new System.Drawing.Size(143, 21);
            this.cBoxReadWriteFlags.TabIndex = 34;
            this.cBoxReadWriteFlags.SelectedIndexChanged += new System.EventHandler(this.cBoxReadWriteFlags_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Read Write Flags";
            // 
            // cBoxDataType
            // 
            this.cBoxDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDataType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDataType.FormattingEnabled = true;
            this.cBoxDataType.Items.AddRange(new object[] {
            "BOOL",
            "UINT_8",
            "UINT_16",
            "UINT_32",
            "INT_8",
            "INT_16",
            "INT_32",
            "FLOAT",
            "DOUBLE"});
            this.cBoxDataType.Location = new System.Drawing.Point(350, 118);
            this.cBoxDataType.Name = "cBoxDataType";
            this.cBoxDataType.Size = new System.Drawing.Size(143, 21);
            this.cBoxDataType.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Data Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gBoxVarMod
            // 
            this.gBoxVarMod.Controls.Add(this.label6);
            this.gBoxVarMod.Controls.Add(this.tBoxMaxValue);
            this.gBoxVarMod.Controls.Add(this.label7);
            this.gBoxVarMod.Controls.Add(this.tBoxMinValue);
            this.gBoxVarMod.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxVarMod.Location = new System.Drawing.Point(13, 218);
            this.gBoxVarMod.Name = "gBoxVarMod";
            this.gBoxVarMod.Size = new System.Drawing.Size(222, 94);
            this.gBoxVarMod.TabIndex = 26;
            this.gBoxVarMod.TabStop = false;
            this.gBoxVarMod.Text = "Variable Modification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maximum Value";
            // 
            // tBoxMaxValue
            // 
            this.tBoxMaxValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMaxValue.Location = new System.Drawing.Point(102, 60);
            this.tBoxMaxValue.Name = "tBoxMaxValue";
            this.tBoxMaxValue.Size = new System.Drawing.Size(107, 21);
            this.tBoxMaxValue.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Minimum Value";
            // 
            // tBoxMinValue
            // 
            this.tBoxMinValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMinValue.Location = new System.Drawing.Point(102, 31);
            this.tBoxMinValue.Name = "tBoxMinValue";
            this.tBoxMinValue.Size = new System.Drawing.Size(107, 21);
            this.tBoxMinValue.TabIndex = 0;
            // 
            // gBoxChartScaling
            // 
            this.gBoxChartScaling.Controls.Add(this.label4);
            this.gBoxChartScaling.Controls.Add(this.tBoxMaxChart);
            this.gBoxChartScaling.Controls.Add(this.label5);
            this.gBoxChartScaling.Controls.Add(this.tBoxMinChart);
            this.gBoxChartScaling.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxChartScaling.Location = new System.Drawing.Point(13, 117);
            this.gBoxChartScaling.Name = "gBoxChartScaling";
            this.gBoxChartScaling.Size = new System.Drawing.Size(222, 93);
            this.gBoxChartScaling.TabIndex = 25;
            this.gBoxChartScaling.TabStop = false;
            this.gBoxChartScaling.Text = "Chart Scaling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum Value";
            // 
            // tBoxMaxChart
            // 
            this.tBoxMaxChart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMaxChart.Location = new System.Drawing.Point(102, 60);
            this.tBoxMaxChart.Name = "tBoxMaxChart";
            this.tBoxMaxChart.Size = new System.Drawing.Size(107, 21);
            this.tBoxMaxChart.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minimum Value";
            // 
            // tBoxMinChart
            // 
            this.tBoxMinChart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxMinChart.Location = new System.Drawing.Point(102, 31);
            this.tBoxMinChart.Name = "tBoxMinChart";
            this.tBoxMinChart.Size = new System.Drawing.Size(107, 21);
            this.tBoxMinChart.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxEmbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxDisplayName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 98);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Embedded";
            // 
            // tBoxEmbName
            // 
            this.tBoxEmbName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEmbName.Location = new System.Drawing.Point(76, 60);
            this.tBoxEmbName.Name = "tBoxEmbName";
            this.tBoxEmbName.Size = new System.Drawing.Size(404, 21);
            this.tBoxEmbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display";
            // 
            // tBoxDisplayName
            // 
            this.tBoxDisplayName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDisplayName.Location = new System.Drawing.Point(76, 31);
            this.tBoxDisplayName.Name = "tBoxDisplayName";
            this.tBoxDisplayName.Size = new System.Drawing.Size(404, 21);
            this.tBoxDisplayName.TabIndex = 0;
            // 
            // UserControlVariableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxUnitConversion);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cBoxScaleInfo);
            this.Controls.Add(this.lblWatchUnitConversion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWatchScaleInfo);
            this.Controls.Add(this.cBoxFormatString);
            this.Controls.Add(this.lblFormatString);
            this.Controls.Add(this.chkEngViewOnly);
            this.Controls.Add(this.cBoxScaleType);
            this.Controls.Add(this.lblWatchUnitsEnumBitmask);
            this.Controls.Add(this.cBoxUnits);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cBoxReadWriteFlags);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBoxDataType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gBoxVarMod);
            this.Controls.Add(this.gBoxChartScaling);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlVariableEditor";
            this.Size = new System.Drawing.Size(512, 420);
            this.gBoxVarMod.ResumeLayout(false);
            this.gBoxVarMod.PerformLayout();
            this.gBoxChartScaling.ResumeLayout(false);
            this.gBoxChartScaling.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxUnitConversion;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cBoxScaleInfo;
        private System.Windows.Forms.Label lblWatchUnitConversion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWatchScaleInfo;
        private System.Windows.Forms.ComboBox cBoxFormatString;
        private System.Windows.Forms.Label lblFormatString;
        private System.Windows.Forms.CheckBox chkEngViewOnly;
        private System.Windows.Forms.ComboBox cBoxScaleType;
        private System.Windows.Forms.Label lblWatchUnitsEnumBitmask;
        private System.Windows.Forms.ComboBox cBoxUnits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBoxReadWriteFlags;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxDataType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gBoxVarMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxMaxValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxMinValue;
        private System.Windows.Forms.GroupBox gBoxChartScaling;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxMaxChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxMinChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxEmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxDisplayName;
    }
}
