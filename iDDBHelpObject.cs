using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    public interface iDDBHelpObject
    {
        void SaveHelpText(String helpText);
        String GetHelpText();
    }
}
