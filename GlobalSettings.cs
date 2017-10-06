using System;

namespace DDB
{
    public static class GlobalSettings
    {
        public enum NameType
        {
            DISPLAY,
            ENMBEDDED
        }
        
        private static Boolean customerUseOnly;
        private static GlobalSettings.NameType watchVar = GlobalSettings.NameType.DISPLAY;
        private static GlobalSettings.NameType eventVar = GlobalSettings.NameType.DISPLAY;
        private static GlobalSettings.NameType selfTestVar = GlobalSettings.NameType.DISPLAY;

        static public void setCustomerUseOnly(Boolean setting)
        {
            customerUseOnly = setting;
        }

        static public Boolean getCustomerUseOnly()
        {
            return customerUseOnly;
        }

        static public void setWatchDisplayType(GlobalSettings.NameType n)
        {
            watchVar = n;
        }

        static public GlobalSettings.NameType getWatchDisplayType()
        {
            return watchVar;
        }

        static public void setEventVariableDisplayType(GlobalSettings.NameType n)
        {
            eventVar = n;
        }

        static public GlobalSettings.NameType getEventVariableDisplayType()
        {
            return eventVar;
        }

        static public void setSelfTestVariableDisplayType(GlobalSettings.NameType n)
        {
            selfTestVar = n;
        }

        static public GlobalSettings.NameType getSelfTestVariableDisplayType()
        {
            return selfTestVar;
        }
    }
}