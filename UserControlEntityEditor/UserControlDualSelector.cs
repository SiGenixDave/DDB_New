using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDB
{
    public partial class UserControlDualSelector : UserControl
    {
        private UserControlDualSelector otherSelector = null;
        private List<object> allEntities = new List<object>(); 
        private iDualSelectorSupport dualSelectorSupport = null;

        public UserControlDualSelector()
        {
            InitializeComponent();
        }

        public object[] GetItems()
        {
            return allEntities.ToArray();
        }

        public object[] GetReorderItems()
        {
            List<object> listBoxObjects = new List<object>();
            foreach (object obj in listBox.Items)
            {
                listBoxObjects.Add(obj);
            }
            return listBoxObjects.ToArray();
        }

        public void SetOtherSelector(UserControlDualSelector other)
        {
            otherSelector = other;
        }

        public void SetDualSelectorSupport(iDualSelectorSupport support)
        {
            dualSelectorSupport = support;
        }

        ///////////////////////////////////////////////////////////////////////////////////////

        // Properties
        public String xGroupBoxTitle
        {
            set { groupBox.Text = value; }
            get { return groupBox.Text; }
        }

        bool _btnMoveUpVisible = true;
        [DefaultValue(true)]
        public bool xVisibleMoveUpButton
        {
            get
            {
                return _btnMoveUpVisible;
            }
            set
            {
                _btnMoveUpVisible = value;
                btnMoveUp.Visible = value;
            }
        }

        bool _btnMoveDownVisible = true;
        [DefaultValue(true)]
        public bool xVisibleMoveDownButton
        {
            get
            {
                return _btnMoveDownVisible;
            }
            set
            {
                _btnMoveDownVisible = value;
                btnMoveDown.Visible = value;
            }
        }

        bool _txtFilterVisible = true;
        [DefaultValue(true)]
        public bool xFilterVisible
        {
            set
            {
                lblFilter.Visible = value;
                txtBoxFilter.Visible = value;
                _txtFilterVisible = value;
            }
            get { return _txtFilterVisible; }
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        // This allows user to add items
        public void AddListBoxItem(object item)
        {
            listBox.Items.Add(item);
            allEntities.Add(item);
        }

        public void AddListBoxItems(object []items)
        {
            listBox.Items.AddRange(items);
            allEntities.AddRange(items);
        }


        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
            if (dualSelectorSupport != null)
            {
                dualSelectorSupport.MoveUp(listBox.SelectedItem);
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
            if (dualSelectorSupport != null)
            {
                dualSelectorSupport.MoveDown(listBox.SelectedItem);
            }
        }


        public void MoveItem(int direction)
        {
            // Checking selected item
            //if (lBoxUsedVars.SelectedItem == null || lBoxUsedVars.SelectedIndex < 0)
            //    return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox.SelectedItem;

            // Removing removable element
            listBox.Items.Remove(selected);
            // Insert it in new position
            listBox.Items.Insert(newIndex, selected);
            // Restore selection
            listBox.SetSelected(newIndex, true);
        }


        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            MoveItemsToOtherSelector();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndices.Count == 0)
            {
                contextMenuStrip.Items["moveSelectedToolStripMenuItem"].Enabled = false;
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;
            }
            else if (listBox.SelectedIndices.Count == 1)
            {
                contextMenuStrip.Items["moveSelectedToolStripMenuItem"].Enabled = true;
                if (listBox.SelectedIndex == 0)
                {
                    btnMoveUp.Enabled = false;
                    btnMoveDown.Enabled = true;
                }
                else if (listBox.SelectedIndex == listBox.Items.Count - 1)
                {
                    btnMoveUp.Enabled = true;
                    btnMoveDown.Enabled = false;
                }
                else
                {
                    btnMoveUp.Enabled = true;
                    btnMoveDown.Enabled = true;
                }
            }
            else
            {
                contextMenuStrip.Items["moveSelectedToolStripMenuItem"].Enabled = true;
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;
            }
        }

        private void groupBox_Leave(object sender, EventArgs e)
        {
            listBox.SelectedIndex = -1;
        }


        ///////////////////////////////////////////////////////////////////////////
        // Context Menu tool strip
        private void moveSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveItemsToOtherSelector();
        }



        private enum UCSort
        {
            UNSORTED,
            SORT_ASC,
            SORT_DES
        }
        private UCSort currentSort = UCSort.UNSORTED;
        private void sortAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object selItem = listBox.SelectedItem;

            listBox.Sorted = true;
            labelSortOrder.Text = "\u2B63";

            listBox.SelectedItem = selItem;

            currentSort = UCSort.SORT_ASC;
        }

        private void sortDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object selItem = listBox.SelectedItem;

            List<object> reverseSort = new List<object>();
            listBox.Sorted = true;
            foreach (object obj in listBox.Items)
            {
                reverseSort.Add(obj);
            }
            reverseSort.Reverse();

            listBox.Sorted = false;
            listBox.Items.Clear();
            listBox.Items.AddRange(reverseSort.ToArray());

            labelSortOrder.Text = "\u2B61";

            listBox.SelectedItem = selItem;

            currentSort = UCSort.SORT_DES;

        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(allEntities.ToArray());

            labelSortOrder.Text = "";

            txtBoxFilter.Text = "";
            txtBoxFilter.Enabled = true;

            currentSort = UCSort.UNSORTED;
        }


        /////////////////////////////////////////////////////////////////////////////////////////
        // Methods
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (!xFilterVisible)
            {
                contextMenuStrip.Items["sortAscendingToolStripMenuItem"].Visible = false;
                contextMenuStrip.Items["sortDescendingToolStripMenuItem"].Visible = false;
                contextMenuStrip.Items["unsortToolStripMenuItem"].Visible = false;
            }

            if (otherSelector == null)
            {
                contextMenuStrip.Items["moveSelectedToolStripMenuItem"].Visible = false;
                contextMenuStrip.Items["toolStripSeparator3"].Visible = false;
            }
        
        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            if (txtBoxFilter.Text == "")
            {
                listBox.Items.AddRange(allEntities.ToArray());
            }
            else
            {
                List<object> filteredList = new List<object>();

                foreach (object obj in allEntities)
                {
                    if (obj.ToString().Contains(txtBoxFilter.Text))
                    {
                        filteredList.Add(obj);
                    }
                }

                if (filteredList.Count != 0)
                {
                    listBox.Items.AddRange(filteredList.ToArray());
                }
            }

            if (currentSort == UCSort.SORT_DES)
            {
                sortDescendingToolStripMenuItem_Click(null, null);
            }
        }


        private void MoveItemsToOtherSelector()
        {
            // Support the user control when it doesn't have a partner
            if (otherSelector != null)
            {
                int index = 0;
                List<object> selIndices = new List<object>();
                while (index < listBox.SelectedIndices.Count)
                {
                    otherSelector.AddListBoxItem(listBox.Items[listBox.SelectedIndices[index]]);
                    selIndices.Add(listBox.Items[listBox.SelectedIndices[index]]);
                    index++;
                }
                index = 0;
                while (index < selIndices.Count)
                {
                    listBox.Items.Remove(selIndices[index]);
                    index++;
                }
            }
        }

    }

    public interface iDualSelectorSupport
    {
        void MoveUp(object obj);
        void MoveDown(object obj);
    }

}
