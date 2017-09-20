namespace DDB
{
    partial class FormEventStructureEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxStructName = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ucDS_UsedEventVars = new DDB.UserControlDualSelector();
            this.ucDS_AvailEventVars = new DDB.UserControlDualSelector();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Structure Name:";
            // 
            // tBoxStructName
            // 
            this.tBoxStructName.Location = new System.Drawing.Point(107, 6);
            this.tBoxStructName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxStructName.Name = "tBoxStructName";
            this.tBoxStructName.Size = new System.Drawing.Size(86, 21);
            this.tBoxStructName.TabIndex = 3;
            this.tBoxStructName.TextChanged += new System.EventHandler(this.tBoxStructName_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(530, 415);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(64, 32);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(530, 461);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucDS_SelfTestMessageList
            // 
            this.ucDS_UsedEventVars.Location = new System.Drawing.Point(12, 32);
            this.ucDS_UsedEventVars.Name = "ucDS_SelfTestMessageList";
            this.ucDS_UsedEventVars.Size = new System.Drawing.Size(276, 456);
            this.ucDS_UsedEventVars.TabIndex = 12;
            this.ucDS_UsedEventVars.xFilterVisible = false;
            this.ucDS_UsedEventVars.xGroupBoxTitle = "Used Event Variables";
            // 
            // ucDS_AvailEventVars
            // 
            this.ucDS_AvailEventVars.Location = new System.Drawing.Point(268, 32);
            this.ucDS_AvailEventVars.Name = "ucDS_AvailEventVars";
            this.ucDS_AvailEventVars.Size = new System.Drawing.Size(256, 456);
            this.ucDS_AvailEventVars.TabIndex = 13;
            this.ucDS_AvailEventVars.xGroupBoxTitle = "Available Event Variables";
            this.ucDS_AvailEventVars.xVisibleMoveDownButton = false;
            this.ucDS_AvailEventVars.xVisibleMoveUpButton = false;
            // 
            // FormEventStructureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 504);
            this.ControlBox = false;
            this.Controls.Add(this.ucDS_AvailEventVars);
            this.Controls.Add(this.ucDS_UsedEventVars);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tBoxStructName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEventStructureEditor";
            this.Text = "Event Structure Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxStructName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private UserControlDualSelector ucDS_UsedEventVars;
        private UserControlDualSelector ucDS_AvailEventVars;
    }
}