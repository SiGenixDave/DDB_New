using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    class UnitModifyObject: iTextEntry
    {
        const String formTitle = "Modify Unit";
        const String formMessage = "Update the Unit name: click Accept or Cancel";

        Boolean userAcceptance = false;
        String unit;

        public UnitModifyObject(String unitName)
        {
            FormTextEntry formText = new FormTextEntry(formTitle, formMessage, unitName, this);
            formText.ShowDialog();
        }

        private UnitModifyObject()
        {}

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
