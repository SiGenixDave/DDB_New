using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormEnumsEditor : Form
    {
        private Enums enm;

        public FormEnumsEditor(Enums em, Boolean modifyNewEnum)
        {
            InitializeComponent();
            enm = em;
            if (modifyNewEnum)
            {
                this.Text = "Create";
            }
            else
            {
                this.Text = "Modify";
            }
            this.Text += " Enumeration " + "\"" + enm.dispName + "\"";
            InitDataGrid();
        }

        private void InitDataGrid()
        {
            for (int index = 0; index < enm.intValues.Count; index++)
            {
                dataGridView1.Rows.Add(enm.intValues[index], enm.strValues[index]);
            }

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView1.Columns[0].HeaderCell.Style = style;
            dataGridView1.Columns[1].HeaderCell.Style = style;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = dataGridView1.Width - dataGridView1.Columns[0].Width;

            tBoxName.Text = enm.dispName;

            // Force sort using int and not string
            dataGridView1.Columns[0].CellTemplate.ValueType = typeof(int);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Query("Enumeration", enm.dispName))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItems();
        }

        private void tBoxName_TextChanged(object sender, EventArgs e)
        {
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxName.Text.Length > 0) && (tBoxName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxName.Text, tBoxName.Font);
                tBoxName.Width = size.Width;
                tBoxName.Height = size.Height;
            }
        }

        private void btnAddNewValue_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
                conMenu.Items[1].Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                conMenu.Items[1].Enabled = false;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // If editing value, need to convert to int so sorting is done properly
            if (e.ColumnIndex == 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
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
                int intValue = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
                enm.strValues.Add(strValue);
                enm.intValues.Add(intValue);
            }
        }

        private void DeleteItems()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected enumeration(s)?",
                                  "Delete Enumeration(s) Confirmation",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems();
        }

        private void addNewMemberMenuItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void AddNewItem()
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

        private void FormEnumsEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnAccept_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(null, null);
            }
        }
    }
}