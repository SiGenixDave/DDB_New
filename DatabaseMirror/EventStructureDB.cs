using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class EventStructureList
    {
        static List<EventStructureDB> list = new List<EventStructureDB>();

        static public void Init()
        {
            list.Add(new EventStructureDB("Event_1_Str", new List<VariableDB>() { EventVariableList.GetEventObject(5), EventVariableList.GetEventObject(6) }));
            list.Add(new EventStructureDB("Event_2_Str", new List<VariableDB>() { EventVariableList.GetEventObject(7), EventVariableList.GetEventObject(8) }));
            list.Add(new EventStructureDB("Event_3_Str", new List<VariableDB>() { EventVariableList.GetEventObject(9), EventVariableList.GetEventObject(10) }));
            list.Add(new EventStructureDB("Event_4_Str", new List<VariableDB>() { EventVariableList.GetEventObject(11) }));
        }

        static public EventStructureDB[] GetEventStructures()
        {
            return list.ToArray();
        }

        static public EventStructureDB GetEventObject(int fkey)
        {
            EventStructureDB ev = null;

            foreach (EventStructureDB e in list)
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
            foreach (EventStructureDB e in updatedList)
            {
                list.Add(e);
            }
        }

    }


    public class EventStructureDB
    {
        public Int32 fKey;
        public String name;
        public List<VariableDB> variableList;
        static Int32 key;

        public EventStructureDB(String n, List<VariableDB> l)
        {
            name = n;
            variableList = l;
            fKey = key++;
        }


        public EventStructureDB(EventStructureDB evStr) : this (evStr.name, evStr.variableList)
        {}

        public override string ToString()
        {
            return name;
        }
    }


}
