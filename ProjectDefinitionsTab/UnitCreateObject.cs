using System;

namespace DDB
{
    internal class UnitCreateObject : iTextEntry
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private const String FORM_TITLE = "Create Unit";
        private const String FORM_MESSAGE = "Create the new Unit name: click Accept or Cancel";

        private Boolean m_UserAcceptance = false;
        private String m_UnitText;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public UnitCreateObject()
        {
            FormTextEntry formText = new FormTextEntry(FORM_TITLE, FORM_MESSAGE, this);
            formText.ShowDialog();
        }

        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////
        public Boolean GetUserAcceptance()
        {
            return m_UserAcceptance;
        }

        public UnitsDB GetUnit()
        {
            return new UnitsDB(m_UnitText, true);
        }

        ////////////////////////////////////////////////////////////
        // Interface implementations
        ////////////////////////////////////////////////////////////
        public void ConfirmedTextEntry(string text)
        {
            m_UnitText = text;
            m_UserAcceptance = true;
        }

    }
}