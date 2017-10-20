namespace DDB
{
    partial class FormSelfTestListEditor
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDS_UsedTests = new DDB.UserControlDualSelector();
            this.ucDS_AvailableTests = new DDB.UserControlDualSelector();
            this.cBoxTestList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(565, 508);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(565, 450);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(57, 36);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucDS_UsedTests);
            this.groupBox1.Controls.Add(this.ucDS_AvailableTests);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 488);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tests";
            // 
            // ucDS_UsedTests
            // 
            this.ucDS_UsedTests.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDS_UsedTests.Location = new System.Drawing.Point(32, 20);
            this.ucDS_UsedTests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucDS_UsedTests.Name = "ucDS_UsedTests";
            this.ucDS_UsedTests.Size = new System.Drawing.Size(237, 451);
            this.ucDS_UsedTests.TabIndex = 15;
            this.ucDS_UsedTests.xFilterVisible = false;
            this.ucDS_UsedTests.xGroupBoxTitle = "Used";
            // 
            // ucDS_AvailableTests
            // 
            this.ucDS_AvailableTests.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDS_AvailableTests.Location = new System.Drawing.Point(275, 20);
            this.ucDS_AvailableTests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucDS_AvailableTests.Name = "ucDS_AvailableTests";
            this.ucDS_AvailableTests.Size = new System.Drawing.Size(237, 451);
            this.ucDS_AvailableTests.TabIndex = 16;
            this.ucDS_AvailableTests.xGroupBoxTitle = "Available";
            this.ucDS_AvailableTests.xVisibleMoveDownButton = false;
            this.ucDS_AvailableTests.xVisibleMoveUpButton = false;
            // 
            // cBoxTestList
            // 
            this.cBoxTestList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTestList.FormattingEnabled = true;
            this.cBoxTestList.Location = new System.Drawing.Point(12, 12);
            this.cBoxTestList.Name = "cBoxTestList";
            this.cBoxTestList.Size = new System.Drawing.Size(177, 25);
            this.cBoxTestList.TabIndex = 19;
            this.cBoxTestList.SelectedIndexChanged += new System.EventHandler(this.cBoxTestList_SelectedIndexChanged);
            // 
            // FormSelfTestListEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 555);
            this.ControlBox = false;
            this.Controls.Add(this.cBoxTestList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelfTestListEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Self Test List Editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private UserControlDualSelector ucDS_UsedTests;
        private UserControlDualSelector ucDS_AvailableTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxTestList;
    }
}