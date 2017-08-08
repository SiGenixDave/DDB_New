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
            this.lBoxUsedVars = new System.Windows.Forms.ListBox();
            this.lBoxAvailableVars = new System.Windows.Forms.ListBox();
            this.tBoxStructName = new System.Windows.Forms.TextBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnEventFilterClear = new System.Windows.Forms.Button();
            this.btnEventFilterApply = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Structure Name:";
            // 
            // lBoxUsedVars
            // 
            this.lBoxUsedVars.FormattingEnabled = true;
            this.lBoxUsedVars.HorizontalScrollbar = true;
            this.lBoxUsedVars.ItemHeight = 16;
            this.lBoxUsedVars.Location = new System.Drawing.Point(12, 73);
            this.lBoxUsedVars.Name = "lBoxUsedVars";
            this.lBoxUsedVars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBoxUsedVars.Size = new System.Drawing.Size(158, 356);
            this.lBoxUsedVars.TabIndex = 1;
            this.lBoxUsedVars.SelectedIndexChanged += new System.EventHandler(this.lBoxUsedVars_SelectedIndexChanged);
            this.lBoxUsedVars.Enter += new System.EventHandler(this.lBoxUsedVars_Enter);
            this.lBoxUsedVars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxUsedVars_MouseDoubleClick);
            // 
            // lBoxAvailableVars
            // 
            this.lBoxAvailableVars.FormattingEnabled = true;
            this.lBoxAvailableVars.HorizontalScrollbar = true;
            this.lBoxAvailableVars.ItemHeight = 16;
            this.lBoxAvailableVars.Location = new System.Drawing.Point(256, 73);
            this.lBoxAvailableVars.Name = "lBoxAvailableVars";
            this.lBoxAvailableVars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBoxAvailableVars.Size = new System.Drawing.Size(158, 356);
            this.lBoxAvailableVars.TabIndex = 2;
            this.lBoxAvailableVars.Enter += new System.EventHandler(this.lBoxAvailableVars_Enter);
            this.lBoxAvailableVars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxAvailableVars_MouseDoubleClick);
            // 
            // tBoxStructName
            // 
            this.tBoxStructName.Location = new System.Drawing.Point(125, 8);
            this.tBoxStructName.Name = "tBoxStructName";
            this.tBoxStructName.Size = new System.Drawing.Size(100, 23);
            this.tBoxStructName.TabIndex = 3;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(95, 462);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 44);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(12, 462);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 44);
            this.btnMoveUp.TabIndex = 5;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(462, 219);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 40);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(176, 221);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 40);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Move Selected";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Used Event Variables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Available Event Variables";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(420, 483);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 23);
            this.button9.TabIndex = 37;
            this.button9.Text = "Sort Des";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(420, 454);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 23);
            this.button14.TabIndex = 36;
            this.button14.Text = "Sort Asc";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btnEventFilterClear
            // 
            this.btnEventFilterClear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventFilterClear.Location = new System.Drawing.Point(339, 484);
            this.btnEventFilterClear.Name = "btnEventFilterClear";
            this.btnEventFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btnEventFilterClear.TabIndex = 35;
            this.btnEventFilterClear.Text = "Clear Filter";
            this.btnEventFilterClear.UseVisualStyleBackColor = true;
            // 
            // btnEventFilterApply
            // 
            this.btnEventFilterApply.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventFilterApply.Location = new System.Drawing.Point(258, 484);
            this.btnEventFilterApply.Name = "btnEventFilterApply";
            this.btnEventFilterApply.Size = new System.Drawing.Size(75, 23);
            this.btnEventFilterApply.TabIndex = 34;
            this.btnEventFilterApply.Text = "Apply Filter";
            this.btnEventFilterApply.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(258, 454);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 21);
            this.textBox4.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(255, 438);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Filter";
            // 
            // FormEventStructureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 523);
            this.ControlBox = false;
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnEventFilterClear);
            this.Controls.Add(this.btnEventFilterApply);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.tBoxStructName);
            this.Controls.Add(this.lBoxAvailableVars);
            this.Controls.Add(this.lBoxUsedVars);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEventStructureEditor";
            this.Text = "Event Structure Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxUsedVars;
        private System.Windows.Forms.ListBox lBoxAvailableVars;
        private System.Windows.Forms.TextBox tBoxStructName;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnEventFilterClear;
        private System.Windows.Forms.Button btnEventFilterApply;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label20;
    }
}