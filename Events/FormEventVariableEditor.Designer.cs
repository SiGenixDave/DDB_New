namespace DDB
{
    partial class FormEventVariableEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxWatchAttrs = new System.Windows.Forms.GroupBox();
            this.cBoxWatchUnitConversion = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cBoxWatchScaleInfo = new System.Windows.Forms.ComboBox();
            this.lblWatchUnitConversion = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWatchScaleInfo = new System.Windows.Forms.Label();
            this.cBoxWatchFormatString = new System.Windows.Forms.ComboBox();
            this.lblFormatString = new System.Windows.Forms.Label();
            this.cBoxWatchScaleType = new System.Windows.Forms.ComboBox();
            this.lblWatchUnitsEnumBitmask = new System.Windows.Forms.Label();
            this.cBoxWatchUnits = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxWatchDataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxWatchEmbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxWatchDisplayName = new System.Windows.Forms.TextBox();
            this.grpBoxWatchAttrs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxWatchAttrs
            // 
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchUnitConversion);
            this.grpBoxWatchAttrs.Controls.Add(this.btnAccept);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchScaleInfo);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchUnitConversion);
            this.grpBoxWatchAttrs.Controls.Add(this.btnCancel);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchScaleInfo);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchFormatString);
            this.grpBoxWatchAttrs.Controls.Add(this.lblFormatString);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchScaleType);
            this.grpBoxWatchAttrs.Controls.Add(this.lblWatchUnitsEnumBitmask);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchUnits);
            this.grpBoxWatchAttrs.Controls.Add(this.label10);
            this.grpBoxWatchAttrs.Controls.Add(this.cBoxWatchDataType);
            this.grpBoxWatchAttrs.Controls.Add(this.label8);
            this.grpBoxWatchAttrs.Controls.Add(this.groupBox1);
            this.grpBoxWatchAttrs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWatchAttrs.Location = new System.Drawing.Point(12, 12);
            this.grpBoxWatchAttrs.Name = "grpBoxWatchAttrs";
            this.grpBoxWatchAttrs.Size = new System.Drawing.Size(508, 370);
            this.grpBoxWatchAttrs.TabIndex = 7;
            this.grpBoxWatchAttrs.TabStop = false;
            this.grpBoxWatchAttrs.Text = "Attributes";
            // 
            // cBoxWatchUnitConversion
            // 
            this.cBoxWatchUnitConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchUnitConversion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchUnitConversion.FormattingEnabled = true;
            this.cBoxWatchUnitConversion.Items.AddRange(new object[] {
            "METERSTOYARDS",
            "YARDSTOINCHES",
            "MPHTOKPH",
            "KPHTOMPH",
            "MILESTOKILOMETERS"});
            this.cBoxWatchUnitConversion.Location = new System.Drawing.Point(113, 278);
            this.cBoxWatchUnitConversion.Name = "cBoxWatchUnitConversion";
            this.cBoxWatchUnitConversion.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchUnitConversion.TabIndex = 23;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(383, 168);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 34);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cBoxWatchScaleInfo
            // 
            this.cBoxWatchScaleInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchScaleInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchScaleInfo.FormattingEnabled = true;
            this.cBoxWatchScaleInfo.Items.AddRange(new object[] {
            "DIV1",
            "DIV10",
            "DIV100",
            "DIV1000",
            "MUL10",
            "MUL100",
            "MUL1000"});
            this.cBoxWatchScaleInfo.Location = new System.Drawing.Point(113, 239);
            this.cBoxWatchScaleInfo.Name = "cBoxWatchScaleInfo";
            this.cBoxWatchScaleInfo.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchScaleInfo.TabIndex = 22;
            // 
            // lblWatchUnitConversion
            // 
            this.lblWatchUnitConversion.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchUnitConversion.Location = new System.Drawing.Point(4, 278);
            this.lblWatchUnitConversion.Name = "lblWatchUnitConversion";
            this.lblWatchUnitConversion.Size = new System.Drawing.Size(103, 38);
            this.lblWatchUnitConversion.TabIndex = 21;
            this.lblWatchUnitConversion.Text = "Unit Conversion";
            this.lblWatchUnitConversion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(383, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWatchScaleInfo
            // 
            this.lblWatchScaleInfo.AutoSize = true;
            this.lblWatchScaleInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchScaleInfo.Location = new System.Drawing.Point(44, 243);
            this.lblWatchScaleInfo.Name = "lblWatchScaleInfo";
            this.lblWatchScaleInfo.Size = new System.Drawing.Size(77, 17);
            this.lblWatchScaleInfo.TabIndex = 20;
            this.lblWatchScaleInfo.Text = "Scale Info";
            this.lblWatchScaleInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchFormatString
            // 
            this.cBoxWatchFormatString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchFormatString.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchFormatString.FormattingEnabled = true;
            this.cBoxWatchFormatString.Items.AddRange(new object[] {
            "General Number",
            "Fixed",
            "Standard",
            "Scientific",
            "Hexadecimal",
            "Binary",
            "8Dot8"});
            this.cBoxWatchFormatString.Location = new System.Drawing.Point(113, 314);
            this.cBoxWatchFormatString.Name = "cBoxWatchFormatString";
            this.cBoxWatchFormatString.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchFormatString.TabIndex = 19;
            // 
            // lblFormatString
            // 
            this.lblFormatString.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatString.Location = new System.Drawing.Point(6, 314);
            this.lblFormatString.Name = "lblFormatString";
            this.lblFormatString.Size = new System.Drawing.Size(101, 34);
            this.lblFormatString.TabIndex = 17;
            this.lblFormatString.Text = "Format String";
            this.lblFormatString.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchScaleType
            // 
            this.cBoxWatchScaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchScaleType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchScaleType.FormattingEnabled = true;
            this.cBoxWatchScaleType.Items.AddRange(new object[] {
            "NONE",
            "Scalar",
            "Enumeration",
            "Bitmask"});
            this.cBoxWatchScaleType.Location = new System.Drawing.Point(113, 168);
            this.cBoxWatchScaleType.Name = "cBoxWatchScaleType";
            this.cBoxWatchScaleType.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchScaleType.TabIndex = 15;
            // 
            // lblWatchUnitsEnumBitmask
            // 
            this.lblWatchUnitsEnumBitmask.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchUnitsEnumBitmask.Location = new System.Drawing.Point(13, 210);
            this.lblWatchUnitsEnumBitmask.Name = "lblWatchUnitsEnumBitmask";
            this.lblWatchUnitsEnumBitmask.Size = new System.Drawing.Size(93, 17);
            this.lblWatchUnitsEnumBitmask.TabIndex = 14;
            this.lblWatchUnitsEnumBitmask.Text = "Units";
            this.lblWatchUnitsEnumBitmask.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchUnits
            // 
            this.cBoxWatchUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchUnits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchUnits.FormattingEnabled = true;
            this.cBoxWatchUnits.Location = new System.Drawing.Point(113, 205);
            this.cBoxWatchUnits.Name = "cBoxWatchUnits";
            this.cBoxWatchUnits.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchUnits.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Scale Type";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxWatchDataType
            // 
            this.cBoxWatchDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWatchDataType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWatchDataType.FormattingEnabled = true;
            this.cBoxWatchDataType.Items.AddRange(new object[] {
            "BOOL",
            "UINT_8",
            "UINT_16",
            "UINT_32",
            "INT_8",
            "INT_16",
            "INT_32",
            "FLOAT",
            "DOUBLE"});
            this.cBoxWatchDataType.Location = new System.Drawing.Point(113, 135);
            this.cBoxWatchDataType.Name = "cBoxWatchDataType";
            this.cBoxWatchDataType.Size = new System.Drawing.Size(143, 25);
            this.cBoxWatchDataType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxWatchEmbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxWatchDisplayName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Embedded";
            // 
            // tBoxWatchEmbName
            // 
            this.tBoxWatchEmbName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchEmbName.Location = new System.Drawing.Point(76, 60);
            this.tBoxWatchEmbName.Name = "tBoxWatchEmbName";
            this.tBoxWatchEmbName.Size = new System.Drawing.Size(404, 24);
            this.tBoxWatchEmbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display";
            // 
            // tBoxWatchDisplayName
            // 
            this.tBoxWatchDisplayName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWatchDisplayName.Location = new System.Drawing.Point(76, 31);
            this.tBoxWatchDisplayName.Name = "tBoxWatchDisplayName";
            this.tBoxWatchDisplayName.Size = new System.Drawing.Size(404, 24);
            this.tBoxWatchDisplayName.TabIndex = 0;
            // 
            // FormEventVariableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 404);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxWatchAttrs);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FormEventVariableEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Variable Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEventEditor_KeyDown);
            this.grpBoxWatchAttrs.ResumeLayout(false);
            this.grpBoxWatchAttrs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxWatchAttrs;
        private System.Windows.Forms.ComboBox cBoxWatchUnitConversion;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cBoxWatchScaleInfo;
        private System.Windows.Forms.Label lblWatchUnitConversion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWatchScaleInfo;
        private System.Windows.Forms.ComboBox cBoxWatchFormatString;
        private System.Windows.Forms.Label lblFormatString;
        private System.Windows.Forms.ComboBox cBoxWatchScaleType;
        private System.Windows.Forms.Label lblWatchUnitsEnumBitmask;
        private System.Windows.Forms.ComboBox cBoxWatchUnits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBoxWatchDataType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxWatchEmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxWatchDisplayName;

    }
}