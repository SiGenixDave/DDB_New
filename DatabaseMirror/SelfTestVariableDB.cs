using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class SelfTestVariableList
    {
        static List<VariableDB> list = new List<VariableDB>();

        static public void Init()
        {
            list.Add(new VariableDB("Var 00", "stVar00", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 00 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 01", "stVar01", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 01 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 02", "stVar02", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 02 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 03", "stVar03", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 03 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 04", "stVar04", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 04 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 05", "stVar05", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 05 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 06", "stVar06", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 06 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 07", "stVar07", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 07 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 08", "stVar08", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 08 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
            list.Add(new VariableDB("Var 09", "stVar09", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Self Test Var 09 Description</b>", GlobalSettings.getSelfTestVariableDisplayType));
        }

        static public VariableDB[] GetSelfTestVariables()
        {
            return list.ToArray();
        }

        static public VariableDB GetObject(int fkey)
        {
            VariableDB var = null;

            foreach (VariableDB v in list)
            {
                if (v.fKey == fkey)
                {
                    var = v;
                    break;
                }
            }

            return var;
        }

        static public void Update(object[] updatedList)
        {
            list.Clear();
            foreach (VariableDB v in updatedList)
            {
                list.Add(v);
            }

        }

    }
}
