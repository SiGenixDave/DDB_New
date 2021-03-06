﻿namespace DDB
{
    partial class FormEventStructurePreview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.esDispName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esEmbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.esDispName,
            this.esEmbName,
            this.esDataType});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(436, 100);
            this.dataGridView1.TabIndex = 0;
            // 
            // esDispName
            // 
            this.esDispName.Frozen = true;
            this.esDispName.HeaderText = "Display Name";
            this.esDispName.Name = "esDispName";
            this.esDispName.ReadOnly = true;
            // 
            // esEmbName
            // 
            this.esEmbName.Frozen = true;
            this.esEmbName.HeaderText = "Emb. Name";
            this.esEmbName.Name = "esEmbName";
            this.esEmbName.ReadOnly = true;
            this.esEmbName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // esDataType
            // 
            this.esDataType.Frozen = true;
            this.esDataType.HeaderText = "Data Type";
            this.esDataType.Name = "esDataType";
            this.esDataType.ReadOnly = true;
            this.esDataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormEventStructurePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 156);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEventStructurePreview";
            this.Text = "Event Structure Preview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn esDispName;
        private System.Windows.Forms.DataGridViewTextBoxColumn esEmbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn esDataType;
    }
}