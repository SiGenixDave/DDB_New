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

            // set default values
            xVisibleCreateButton = true;
            xVisibleCopyButton = true;
            xVisibleModifyButton = true;
            xVisibleDeleteButton = true;
            xVisibleImportButton = true;
            xVisibleLinksButton = true;
            xVisibleModifyHelpTextButton = true;
            xVisibleDispEmbComboBox = false;

            cBoxDispEmb.SelectedIndex = 0;
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        // Properties
        public String xGroupBoxTitle
        {
            set { groupBox.Text = value; }
            get { return groupBox.Text; }
        }

        bool _btnCreateVisible = true;
        [DefaultValue(true)]
        public bool xVisibleCreateButton
        {
            get
            {
                return _btnCreateVisible;
            }
            set
            {
                _btnCreateVisible = value;
                btnCreate.Visible = value;
            }
        }

        bool _btnCopyVisible = true;
        [DefaultValue(true)]
        public bool xVisibleCopyButton
        {
            get
            {
                return _btnCopyVisible;
            }
            set
            {
                _btnCopyVisible = value;
                btnCopy.Visible = value;
            }
        }


        bool _btnModifyVisible = true;
        [DefaultValue(true)]
        public bool xVisibleModifyButton
        {
            get
            {
                return _btnModifyVisible;
            }
            set
            {
                _btnModifyVisible = value;
                btnModify.Visible = value;
            }
        }

        bool _btnDeleteVisible = true;
        [DefaultValue(true)]
        public bool xVisibleDeleteButton
        {
            get
            {
                return _btnDeleteVisible;
            }
            set
            {
                _btnDeleteVisible = value;
                btnDelete.Visible = value;
            }
        }

        bool _btnImportVisible = true;
        [DefaultValue(true)]
        public bool xVisibleImportButton
        {
            get
            {
                return _btnImportVisible;
            }
            set
            {
                _btnImportVisible = value;
                btnImport.Visible = value;
            }
        }


        bool _btnLinksVisible = true;
        [DefaultValue(true)]
        public bool xVisibleLinksButton
        {
            get
            {
                return _btnLinksVisible;
            }
            set
            {
                _btnLinksVisible = value;
                btnLinks.Visible = value;
            }
        }


        bool _btnModifyHelpTextVisible = true;
        [DefaultValue(true)]
        public bool xVisibleModifyHelpTextButton
        {
            get
            {
                return _btnModifyHelpTextVisible;
            }
            set
            {
                _btnModifyHelpTextVisible = value;
                btnModifyHelpText.Visible = value;
            }
        }

        bool _cBoxDispEmbVisible = false;
        [DefaultValue(false)]
        public bool xVisibleDispEmbComboBox
        {
            get
            {
                return _cBoxDispEmbVisible;
            }
            set
            {
                _cBoxDispEmbVisible = value;
                cBoxDispEmb.Visible = value;
            }
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

        public void setBusinessLogic(iEntityEditorBusinesssLogic iBusinessLogic)
        {
            businessLogic = iBusinessLogic;
        }

        public object[] GetItems()
        {
            return allEntities.ToArray();
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        // Auto generated EventDB
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
            MessageBox.Show("Not Yet Implemented"); 
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented"); 
        }


        private void btnModifyHelpText_Click(object sender, EventArgs e)
        {
            businessLogic.HelpModify(listBox.SelectedItem);
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
                businessLogic.HelpPreview(listBox.SelectedItem);
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

        private void modifyHelpTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            businessLogic.HelpModify(listBox.SelectedItem);
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

        private void CreateItem()
        {
            object objNew = businessLogic.Create();
            if (objNew != null)
            {
                listBox.Items.Add(objNew);
                allEntities.Add(objNew);
            }
        }

        private void CopyItem()
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

        private void ModifyItem()
        {
            businessLogic.Modify(listBox.SelectedItem);
            // Need this to update in case the string was changed by the call to Modify()
            listBox.Items[listBox.SelectedIndex] = listBox.Items[listBox.SelectedIndex];
        }

        private void DeleteItem()
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
                contextMenuStrip.Items["toolStripSeparatorAboveLinks"].Visible = false;
            }
            if (!xVisibleModifyHelpTextButton)
            {
                contextMenuStrip.Items["toolStripSeparatorAboveHelp"].Visible = false;
                contextMenuStrip.Items["modifyHelpTextToolStripMenuItem"].Visible = false;
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

        private void cBoxDispEmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (businessLogic != null)
            {
                businessLogic.ChangeDisplayName(cBoxDispEmb.SelectedIndex);
                RefreshListbox();
            }
        }

        private void RefreshListbox()
        {
            String filterValue = txtBoxFilter.Text;
            txtBoxFilter.Text = "";
            listBox.Items.Clear();

            foreach (object obj in allEntities)
            {
                listBox.Items.Add(obj);
            }

            txtBoxFilter.Text = filterValue;

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
        void ChangeDisplayName(int nameId);
        void HelpModify(object obj);
        void HelpPreview(object obj);
    }

}
