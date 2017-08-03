using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    class ProjectSettingsTest
    {
        static List<URLTest> urlList = new List<URLTest>();
        static List<EventLogTest> eventLogList = new List<EventLogTest>();
        static int functionFlags = 0x11;

        static public void Init()
        {

            urlList.Add(new URLTest("url1.com", "myAliasURL1.com"));
            urlList.Add(new URLTest("url2.com", "myAliasURL2.com"));
            urlList.Add(new URLTest("url3.com", "myAliasURL3.com"));
            urlList.Add(new URLTest("url4.com", "myAliasURL4.com"));

            eventLogList.Add(new EventLogTest(0, "Propulsion"));
            eventLogList.Add(new EventLogTest(1, "Engineering"));

        }

        static public void AddURL (URLTest urlTest)
        {
            urlList.Add(urlTest);
        }

        static public void DeleteURL (URLTest urlTest)
        {
            urlList.Remove(urlTest);
        }

        static public URLTest[] GetURLs()
        {
            return urlList.ToArray();
        }

        static public URLTest GetURL(int index)
        {
            return urlList[index];
        }

        static public void AddEventLog(EventLogTest eventLogTest)
        {
            eventLogList.Add(eventLogTest);
        }

        static public void DeleteEventLog(EventLogTest eventLogTest)
        {
            eventLogList.Remove(eventLogTest);
        }

        static public EventLogTest[] GetEventLogs()
        {
            return eventLogList.ToArray();
        }

        static public EventLogTest GetEventLog(int index)
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

    class URLTest
    {
        public String name;
        public String alias;

        public URLTest(String n, String a)
        {
            name = n;
            alias = a;
        }
    }

    class EventLogTest
    {
        public int embIndex;
        public String name;

        public EventLogTest(int e, String n)
        {
            name = n;
            embIndex = e;
        }
    }

}
