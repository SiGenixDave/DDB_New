using System;

namespace DDB
{
    internal class UnitModifyObject : iTextEntry
    {
        private const String formTitle = "Modify Unit";
        private const String formMessage = "Update the Unit name: click Accept or Cancel";

        private Boolean userAcceptance = false;
        private String unit;

        public UnitModifyObject(String unitName)
        {
            FormTextEntry formText = new FormTextEntry(formTitle, formMessage, unitName, this);
            formText.ShowDialog();
        }

        private UnitModifyObject()
        { }

        public void ConfirmedTextEntry(string text)
        {
            unit = text;
            userAcceptance = true;
        }

        public Boolean GetUserAcceptance()
        {
            return userAcceptance;
        }

        public String GetUnit()
        {
            return unit;
        }
    }
}