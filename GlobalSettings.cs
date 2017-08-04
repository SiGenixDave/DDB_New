using System;

namespace DDB
{
    internal static class GlobalSettings
    {
        private static Boolean customerUseOnly;

        static public void setCustomerUseOnly(Boolean setting)
        {
            customerUseOnly = setting;
        }

        static public Boolean getCustomerUseOnly()
        {
            return customerUseOnly;
        }
    }
}