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
            Bitmask bt = new Bitmask((Bitmask)obj);
            bt.dispName = "Copy of " + bt.dispName;
            return bt;
        }

        public void Modify(object obj)
        {
            using (FormBitmaskEditor bmEdit = new FormBitmaskEditor((Bitmask)obj, false))
            {
                DialogResult dr = bmEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    bmPreview.UpdateForm((Bitmask)obj);
                }
            }
        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            Bitmask bmt = BitmaskList.CreateVar("New Bitmask");

            using (FormBitmaskEditor bmEdit = new FormBitmaskEditor(bmt, true))
            {
                DialogResult dr = bmEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    bmPreview.UpdateForm((Bitmask)bmt);
                    return bmt;
                }
            }

            return null;
        }

        public void Links()
        { }
        public void Import()
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