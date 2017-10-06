using System;

namespace DDB
{
    internal class UnitModifyObject : iTextEntry
    {
        ////////////////////////////////////////////////////////////
        // Attributes
        ////////////////////////////////////////////////////////////
        private const String FORM_TITLE = "Modify Unit";
        private const String FORM_MESSAGE = "Update the Unit name: click Accept or UserCancel";

        private Boolean m_UserAcceptance = false;
        private UnitsDB m_Unit;

        ////////////////////////////////////////////////////////////
        // Constructors
        ////////////////////////////////////////////////////////////
        public UnitModifyObject(UnitsDB unit)
        {
            m_Unit = unit;
            FormTextEntry formText = new FormTextEntry(FORM_TITLE, FORM_MESSAGE, unit.name, this);
            formText.ShowDialog();
        }

        private UnitModifyObject()
        { }

        ////////////////////////////////////////////////////////////
        // Public methods
        ////////////////////////////////////////////////////////////
        public Boolean GetUserAcceptance()
        {
            return m_UserAcceptance;
        }

        public UnitsDB GetUnit()
        {
            return m_Unit;
        }

        ////////////////////////////////////////////////////////////
        // Interface implementations
        ////////////////////////////////////////////////////////////
        public void ConfirmedTextEntry(string text)
        {
            m_Unit.name = text;
            m_UserAcceptance = true;
        }

    }
}