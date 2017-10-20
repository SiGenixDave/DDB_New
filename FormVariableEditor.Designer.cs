namespace DDB
{
    partial class FormVariableEditor
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
            this.userControlVariableEditor1 = new DDB.UserControlVariableEditor();
            this.SuspendLayout();
            // 
            // userControlVariableEditor1
            // 
            this.userControlVariableEditor1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlVariableEditor1.Location = new System.Drawing.Point(13, 13);
            this.userControlVariableEditor1.Name = "userControlVariableEditor1";
            this.userControlVariableEditor1.Size = new System.Drawing.Size(512, 420);
            this.userControlVariableEditor1.TabIndex = 0;
            this.userControlVariableEditor1.xChartScalingGroupBox = false;
            this.userControlVariableEditor1.xOptionsGroupBox = false;
            this.userControlVariableEditor1.xVarModGroupBox = false;
            // 
            // FormVariableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 438);
            this.ControlBox = false;
            this.Controls.Add(this.userControlVariableEditor1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVariableEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Variable Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlVariableEditor userControlVariableEditor1;


    }
}