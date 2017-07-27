using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEnumsEditor : Form
    {
        private EnumsTest enm;

        public FormEnumsEditor(EnumsTest em)
        {
            InitializeComponent();
            enm = em;
            this.Text = "Edit Enumeration " + "\"" + enm.dispName + "\"";
            InitDataGrid();
        }

        private void InitDataGrid()
        {
            for (int index = 0; index < enm.intValues.Count; index++)
            {
                dataGridView1.Rows.Add(enm.intValues[index].ToString(), enm.strValues[index]);
            }

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = dataGridView1.Width - dataGridView1.Columns[0].Width;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderCell.Style = style;
            dataGridView1.Columns[1].HeaderCell.Style = style;

            tBoxName.Text = enm.dispName;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Enumeration \"" + enm.dispName + "\" " ))
            {
                Close();
            }
        }

        private void Save()
        {
            enm.dispName = tBoxName.Text;

            enm.strValues.Clear();
            enm.intValues.Clear();

            for (int index = 0; index < dataGridView1.RowCount; index++)
            {
                String strValue = dataGridView1.Rows[index].Cells[1].Value.ToString();
                int intValue;
                int.TryParse(dataGridView1.Rows[index].Cells[0].Value.ToString(), out intValue);
                enm.strValues.Add(strValue);
                enm.intValues.Add(intValue);
            }
        }

        private void tBoxName_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(tBoxName.Text, tBoxName.Font);
            tBoxName.Width = size.Width;
            tBoxName.Height = size.Height;
        }


        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void btnAddNewValue_Click(object sender, EventArgs e)
        {
            // Scan the datagridView for the highest value and insert the next highest and select
            // the cell with description
            int highestValue = int.MinValue;

            int rowindex = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                int i;
                int.TryParse(r.Cells[0].Value.ToString(), out i);
                if (i > highestValue)
                {
                    highestValue = i;
                }
                rowindex++;
            }


            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = highestValue + 1;
            row.Cells[1].Value = "Description";
            dataGridView1.Rows.Add(row);
            dataGridView1.CurrentCell = dataGridView1.Rows[rowindex].Cells[1];
            dataGridView1.BeginEdit(true);
            
        }
    }
}