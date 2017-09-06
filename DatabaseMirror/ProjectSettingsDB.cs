using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    class ProjectSettingsDB
    {
        static List<URLTarget> urlList = new List<URLTarget>();
        static List<EventLog> eventLogList = new List<EventLog>();
        static int functionFlags = 0x11;

        static public void Init()
        {

            urlList.Add(new URLTarget("url1.com", "myAliasURL1.com"));
            urlList.Add(new URLTarget("url2.com", "myAliasURL2.com"));
            urlList.Add(new URLTarget("url3.com", "myAliasURL3.com"));
            urlList.Add(new URLTarget("url4.com", "myAliasURL4.com"));

            eventLogList.Add(new EventLog(0, "Propulsion"));
            eventLogList.Add(new EventLog(1, "Engineering"));

        }

        static public void AddURL (URLTarget urlTest)
        {
            urlList.Add(urlTest);
        }

        static public void DeleteURL (URLTarget urlTest)
        {
            urlList.Remove(urlTest);
        }

        static public URLTarget[] GetURLs()
        {
            return urlList.ToArray();
        }

        static public URLTarget GetURL(int index)
        {
            return urlList[index];
        }

        static public void AddEventLog(EventLog eventLogTest)
        {
            eventLogList.Add(eventLogTest);
        }

        static public void DeleteEventLog(EventLog eventLogTest)
        {
            eventLogList.Remove(eventLogTest);
        }

        static public EventLog[] GetEventLogs()
        {
            return eventLogList.ToArray();
        }

        static public EventLog GetEventLog(int index)
        {
            return eventLogList[index];
        }


        static public void SetFunctionFlags(int ff)
        {
            functionFlags = ff;
        }

        static public int GetFunctionFlags()
        {
            return functionFlags;
        }

    }

    class URLTarget
    {
        public String name;
        public String alias;

        public URLTarget(String n, String a)
        {
            name = n;
            alias = a;
        }
    }

    class EventLog
    {
        public int embIndex;
        public String name;

        public EventLog(int e, String n)
        {
            name = n;
            embIndex = e;
        }

        public override String ToString()
        {
            return this.name;
        }
    }

}
