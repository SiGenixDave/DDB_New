using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class EventStructureList
    {
        static List<EventStructureDB> evList = new List<EventStructureDB>();

        static public void Init()
        {
            evList.Add(new EventStructureDB("Event_1_Str", new List<EventVariableDB>() { EventVariableList.GetEventObject(0), EventVariableList.GetEventObject(1) }));
            evList.Add(new EventStructureDB("Event_2_Str", new List<EventVariableDB>() { EventVariableList.GetEventObject(4), EventVariableList.GetEventObject(5) }));
            evList.Add(new EventStructureDB("Event_3_Str", new List<EventVariableDB>() { EventVariableList.GetEventObject(8), EventVariableList.GetEventObject(18) }));
            evList.Add(new EventStructureDB("Event_4_Str", new List<EventVariableDB>() { EventVariableList.GetEventObject(9) }));
        }

        static public EventStructureDB[] GetEventStructures()
        {
            return evList.ToArray();
        }

        static public EventStructureDB GetEventObject(int fkey)
        {
            EventStructureDB ev = null;

            foreach (EventStructureDB e in evList)
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
            evList.Clear();
            foreach (EventStructureDB e in updatedList)
            {
                evList.Add(e);
            }
        }

    }


    public class EventStructureDB
    {
        public Int32 fKey;
        public String name;
        public List<EventVariableDB> variableList;
        static Int32 key;

        public EventStructureDB(String n, List<EventVariableDB> l)
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
