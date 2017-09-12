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
            evList.Add(new EventStructureDB("Event_1_Str", new List<int>() { 0, 1, 2, 3 }));
            evList.Add(new EventStructureDB("Event_2_Str", new List<int>() { 4, 5 }));
            evList.Add(new EventStructureDB("Event_3_Str", new List<int>() { 6, 7, 8, 9, 10, 11, 12, 13 }));
            evList.Add(new EventStructureDB("Event_4_Str", new List<int>() { 14, 15, 16, 17, 18, 19 }));
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
        public List<Int32> variableListFKey;
        static Int32 key;

        public EventStructureDB(String n, List<Int32> l)
        {
            name = n;
            variableListFKey = l;
            fKey = key++;
        }


        public EventStructureDB(EventStructureDB evStr) : this (evStr.name, evStr.variableListFKey)
        {}

        public override string ToString()
        {
            return name;
        }
    }


}
