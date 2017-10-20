namespace DDB
{
    partial class FormSelfTestEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxSelfTestName = new System.Windows.Forms.TextBox();
            this.tBoxDefineName = new System.Windows.Forms.TextBox();
            this.tBoxSelfTestNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMessage = new System.Windows.Forms.RadioButton();
            this.cBoxTestStep = new System.Windows.Forms.ComboBox();
            this.checkBoxViewEntireTest = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStepNumber = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.cBoxMessageAction = new System.Windows.Forms.ComboBox();
            this.rbTestDescription = new System.Windows.Forms.RadioButton();
            this.ucDS_AvailableVars = new DDB.UserControlDualSelector();
            this.ucDS_UsedVars = new DDB.UserControlDualSelector();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(148, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(29, 446);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(66, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Embedded Name";
            // 
            // tBoxSelfTestName
            // 
            this.tBoxSelfTestName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSelfTestName.Location = new System.Drawing.Point(12, 41);
            this.tBoxSelfTestName.Name = "tBoxSelfTestName";
            this.tBoxSelfTestName.Size = new System.Drawing.Size(223, 24);
            this.tBoxSelfTestName.TabIndex = 10;
            // 
            // tBoxDefineName
            // 
            this.tBoxDefineName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDefineName.Location = new System.Drawing.Point(12, 141);
            this.tBoxDefineName.Name = "tBoxDefineName";
            this.tBoxDefineName.Size = new System.Drawing.Size(223, 24);
            this.tBoxDefineName.TabIndex = 11;
            // 
            // tBoxSelfTestNumber
            // 
            this.tBoxSelfTestNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSelfTestNumber.Location = new System.Drawing.Point(12, 88);
            this.tBoxSelfTestNumber.Name = "tBoxSelfTestNumber";
            this.tBoxSelfTestNumber.Size = new System.Drawing.Size(69, 24);
            this.tBoxSelfTestNumber.TabIndex = 13;
            this.tBoxSelfTestNumber.TextChanged += new System.EventHandler(this.tBoxSelfTestNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Test Number";
            // 
            // rbMessage
            // 
            this.rbMessage.AutoSize = true;
            this.rbMessage.Location = new System.Drawing.Point(112, 20);
            this.rbMessage.Name = "rbMessage";
            this.rbMessage.Size = new System.Drawing.Size(80, 21);
            this.rbMessage.TabIndex = 18;
            this.rbMessage.Text = "Message";
            this.rbMessage.UseVisualStyleBackColor = true;
            this.rbMessage.CheckedChanged += new System.EventHandler(this.rbMessage_CheckedChanged);
            // 
            // cBoxTestStep
            // 
            this.cBoxTestStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTestStep.Enabled = false;
            this.cBoxTestStep.FormattingEnabled = true;
            this.cBoxTestStep.Location = new System.Drawing.Point(112, 87);
            this.cBoxTestStep.Name = "cBoxTestStep";
            this.cBoxTestStep.Size = new System.Drawing.Size(75, 25);
            this.cBoxTestStep.TabIndex = 19;
            // 
            // checkBoxViewEntireTest
            // 
            this.checkBoxViewEntireTest.AutoSize = true;
            this.checkBoxViewEntireTest.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxViewEntireTest.Location = new System.Drawing.Point(9, 160);
            this.checkBoxViewEntireTest.Name = "checkBoxViewEntireTest";
            this.checkBoxViewEntireTest.Size = new System.Drawing.Size(238, 21);
            this.checkBoxViewEntireTest.TabIndex = 20;
            this.checkBoxViewEntireTest.Text = "View Description and All Messages)";
            this.checkBoxViewEntireTest.UseVisualStyleBackColor = true;
            this.checkBoxViewEntireTest.CheckedChanged += new System.EventHandler(this.checkBoxViewEntireTest_CheckedChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(9, 122);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 21;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStepNumber);
            this.groupBox1.Controls.Add(this.checkBoxViewEntireTest);
            this.groupBox1.Controls.Add(this.lblAction);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.cBoxMessageAction);
            this.groupBox1.Controls.Add(this.rbTestDescription);
            this.groupBox1.Controls.Add(this.cBoxTestStep);
            this.groupBox1.Controls.Add(this.rbMessage);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 183);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Test";
            // 
            // lblStepNumber
            // 
            this.lblStepNumber.AutoSize = true;
            this.lblStepNumber.Enabled = false;
            this.lblStepNumber.Location = new System.Drawing.Point(66, 90);
            this.lblStepNumber.Name = "lblStepNumber";
            this.lblStepNumber.Size = new System.Drawing.Size(50, 17);
            this.lblStepNumber.TabIndex = 23;
            this.lblStepNumber.Text = "Step #";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Enabled = false;
            this.lblAction.Location = new System.Drawing.Point(66, 55);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(46, 17);
            this.lblAction.TabIndex = 22;
            this.lblAction.Text = "Action";
            // 
            // cBoxMessageAction
            // 
            this.cBoxMessageAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMessageAction.Enabled = false;
            this.cBoxMessageAction.FormattingEnabled = true;
            this.cBoxMessageAction.Location = new System.Drawing.Point(112, 52);
            this.cBoxMessageAction.Name = "cBoxMessageAction";
            this.cBoxMessageAction.Size = new System.Drawing.Size(75, 25);
            this.cBoxMessageAction.TabIndex = 21;
            this.cBoxMessageAction.SelectedIndexChanged += new System.EventHandler(this.cBoxMessageAction_SelectedIndexChanged);
            // 
            // rbTestDescription
            // 
            this.rbTestDescription.AutoSize = true;
            this.rbTestDescription.Checked = true;
            this.rbTestDescription.Location = new System.Drawing.Point(17, 22);
            this.rbTestDescription.Name = "rbTestDescription";
            this.rbTestDescription.Size = new System.Drawing.Size(97, 21);
            this.rbTestDescription.TabIndex = 17;
            this.rbTestDescription.TabStop = true;
            this.rbTestDescription.Text = "Description";
            this.rbTestDescription.UseVisualStyleBackColor = true;
            this.rbTestDescription.CheckedChanged += new System.EventHandler(this.rbTestDescription_CheckedChanged);
            // 
            // ucDS_AvailableVars
            // 
            this.ucDS_AvailableVars.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDS_AvailableVars.Location = new System.Drawing.Point(536, 14);
            this.ucDS_AvailableVars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDS_AvailableVars.Name = "ucDS_AvailableVars";
            this.ucDS_AvailableVars.Size = new System.Drawing.Size(276, 461);
            this.ucDS_AvailableVars.TabIndex = 16;
            this.ucDS_AvailableVars.xGroupBoxTitle = "Available Variables";
            this.ucDS_AvailableVars.xVisibleMoveDownButton = false;
            this.ucDS_AvailableVars.xVisibleMoveUpButton = false;
            // 
            // ucDS_UsedVars
            // 
            this.ucDS_UsedVars.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDS_UsedVars.Location = new System.Drawing.Point(254, 14);
            this.ucDS_UsedVars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDS_UsedVars.Name = "ucDS_UsedVars";
            this.ucDS_UsedVars.Size = new System.Drawing.Size(276, 461);
            this.ucDS_UsedVars.TabIndex = 15;
            this.ucDS_UsedVars.xFilterVisible = false;
            this.ucDS_UsedVars.xGroupBoxTitle = "Used Variables";
            // 
            // FormSelfTestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 481);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucDS_AvailableVars);
            this.Controls.Add(this.ucDS_UsedVars);
            this.Controls.Add(this.tBoxSelfTestNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxDefineName);
            this.Controls.Add(this.tBoxSelfTestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelfTestEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Self Test Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxSelfTestName;
        private System.Windows.Forms.TextBox tBoxDefineName;
        private System.Windows.Forms.TextBox tBoxSelfTestNumber;
        private System.Windows.Forms.Label label3;
        private UserControlDualSelector ucDS_UsedVars;
        private UserControlDualSelector ucDS_AvailableVars;
        private System.Windows.Forms.RadioButton rbMessage;
        private System.Windows.Forms.ComboBox cBoxTestStep;
        private System.Windows.Forms.CheckBox checkBoxViewEntireTest;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxMessageAction;
        private System.Windows.Forms.RadioButton rbTestDescription;
        private System.Windows.Forms.Label lblStepNumber;
        private System.Windows.Forms.Label lblAction;
    }
}