using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DDB
{
    public class EnumsBusinessLogic : iEntityEditorBusinesssLogic
    {
        FormEnumPreview enumPreview;

        public EnumsBusinessLogic(FormEnumPreview preview)
        {
            enumPreview = preview;
        }

        private EnumsBusinessLogic()
        { }

        public object Copy(object obj)
        {
            EnumsDB enm = new EnumsDB((EnumsDB)obj);
            enm.dispName = "Copy of " + enm.dispName;
            return enm;
        }

        public void Modify(object obj)
        {
            using (FormEnumsEditor emEdit = new FormEnumsEditor((EnumsDB)obj, false))
            {
                DialogResult dr = emEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    enumPreview.UpdateForm((EnumsDB)obj);
                }
            }
        }

        public void Delete(object obj)
        { }

        public object Create()
        {
            EnumsDB enm = new EnumsDB("New Enumration");

            using (FormEnumsEditor emEdit = new FormEnumsEditor(enm, true))
            {
                DialogResult dr = emEdit.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    enumPreview.UpdateForm((EnumsDB)enm);
                    return enm;
                }
            }

            return null;

        }

        public void Preview(object obj)
        {
            enumPreview.UpdateForm((EnumsDB)obj);
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