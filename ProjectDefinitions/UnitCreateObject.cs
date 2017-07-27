using System;

namespace DDB
{
    internal class UnitCreateObject : iTextEntry
    {
        private const String formTitle = "Create Unit";
        private const String formMessage = "Create the new Unit name: click Accept or Cancel";

        private Boolean userAcceptance = false;
        private String unit;

        public void ConfirmedTextEntry(string text)
        {
            unit = text;
            userAcceptance = true;
        }

        public UnitCreateObject()
        {
            FormTextEntry formText = new FormTextEntry(formTitle, formMessage, this);
            formText.ShowDialog();
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