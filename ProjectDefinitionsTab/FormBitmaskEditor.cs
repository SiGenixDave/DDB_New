using System;
using System.Drawing;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormBitmaskEditor : Form
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private BitmaskDB m_Bitmask;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public FormBitmaskEditor(BitmaskDB bm, Boolean createNewBitmask)
        {
            InitializeComponent();
            m_Bitmask = bm;
            if (createNewBitmask)
            {
                this.Text = "Create";
            }
            else
            {
                this.Text = "Modify";
            }
            this.Text += " Bitmask " + "\"" + bm.dispName + "\"";
            InitDataGrid(dataGridView1, 31);
            InitDataGrid(dataGridView2, 15);
            LoadInfo();
        }

        private FormBitmaskEditor()
        { }

        ////////////////////////////////////////////////////////////
        // Private methods
        ////////////////////////////////////////////////////////////
        private void InitDataGrid(DataGridView dView, int startBit)
        {
            int bmId = startBit;
            for (int index = 0; index < 16; index++)
            {
                uint hexValue = (uint)(1) << bmId;
                String bmText = String.Empty;
                if (!String.IsNullOrEmpty(m_Bitmask.strValues[bmId]))
                {
                    bmText = m_Bitmask.strValues[bmId];
                }
                dView.Rows.Add(bmId.ToString(), "0x" + hexValue.ToString("X8"), bmText);
                bmId--;
            }

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(this.Font, FontStyle.Bold);
            dView.Columns[0].HeaderCell.Style = style;
            dView.Columns[1].HeaderCell.Style = style;
            dView.Columns[2].HeaderCell.Style = style;

            dView.Columns[0].Width = 30;
            dView.Columns[1].Width = 100;
            dView.Columns[2].Width = dView.Width - (dView.Columns[0].Width + dView.Columns[1].Width);

            dView.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            dView.Columns[1].DefaultCellStyle.BackColor = Color.LightGray;

            dView.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dView.Columns[0].DefaultCellStyle.SelectionForeColor = Color.Black;
            dView.Columns[1].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dView.Columns[1].DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadInfo()
        {
            tBoxName.Text = m_Bitmask.dispName;

            for (int index = 1; index <= 16; index++)
            {
                if (!String.IsNullOrEmpty(m_Bitmask.strValues[index - 1]))
                {
                    dataGridView2.Rows[16 - index].Cells[2].Value = m_Bitmask.strValues[index - 1];
                }
            }

            for (int index = 1; index <= 16; index++)
            {
                if (!String.IsNullOrEmpty(m_Bitmask.strValues[index - 1]))
                {
                    dataGridView1.Rows[16 - index].Cells[2].Value = m_Bitmask.strValues[index - 1 + 16];
                }
            }
        }

        private void Save()
        {
            m_Bitmask.dispName = tBoxName.Text;

            for (int index = 1; index <= 16; index++)
            {
                String str = dataGridView2.Rows[16 - index].Cells[2].Value.ToString();
                // TODO Need to check for "spaces" here too
                if (String.IsNullOrEmpty(str))
                {
                    m_Bitmask.strValues[index - 1] = null;
                }
                else
                {
                    m_Bitmask.strValues[index - 1] = str;
                }
            }

            for (int index = 1; index <= 16; index++)
            {
                String str = dataGridView1.Rows[16 - index].Cells[2].Value.ToString();
                // TODO Need to check for "spaces" here too
                if (String.IsNullOrEmpty(str))
                {
                    m_Bitmask.strValues[index - 1 + 16] = null;
                }
                else
                {
                    m_Bitmask.strValues[index - 1 + 16] = str;
                }
            }
        }


        ////////////////////////////////////////////////////////////
        // Control event methods
        ////////////////////////////////////////////////////////////
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UserCancel.Query("Bitmask", m_Bitmask.dispName))
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }


        private void tBoxName_TextChanged(object sender, EventArgs e)
        {
            // Only resize textbox when there is some and limited amount of text
            if ((tBoxName.Text.Length > 0) && (tBoxName.Text.Length < 80))
            {
                Size size = TextRenderer.MeasureText(tBoxName.Text, tBoxName.Font);

                tBoxName.Width = size.Width + 10;
                tBoxName.Height = size.Height;
            }
        }

        private void dataGridView2_Leave(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void FormBitmaskEditor_KeyDown(object sender, KeyEventArgs e)
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