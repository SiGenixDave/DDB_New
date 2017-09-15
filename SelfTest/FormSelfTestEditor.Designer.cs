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
            this.userControlDualSelector2 = new DDB.UserControlDualSelector();
            this.userControlDualSelector1 = new DDB.UserControlDualSelector();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(23, 533);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(23, 486);
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
            this.label1.Location = new System.Drawing.Point(62, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Embedded Name";
            // 
            // tBoxSelfTestName
            // 
            this.tBoxSelfTestName.Location = new System.Drawing.Point(148, 230);
            this.tBoxSelfTestName.Name = "tBoxSelfTestName";
            this.tBoxSelfTestName.Size = new System.Drawing.Size(100, 23);
            this.tBoxSelfTestName.TabIndex = 10;
            // 
            // tBoxDefineName
            // 
            this.tBoxDefineName.Location = new System.Drawing.Point(148, 308);
            this.tBoxDefineName.Name = "tBoxDefineName";
            this.tBoxDefineName.Size = new System.Drawing.Size(100, 23);
            this.tBoxDefineName.TabIndex = 11;
            // 
            // tBoxSelfTestNumber
            // 
            this.tBoxSelfTestNumber.Location = new System.Drawing.Point(148, 266);
            this.tBoxSelfTestNumber.Name = "tBoxSelfTestNumber";
            this.tBoxSelfTestNumber.Size = new System.Drawing.Size(100, 23);
            this.tBoxSelfTestNumber.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Test Number";
            // 
            // userControlDualSelector2
            // 
            this.userControlDualSelector2.Location = new System.Drawing.Point(254, 14);
            this.userControlDualSelector2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlDualSelector2.Name = "userControlDualSelector2";
            this.userControlDualSelector2.Size = new System.Drawing.Size(276, 542);
            this.userControlDualSelector2.TabIndex = 15;
            this.userControlDualSelector2.xFilterVisible = false;
            this.userControlDualSelector2.xGroupBoxTitle = "Used Variables";
            // 
            // userControlDualSelector1
            // 
            this.userControlDualSelector1.Location = new System.Drawing.Point(536, 14);
            this.userControlDualSelector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlDualSelector1.Name = "userControlDualSelector1";
            this.userControlDualSelector1.Size = new System.Drawing.Size(276, 542);
            this.userControlDualSelector1.TabIndex = 16;
            this.userControlDualSelector1.xGroupBoxTitle = "Available Variables";
            this.userControlDualSelector1.xVisibleMoveDownButton = false;
            this.userControlDualSelector1.xVisibleMoveUpButton = false;
            // 
            // FormSelfTestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 568);
            this.ControlBox = false;
            this.Controls.Add(this.userControlDualSelector1);
            this.Controls.Add(this.userControlDualSelector2);
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
            this.Name = "FormSelfTestEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Self Test Editor";
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
        private UserControlDualSelector userControlDualSelector2;
        private UserControlDualSelector userControlDualSelector1;
    }
}