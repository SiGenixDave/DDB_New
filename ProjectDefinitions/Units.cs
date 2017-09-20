using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DDB
{

    public class UnitsBusinessLogic : iEntityEditorBusinesssLogic
    {
        public object Copy(object obj)
        {
            UnitsDB u = (UnitsDB)obj;
            UnitsDB myNewUnit = new UnitsDB("Copy of " + u.name, true);
            return myNewUnit;
        }

        public void Modify(object obj)
        {
            UnitModifyObject unitModify = new UnitModifyObject((UnitsDB)obj);
            if (unitModify.GetUserAcceptance())
            {
                obj = unitModify;
            }
        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public object Create()
        {
            UnitCreateObject unitCreate = new UnitCreateObject();
            if (unitCreate.GetUserAcceptance())
            {
                UnitsDB u = unitCreate.GetUnit();
                return u;
            }

            return null;
        }

        public void Links()
        { }
        public void Import()
        { }

        public void Preview(object obj)
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

        private void btnProjUnitsImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("UnitsDB");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with vList box of units from the XML file
        }

        private void gBoxProjUnits_Enter(object sender, EventArgs e)
        {
            formEnumPreview.UpdateForm(null);
            formBitmaskPreview.UpdateForm(null);
        }

    }
}