using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DDB
{

    public class UnitsBusinessLogic : iEntityEditorBusinesssLogic
    {
        public object Copy(object obj)
        {
            Units u = (Units)obj;
            Units myNewUnit = new Units("Copy of " + u.name, true);
            return myNewUnit;
        }

        public void Modify(object obj)
        {
            UnitModifyObject unitModify = new UnitModifyObject((Units)obj);
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
                Units u = unitCreate.GetUnit();
                return u;
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

        private void btnProjUnitsImport_Click(object sender, EventArgs e)
        {
            FormImport iForm = new FormImport("Units");
            iForm.ShowDialog();
            //TODO Open File dialog (xml file default)

            //TODO Open new form with list box of units from the XML file
        }

        private void gBoxProjUnits_Enter(object sender, EventArgs e)
        {
            formEnumPreview.UpdateForm(null);
            formBitmaskPreview.UpdateForm(null);
        }

    }
}