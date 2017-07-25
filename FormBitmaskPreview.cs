using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormBitmaskPreview: Form
    {

        public FormBitmaskPreview()
        {
            InitializeComponent();
            InitDataGrid();
        }

        public void UpdateForm (BitmaskTest bm)
        {
            this.Text = "Bitmask Preview for \"" + bm.dispName + "\"";
            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 0);

            int populatedRowCount = 0;
            for (int index = 31; index >= 0; index--)
            {
                if (!String.IsNullOrEmpty(bm.strValues[index]))
                {
                    Console.WriteLine(bm.strValues[index]);
                    dataGridView1.Rows.Add(index.ToString(), bm.strValues[index]);
                    populatedRowCount++;
                }
            }

            this.Size = new Size(436, 100 + populatedRowCount * 25);
            dataGridView1.Size = new Size(436, 75 + populatedRowCount * 25);
        }

        private void InitDataGrid()
        {
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = dataGridView1.Width - (dataGridView1.Columns[0].Width);

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderCell.Style = style;
            dataGridView1.Columns[1].HeaderCell.Style = style;

            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.Columns[0].DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionForeColor = Color.Black;
        }

    }
}