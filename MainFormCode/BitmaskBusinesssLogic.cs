using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDB
{
    public class BitmaskBusinesssLogic : iEntityEditorBusinesssLogic
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        FormBitmaskPreview m_FormBitmaskPreview;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public BitmaskBusinesssLogic(FormBitmaskPreview preview)
        {
            m_FormBitmaskPreview = preview;
        }

        private BitmaskBusinesssLogic()
        { }

        ////////////////////////////////////////////////////////////
        // Interface Implementations
        ////////////////////////////////////////////////////////////
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
                    m_FormBitmaskPreview.UpdateForm((BitmaskDB)obj);
                }
            }
        }

        public void Delete(object obj)
        {}

        public object Create()
        {
            BitmaskDB bmt = new BitmaskDB("New BitmaskDB");

            using (FormBitmaskEditor bmEdit = new FormBitmaskEditor(bmt, true))
            {
                DialogResult dr = bmEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    m_FormBitmaskPreview.UpdateForm((BitmaskDB)bmt);
                    return bmt;
                }
            }

            return null;
        }

        public void Preview(object obj)
        {
            m_FormBitmaskPreview.UpdateForm((BitmaskDB)obj);
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

}