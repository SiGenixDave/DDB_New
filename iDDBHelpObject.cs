using System;

namespace DDB
{
    public interface iDDBHelpObject
    {
        void SaveHelpText(String helpText);

        String GetHelpText();
    }
}