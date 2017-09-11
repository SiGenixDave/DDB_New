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
    public partial class UserControlEntityEditor : UserControl
    {
        private iEntityEditorBusinesssLogic businessLogic;
        private List<object> allEntities = new List<object>(); 

        public UserControlEntityEditor()
        {
            InitializeComponent();
        }

        public void setBusinessLogic (iEntityEditorBusinesssLogic iBusinessLogic)
        {
            businessLogic = iBusinessLogic;
        }

        public object[] GetItems()
        {
            return allEntities.ToArray();
        }

        ///////////////////////////////////////////////////////////////////////////////////////


        // Properties
        public String xGroupBoxTitle
        {
            set { groupBox.Text = value; }
            get { return groupBox.Text; }
        }

        public Boolean xVisibleImportButton
        {
            set { btnImport.Visible = value; }
            get { return btnImport.Visible; }
        }

        public Boolean xVisibleLinksButton
        {
            set { 
                btnLinks.Visible = value; 
            }
            get { return btnLinks.Visible; }
        }

        public Boolean xVisibleModifyHelpTextButton
        {
            set { 
                btnModifyHelpText.Visible = value; 
            }
            get { return btnModifyHelpText.Visible; }
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


        ///////////////////////////////////////////////////////////////////////////////////////
        // Auto generated Events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateItem();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyItem();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnLinks_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyHelpText_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterApply_Click(object sender, EventArgs e)
        {
            List<object> filteredList = new List<object>();

            foreach (object obj in listBox.Items)
            {
                if (obj.ToString().Contains(txtBoxFilter.Text))
                {
                    filteredList.Add(obj);
                }
            }

            if (filteredList.Count != 0)
            {
                listBox.Items.Clear();
                listBox.Items.AddRange(filteredList.ToArray());
                btnFilterApply.Enabled = false;
                btnFilterClear.Enabled = true;
                txtBoxFilter.Enabled = false;
            }
            else
            {
                MessageBox.Show("No items available");
            }


        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(allEntities.ToArray());
            btnFilterApply.Enabled = true;
            btnFilterClear.Enabled = false;
            txtBoxFilter.Text = "";
            txtBoxFilter.Enabled = true;

        }


        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            ModifyItem();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndices.Count == 0)
            {
                contextMenuStrip.Items["modifyToolStripMenuItem"].Enabled = false;
                contextMenuStrip.Items["modifyHelpTextToolStripMenuItem"].Enabled = false;

                btnModify.Enabled = false;
                btnCopy.Enabled = false;
                btnDelete.Enabled = false;
                btnLinks.Enabled = false;
                btnModifyHelpText.Enabled = false;

                businessLogic.Preview(null);

            }
            else if (listBox.SelectedIndices.Count == 1)
            {
                contextMenuStrip.Items["modifyToolStripMenuItem"].Enabled = true;
                contextMenuStrip.Items["modifyHelpTextToolStripMenuItem"].Enabled = true;

                btnModify.Enabled = true;
                btnCopy.Enabled = true;
                btnDelete.Enabled = true;
                btnLinks.Enabled = true;
                btnModifyHelpText.Enabled = true;

                businessLogic.Preview(listBox.SelectedItem);
            }
            else
            {
                // Disable the "Modify" in context menu
                contextMenuStrip.Items["modifyToolStripMenuItem"].Enabled = false;
                contextMenuStrip.Items["modifyHelpTextToolStripMenuItem"].Enabled = false;

                btnModify.Enabled = false;
                btnCopy.Enabled = true;
                btnDelete.Enabled = true;
                btnLinks.Enabled = true;
                btnModifyHelpText.Enabled = false;

                businessLogic.Preview(null);

            }
        }
        

        private void groupBox_Leave(object sender, EventArgs e)
        {
            listBox.SelectedIndex = -1;
        }


        ///////////////////////////////////////////////////////////////////////////
        // Context Menu tool strip

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateItem();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyItem();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyItem();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void sortAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox.Sorted = true;
            labelSortOrder.Text = "\u2B63";
        }

        private void sortDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(allEntities.ToArray());

            labelSortOrder.Text = "";

            btnFilterClear.Enabled = false;
            btnFilterApply.Enabled = true;
            txtBoxFilter.Text = "";
            txtBoxFilter.Enabled = true;
        }



        /////////////////////////////////////////////////////////////////////////////////////////
        // Methods

        void CreateItem()
        {
            object objNew = businessLogic.Create();
            if (objNew != null)
            {
                listBox.Items.Add(objNew);
                allEntities.Add(objNew);
            }
        }

        void CopyItem()
        {
            int indexCount = 0;
            while (indexCount < listBox.SelectedIndices.Count)
            {
                object objNew = businessLogic.Copy(listBox.SelectedItems[indexCount]);
                if (objNew != null)
                {
                    listBox.Items.Add(objNew);
                    allEntities.Add(objNew);
                }
                indexCount++;
            }
        }

        void ModifyItem()
        {
            businessLogic.Modify(listBox.SelectedItem);
            // Need this to update in case the string was changed by the call to Modify()
            listBox.Items[listBox.SelectedIndex] = listBox.Items[listBox.SelectedIndex];
        }

        void DeleteItem()
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete the selected items(s)?",
                                  "Delete Items(s) Confirmation",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning);

            // User really didn't want to delete the variables... abort delete
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            int prevSelected = listBox.SelectedIndices[0];

            int indexCount = 0;
            List<object> itemsToDelete = new List<object>();
            while (indexCount < listBox.SelectedIndices.Count)
            {
                itemsToDelete.Add(listBox.SelectedItems[indexCount]);
                indexCount++;
            }

            while (itemsToDelete.Count != 0)
            {
                businessLogic.Delete(itemsToDelete[0]);
                allEntities.Remove(itemsToDelete[0]);
                listBox.Items.Remove(itemsToDelete[0]);
                itemsToDelete.RemoveAt(0);
            }

            if (prevSelected >= listBox.Items.Count)
            {
                listBox.SelectedIndex = listBox.Items.Count - 1;
            }
            else
            {
                listBox.SelectedIndex = prevSelected;
            }

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (!xVisibleLinksButton)
            {
                contextMenuStrip.Items["linksToolStripMenuItem"].Visible = false;
            }
            if (!xVisibleModifyHelpTextButton)
            {
                contextMenuStrip.Items["modifyHelpTextToolStripMenuItem"].Visible = false;
            }  
        }

    }




    public interface iEntityEditorBusinesssLogic
    {
        object Copy(object obj);
        void Modify(object obj);
        void Delete(object obj);
        object Create();
        void Preview(object obj);
        void Links();
        void Import();
    }

}
