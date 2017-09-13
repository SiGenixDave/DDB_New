namespace DDB
{
    partial class UserControlDualSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sortAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDescendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnMoveDown);
            this.groupBox.Controls.Add(this.btnMoveUp);
            this.groupBox.Controls.Add(this.labelSortOrder);
            this.groupBox.Controls.Add(this.txtBoxFilter);
            this.groupBox.Controls.Add(this.lblFilter);
            this.groupBox.Controls.Add(this.listBox);
            this.groupBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(15, 16);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(219, 421);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Group Box Title";
            this.groupBox.Leave += new System.EventHandler(this.groupBox_Leave);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Location = new System.Drawing.Point(94, 355);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 36;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Location = new System.Drawing.Point(9, 356);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 35;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // labelSortOrder
            // 
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortOrder.Location = new System.Drawing.Point(170, 18);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(0, 33);
            this.labelSortOrder.TabIndex = 34;
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFilter.Location = new System.Drawing.Point(43, 394);
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(156, 21);
            this.txtBoxFilter.TabIndex = 24;
            this.txtBoxFilter.TextChanged += new System.EventHandler(this.txtBoxFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(6, 397);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(31, 13);
            this.lblFilter.TabIndex = 23;
            this.lblFilter.Text = "Filter";
            // 
            // listBox
            // 
            this.listBox.ContextMenuStrip = this.contextMenuStrip;
            this.listBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(8, 59);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(161, 290);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveSelectedToolStripMenuItem,
            this.toolStripSeparator3,
            this.sortAscendingToolStripMenuItem,
            this.sortDescendingToolStripMenuItem,
            this.unsortToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 98);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // moveSelectedToolStripMenuItem
            // 
            this.moveSelectedToolStripMenuItem.Enabled = false;
            this.moveSelectedToolStripMenuItem.Name = "moveSelectedToolStripMenuItem";
            this.moveSelectedToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.moveSelectedToolStripMenuItem.Text = "Move Selected";
            this.moveSelectedToolStripMenuItem.Click += new System.EventHandler(this.moveSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(148, 6);
            // 
            // sortAscendingToolStripMenuItem
            // 
            this.sortAscendingToolStripMenuItem.Name = "sortAscendingToolStripMenuItem";
            this.sortAscendingToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sortAscendingToolStripMenuItem.Text = "Sort A to Z";
            this.sortAscendingToolStripMenuItem.Click += new System.EventHandler(this.sortAscendingToolStripMenuItem_Click);
            // 
            // sortDescendingToolStripMenuItem
            // 
            this.sortDescendingToolStripMenuItem.Name = "sortDescendingToolStripMenuItem";
            this.sortDescendingToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sortDescendingToolStripMenuItem.Text = "Sort Z to A";
            this.sortDescendingToolStripMenuItem.Click += new System.EventHandler(this.sortDescendingToolStripMenuItem_Click);
            // 
            // unsortToolStripMenuItem
            // 
            this.unsortToolStripMenuItem.Name = "unsortToolStripMenuItem";
            this.unsortToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.unsortToolStripMenuItem.Text = "Unsorted";
            this.unsortToolStripMenuItem.Click += new System.EventHandler(this.restoreAllToolStripMenuItem_Click);
            // 
            // UserControlDualSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlDualSelector";
            this.Size = new System.Drawing.Size(276, 456);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem moveSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDescendingToolStripMenuItem;
        private System.Windows.Forms.Label labelSortOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem unsortToolStripMenuItem;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
    }
}
