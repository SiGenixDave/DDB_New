namespace DDB
{
    partial class FormEventPreview
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblCdefineName = new System.Windows.Forms.Label();
            this.lblEventStructure = new System.Windows.Forms.Label();
            this.lblEventLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"C\" #define Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event Structure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event Log:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(151, 9);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(145, 21);
            this.lblEventName.TabIndex = 8;
            this.lblEventName.Text = "                           ";
            // 
            // lblCdefineName
            // 
            this.lblCdefineName.AutoSize = true;
            this.lblCdefineName.Location = new System.Drawing.Point(151, 36);
            this.lblCdefineName.Name = "lblCdefineName";
            this.lblCdefineName.Size = new System.Drawing.Size(130, 21);
            this.lblCdefineName.TabIndex = 9;
            this.lblCdefineName.Text = "                        ";
            // 
            // lblEventStructure
            // 
            this.lblEventStructure.AutoSize = true;
            this.lblEventStructure.Location = new System.Drawing.Point(151, 63);
            this.lblEventStructure.Name = "lblEventStructure";
            this.lblEventStructure.Size = new System.Drawing.Size(160, 21);
            this.lblEventStructure.TabIndex = 10;
            this.lblEventStructure.Text = "                              ";
            // 
            // lblEventLog
            // 
            this.lblEventLog.AutoSize = true;
            this.lblEventLog.Location = new System.Drawing.Point(151, 90);
            this.lblEventLog.Name = "lblEventLog";
            this.lblEventLog.Size = new System.Drawing.Size(100, 21);
            this.lblEventLog.TabIndex = 11;
            this.lblEventLog.Text = "                  ";
            // 
            // FormEventPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 133);
            this.ControlBox = false;
            this.Controls.Add(this.lblEventLog);
            this.Controls.Add(this.lblEventStructure);
            this.Controls.Add(this.lblCdefineName);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEventPreview";
            this.Text = "FormEventPreview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblCdefineName;
        private System.Windows.Forms.Label lblEventStructure;
        private System.Windows.Forms.Label lblEventLog;
    }
}