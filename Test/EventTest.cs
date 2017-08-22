using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class EventInfoTest
    {
        static List<EventVariableTest> evVars = new List<EventVariableTest>();
        static List<EventStructureTest> evStructs = new List<EventStructureTest>();
        static List<EventTest> events = new List<EventTest>();

        static public void Init()
        {
            CreateEventVariables();
            CreateEventStructures();
            CreateEvents();
        }

        static public EventTest[] GetEvents()
        {
            return events.ToArray();
        }

        static public EventStructureTest[] GetEventStructures()
        {
            return evStructs.ToArray();
        }

        static public EventVariableTest[] GetEventVariables()
        {
            return evVars.ToArray();
        }
        static public EventVariableTest GetEventVariable(int i)
        {
            return evVars[i];
        }

        static public EventTest GetEvent(Int32 id)
        {
            foreach (EventTest e in events)
            {
                if (e.dbId == id)
                {
                    return e;
                }
            }

            return null;
        }


        static public void AddNewEvent(EventTest ev)
        {
            events.Add(ev);
        }

        static public void DeleteEvent(EventTest ev)
        {
            events.Remove(ev);
        }

        static public EventStructureTest GetEventStructure(String name)
        {
            foreach (EventStructureTest e in evStructs)
            {
                if (e.name == name)
                {
                    return e;
                }
            }

            return null;
        }

        static public EventStructureTest GetEventStructure(int i)
        {
            return evStructs[i];
        }

        static public void AddNewEventStructure(EventStructureTest e)
        {
            evStructs.Add(e);
        }

        static public void DeleteEventStructure(EventStructureTest ev)
        {
            evStructs.Remove(ev);
        }


        static private void CreateEvents()
        {
            events.Add(new EventTest("Event 1", "EV_1", 0, 0, "<b>Event 1 Description</b>"));
            events.Add(new EventTest("Event 2", "EV_2", 1, 1, "<i>Event 2 Description</i>"));
            events.Add(new EventTest("Event 3", "EV_3", 1, 2, "<u>Event 3 Description</u>"));
            events.Add(new EventTest("Event 4", "EV_4", 1, 3, "<em>Event 4 Description</em>"));
        }

        static private void CreateEventStructures()
        {
            evStructs.Add(new EventStructureTest("Event_1_Str", new List<int>() { 0, 1, 2, 3 }));
            evStructs.Add(new EventStructureTest("Event_2_Str", new List<int>() { 4, 5 }));
            evStructs.Add(new EventStructureTest("Event_3_Str", new List<int>() { 6, 7, 8, 9, 10, 11, 12, 13}));
            evStructs.Add(new EventStructureTest("Event_4_Str", new List<int>() { 14, 15, 16, 17, 18, 19 }));
        }

        static private void CreateEventVariables()
        {
            evVars.Add(new EventVariableTest("Var 00", "evVar00", 1, 0, 1, 0, 0, 0, "<b>Event Var 00 Description</b>"));
            evVars.Add(new EventVariableTest("Var 01", "evVar01", 1, 0, 1, 0, 0, 0, "<b>Event Var 01 Description</b>"));
            evVars.Add(new EventVariableTest("Var 02", "evVar02", 1, 0, 1, 0, 0, 0, "<b>Event Var 02 Description</b>"));
            evVars.Add(new EventVariableTest("Var 03", "evVar03", 1, 0, 1, 0, 0, 0, "<b>Event Var 03 Description</b>"));
            evVars.Add(new EventVariableTest("Var 04", "evVar04", 1, 0, 1, 0, 0, 0, "<b>Event Var 04 Description</b>"));
            evVars.Add(new EventVariableTest("Var 05", "evVar05", 1, 0, 1, 0, 0, 0, "<b>Event Var 05 Description</b>"));
            evVars.Add(new EventVariableTest("Var 06", "evVar06", 1, 0, 1, 0, 0, 0, "<b>Event Var 06 Description</b>"));
            evVars.Add(new EventVariableTest("Var 07", "evVar07", 1, 0, 1, 0, 0, 0, "<b>Event Var 07 Description</b>"));
            evVars.Add(new EventVariableTest("Var 08", "evVar08", 1, 0, 1, 0, 0, 0, "<b>Event Var 08 Description</b>"));
            evVars.Add(new EventVariableTest("Var 09", "evVar09", 1, 0, 1, 0, 0, 0, "<b>Event Var 09 Description</b>"));
            evVars.Add(new EventVariableTest("Var 10", "evVar10", 1, 0, 1, 0, 0, 0, "<b>Event Var 10 Description</b>"));
            evVars.Add(new EventVariableTest("Var 11", "evVar11", 1, 0, 1, 0, 0, 0, "<b>Event Var 11 Description</b>"));
            evVars.Add(new EventVariableTest("Var 12", "evVar12", 1, 0, 1, 0, 0, 0, "<b>Event Var 12 Description</b>"));
            evVars.Add(new EventVariableTest("Var 13", "evVar13", 1, 0, 1, 0, 0, 0, "<b>Event Var 13 Description</b>"));
            evVars.Add(new EventVariableTest("Var 14", "evVar14", 1, 0, 1, 0, 0, 0, "<b>Event Var 14 Description</b>"));
            evVars.Add(new EventVariableTest("Var 15", "evVar15", 1, 0, 1, 0, 0, 0, "<b>Event Var 15 Description</b>"));
            evVars.Add(new EventVariableTest("Var 16", "evVar16", 1, 0, 1, 0, 0, 0, "<b>Event Var 16 Description</b>"));
            evVars.Add(new EventVariableTest("Var 17", "evVar17", 1, 0, 1, 0, 0, 0, "<b>Event Var 17 Description</b>"));
            evVars.Add(new EventVariableTest("Var 18", "evVar18", 1, 0, 1, 0, 0, 0, "<b>Event Var 18 Description</b>"));
            evVars.Add(new EventVariableTest("Var 19", "evVar19", 1, 0, 1, 0, 0, 0, "<b>Event Var 19 Description</b>"));
        }


    }


    public class EventTest: iDDBHelpObject
    {
        public String name;
        public String cDefineName;
        public Int32 logId;
        public Int32 structId;
        public String helpText;
        public Int32 dbId;
        static Int32 idCount;

        public EventTest(String n, String c, Int32 l, Int32 s, String h)
        {
            name = n;
            cDefineName = c; 
            logId = l;
            structId = s;
            helpText = h;
            dbId = idCount++;
        }

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

    public class EventStructureTest
    {
        public Int32 id;
        public String name;
        public List<Int32> varId;
        static Int32 sId;

        public EventStructureTest(String n, List<Int32> l)
        {
            name = n;
            varId = l;
            id = sId++;
        }

        public override string ToString()
        {
            return name;
        }
    }

    public class EventVariableTest
    {
        public Int32 id;
        public String dispName;
        public String embName;
        public Int32 dataType;
        public Int32 scaleType;
        public Int32 units;
        public Int32 scaleInfo;
        public Int32 unitConversion;
        public Int32 formatString;
        public String helpText;
        static public Int32 sId;

        public EventVariableTest(String d, String e, Int32 dt, Int32 st, 
                            Int32 u, Int32 si, Int32 uc, Int32 fs, String ht)
        {
            id = sId++;
            dispName = d;
            embName = e;
            dataType = dt;
            scaleType = st;
            units = u;
            scaleInfo = si;
            unitConversion = uc;
            formatString = fs;
            helpText = ht;
        }

        public override string ToString()
        {
            return dispName;
        }


    }


}
