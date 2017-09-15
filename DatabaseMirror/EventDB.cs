using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class EventList
    {
        static List<EventDB> list = new List<EventDB>();

        static public void Init()
        {
            list.Add(new EventDB("Event 1", "EV_1", EventLogList.GetEventObject(0), EventStructureList.GetEventObject(0), "<b>Event 1 Description</b>"));
            list.Add(new EventDB("Event 2", "EV_2", EventLogList.GetEventObject(0), EventStructureList.GetEventObject(1), "<i>Event 2 Description</i>"));
            list.Add(new EventDB("Event 3", "EV_3", EventLogList.GetEventObject(1), EventStructureList.GetEventObject(2), "<u>Event 3 Description</u>"));
            list.Add(new EventDB("Event 4", "EV_4", EventLogList.GetEventObject(1), EventStructureList.GetEventObject(3), "<em>Event 4 Description</em>"));
        }

        static public EventDB[] GetEvents()
        {
            return list.ToArray();
        }

        static public void Update(object[] updatedList)
        {
            list.Clear();
            foreach (EventDB e in updatedList)
            {
                list.Add(e);
            }
        }

    }


    public class EventDB: iDDBHelpObject
    {
        public String name;
        public String embeddedName;
        public EventLogDB eventLogDB;
        public EventStructureDB eventStructureDB;
        public String helpText;
        public Int32 fKey;
        static Int32 key;

        public EventDB(String n, String c, EventLogDB l, EventStructureDB s, String h)
        {
            name = n;
            embeddedName = c;
            eventLogDB = l;
            eventStructureDB = s;
            helpText = h;
            fKey = key++;
        }

        public EventDB(EventDB ev)
            : this(ev.name, ev.embeddedName, ev.eventLogDB, ev.eventStructureDB, ev.helpText)
        {}

        private EventDB()
        {}

        public void SaveHelpText(String helpText)
        {
            this.helpText = helpText;
        }

        public String GetHelpText()
        {
            return helpText;
        }

        public override string ToString()
        {
            return name;
        }
     }


}
