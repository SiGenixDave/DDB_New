using System;

namespace DDB
{
    internal class UnitModifyObject : iTextEntry
    {
        private const String formTitle = "Modify Unit";
        private const String formMessage = "Update the Unit name: click Accept or Cancel";

        private Boolean userAcceptance = false;
        private UnitsTest myUnit;

        public UnitModifyObject(UnitsTest unit)
        {
            myUnit = unit;
            FormTextEntry formText = new FormTextEntry(formTitle, formMessage, unit.name, this);
            formText.ShowDialog();
        }

        private UnitModifyObject()
        { }

        public void ConfirmedTextEntry(string text)
        {
            myUnit.name = text;
            userAcceptance = true;
        }

        public Boolean GetUserAcceptance()
        {
            return userAcceptance;
        }

        public UnitsTest GetUnit()
        {
            return myUnit;
        }
    }
}