using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class EventLogList
    {
        static List<EventLogDB> list = new List<EventLogDB>();

        static public void Init()
        {
            list.Add(new EventLogDB("Propulsion", 0));
            list.Add(new EventLogDB("Engineering", 1));
        }

        static public EventLogDB[] GetEventLogs()
        {
            return list.ToArray();
        }

        static public EventLogDB GetEventObject(int fkey)
        {
            EventLogDB ev = null;

            foreach (EventLogDB e in list)
            {
                if (e.fKey == fkey)
                {
                    ev = e;
                    break;
                }
            }

            return ev;
        }

        static public void Update(EventLogDB[] updatedList)
        {
            list.Clear();
            list.AddRange(updatedList);
        }


    }


    public class EventLogDB
    {
        public String name;
        public Int32 embeddedId;
        public Int32 fKey;
        static public Int32 key;

        public EventLogDB(String n, Int32 e)
        {
            name = n;
            embeddedId = e; 
            fKey = key++;
        }

        public EventLogDB(EventLogDB ev): this(ev.name, ev.embeddedId)
        {}

        private EventLogDB()
        {}

        public override string ToString()
        {
            return name;
        }
     }


}
