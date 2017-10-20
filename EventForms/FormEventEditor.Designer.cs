namespace DDB
{
    partial class FormEventEditor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxEventName = new System.Windows.Forms.TextBox();
            this.tBoxDefineName = new System.Windows.Forms.TextBox();
            this.cBoxEventStructs = new System.Windows.Forms.ComboBox();
            this.cBoxEventLogs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(438, 105);
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
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Embedded Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Event Structure";
            // 
            // tBoxEventName
            // 
            this.tBoxEventName.Location = new System.Drawing.Point(133, 21);
            this.tBoxEventName.Name = "tBoxEventName";
            this.tBoxEventName.Size = new System.Drawing.Size(100, 27);
            this.tBoxEventName.TabIndex = 10;
            this.tBoxEventName.TextChanged += new System.EventHandler(this.tBoxEventName_TextChanged);
            // 
            // tBoxDefineName
            // 
            this.tBoxDefineName.Location = new System.Drawing.Point(133, 59);
            this.tBoxDefineName.Name = "tBoxDefineName";
            this.tBoxDefineName.Size = new System.Drawing.Size(100, 27);
            this.tBoxDefineName.TabIndex = 11;
            this.tBoxDefineName.TextChanged += new System.EventHandler(this.tBoxDefineName_TextChanged);
            // 
            // cBoxEventStructs
            // 
            this.cBoxEventStructs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEventStructs.FormattingEnabled = true;
            this.cBoxEventStructs.Location = new System.Drawing.Point(133, 98);
            this.cBoxEventStructs.Name = "cBoxEventStructs";
            this.cBoxEventStructs.Size = new System.Drawing.Size(247, 27);
            this.cBoxEventStructs.TabIndex = 12;
            // 
            // cBoxEventLogs
            // 
            this.cBoxEventLogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEventLogs.FormattingEnabled = true;
            this.cBoxEventLogs.Location = new System.Drawing.Point(133, 140);
            this.cBoxEventLogs.Name = "cBoxEventLogs";
            this.cBoxEventLogs.Size = new System.Drawing.Size(247, 27);
            this.cBoxEventLogs.TabIndex = 13;
            // 
            // FormEventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 190);
            this.ControlBox = false;
            this.Controls.Add(this.cBoxEventLogs);
            this.Controls.Add(this.cBoxEventStructs);
            this.Controls.Add(this.tBoxDefineName);
            this.Controls.Add(this.tBoxEventName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEventEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEventEditor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxEventName;
        private System.Windows.Forms.TextBox tBoxDefineName;
        private System.Windows.Forms.ComboBox cBoxEventStructs;
        private System.Windows.Forms.ComboBox cBoxEventLogs;
    }
}