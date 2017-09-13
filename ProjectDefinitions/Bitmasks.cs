using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{

    public class BitmasksBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormBitmaskPreview bmPreview;

        public BitmasksBusinessLogic(FormBitmaskPreview preview)
        {
            bmPreview = preview;
        }

        private BitmasksBusinessLogic()
        { }

        public object Copy(object obj)
        {
            BitmaskDB bt = new BitmaskDB((BitmaskDB)obj);
            bt.dispName = "Copy of " + bt.dispName;
            return bt;
        }

        public void Modify(object obj)
        {
            using (FormBitmaskEditor bmEdit = new FormBitmaskEditor((BitmaskDB)obj, false))
            {
                DialogResult dr = bmEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    bmPreview.UpdateForm((BitmaskDB)obj);
                }
            }
        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            BitmaskDB bmt = new BitmaskDB ("New BitmaskDB");

            using (FormBitmaskEditor bmEdit = new FormBitmaskEditor(bmt, true))
            {
                DialogResult dr = bmEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    bmPreview.UpdateForm((BitmaskDB)bmt);
                    return bmt;
                }
            }

            return null;
        }

        public void Preview(object obj)
        {
            bmPreview.UpdateForm((BitmaskDB)obj);
        }

        public void Links()
        { }
        public void Import()
        { }
        public void HelpModify(object obj)
        { }
        public void HelpPreview(object obj)
        { }

        public void ChangeDisplayName(int name)
        { }
    }



    public partial class FormMain
    {
        

        private void btnProBitmasksImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Bitmasks");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        
        private int savedBitmaskIndex = 0;
        private void gBoxProjBitmask_Enter(object sender, EventArgs e)
        {
            //TODO formEnumPreview.UpdateForm(null);
        }

    }
}