namespace DDB
{
    partial class FormDeleteMe
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
            this.userControlEntityEditor2 = new DDB.UserControlEntityEditor();
            this.userControlEntityEditor1 = new DDB.UserControlEntityEditor();
            this.SuspendLayout();
            // 
            // userControlEntityEditor2
            // 
            this.userControlEntityEditor2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlEntityEditor2.Location = new System.Drawing.Point(349, 30);
            this.userControlEntityEditor2.Name = "userControlEntityEditor2";
            this.userControlEntityEditor2.Size = new System.Drawing.Size(281, 460);
            this.userControlEntityEditor2.TabIndex = 1;
            this.userControlEntityEditor2.xGroupBoxTitle = "Golf Balls";
            // 
            // userControlEntityEditor1
            // 
            this.userControlEntityEditor1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlEntityEditor1.Location = new System.Drawing.Point(33, 30);
            this.userControlEntityEditor1.Name = "userControlEntityEditor1";
            this.userControlEntityEditor1.Size = new System.Drawing.Size(281, 444);
            this.userControlEntityEditor1.TabIndex = 0;
            this.userControlEntityEditor1.xGroupBoxTitle = "Cars";
            // 
            // FormDeleteMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(757, 558);
            this.Controls.Add(this.userControlEntityEditor2);
            this.Controls.Add(this.userControlEntityEditor1);
            this.Name = "FormDeleteMe";
            this.Text = "FormDeleteMe";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlEntityEditor userControlEntityEditor1;
        private UserControlEntityEditor userControlEntityEditor2;
    }
}