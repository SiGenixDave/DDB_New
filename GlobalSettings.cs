using System;

namespace DDB
{
    enum NameType
    {
        DISPLAY,
        ENMBEDDED
    }

    internal static class GlobalSettings
    {
        private static Boolean customerUseOnly;
        private static NameType watchVar = NameType.DISPLAY;

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

    }
}