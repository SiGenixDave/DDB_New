using System;

namespace DDB
{
    public enum NameType
    {
        DISPLAY,
        ENMBEDDED
    }

    internal static class GlobalSettings
    {
        private static Boolean customerUseOnly;
        private static NameType watchVar = NameType.DISPLAY;
        private static NameType eventVar = NameType.DISPLAY;
        private static NameType selfTestVar = NameType.DISPLAY;

        static public void setCustomerUseOnly(Boolean setting)
        {
            customerUseOnly = setting;
        }

        static public Boolean getCustomerUseOnly()
        {
            return customerUseOnly;
        }

        static public void setWatchDisplayType(NameType n)
        {
            watchVar = n;
        }

        static public NameType getWatchDisplayType()
        {
            return watchVar;
        }

        static public void setEventVariableDisplayType(NameType n)
        {
            eventVar = n;
        }

        static public NameType getEventVariableDisplayType()
        {
            return eventVar;
        }

        static public void setSelfTestVariableDisplayType(NameType n)
        {
            selfTestVar = n;
        }

        static public NameType getSelfTestVariableDisplayType()
        {
            return selfTestVar;
        }


    }
}