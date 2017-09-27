using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class EventVariableList
    {
        static List<VariableDB> list = new List<VariableDB>();

        static public void Init()
        {
            list.Add(new VariableDB("Var 00", "evVar00", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 00 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 01", "evVar01", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 01 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 02", "evVar02", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 02 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 03", "evVar03", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 03 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 04", "evVar04", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 04 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 05", "evVar05", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 05 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 06", "evVar06", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 06 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 07", "evVar07", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 07 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 08", "evVar08", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 08 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 09", "evVar09", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 09 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 10", "evVar10", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 10 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 11", "evVar11", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 11 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 12", "evVar12", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 12 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 13", "evVar13", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 13 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 14", "evVar14", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 14 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 15", "evVar15", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 15 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 16", "evVar16", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 16 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 17", "evVar17", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 17 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 18", "evVar18", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 18 Description</b>", GlobalSettings.getEventVariableDisplayType));
            list.Add(new VariableDB("Var 19", "evVar19", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Event Var 19 Description</b>", GlobalSettings.getEventVariableDisplayType));
        }

        static public VariableDB[] GetEventVariables()
        {
            return list.ToArray();
        }

        static public VariableDB GetEventObject(int fkey)
        {
            VariableDB ev = null;

            foreach (VariableDB e in list)
            {
                if (e.fKey == fkey)
                {
                    ev = e;
                    break;
                }
            }

            return ev;
        }

        static public void Update(object[] updatedList)
        {
            list.Clear();
            foreach (VariableDB e in updatedList)
            {
                list.Add(e);
            }

        }

    }

}
