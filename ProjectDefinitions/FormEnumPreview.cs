using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEnumPreview: Form
    {

        public FormEnumPreview()
        {
            InitializeComponent();
            InitDataGrid();
        }

        public void UpdateForm (EnumsTest enm)
        {
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

            if (enm == null)
            {
                return;
            }

            this.Text = "Enumeration Preview for \"" + enm.dispName + "\"";
            int index = 0;
            foreach (String str in enm.strValues)
            {
                dataGridView1.Rows.Add(enm.intValues[index], enm.strValues[index]);
                index++;
            }

            this.Size = new Size(436, 100 + index * 25);
            dataGridView1.Size = new Size(436, 75 + index * 25);
        }

        private void InitDataGrid()
        {
            dataGridView1.Columns[0].Width = 60;
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