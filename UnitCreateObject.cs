using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    class UnitCreateObject: iTextEntry
    {
        const String formTitle = "Create Unit";
        const String formMessage = "Create the new Unit name: click Accept or Cancel";

        Boolean userAcceptance = false;
        String unit;

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
