using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class EventVariableList
    {
        static List<EventVariableDB> list = new List<EventVariableDB>();

        static public void Init()
        {
            list.Add(new EventVariableDB("Var 00", "evVar00", 1, 0, 1, 0, 0, 0, "<b>Event Var 00 Description</b>"));
            list.Add(new EventVariableDB("Var 01", "evVar01", 1, 0, 1, 0, 0, 0, "<b>Event Var 01 Description</b>"));
            list.Add(new EventVariableDB("Var 02", "evVar02", 1, 0, 1, 0, 0, 0, "<b>Event Var 02 Description</b>"));
            list.Add(new EventVariableDB("Var 03", "evVar03", 1, 0, 1, 0, 0, 0, "<b>Event Var 03 Description</b>"));
            list.Add(new EventVariableDB("Var 04", "evVar04", 1, 0, 1, 0, 0, 0, "<b>Event Var 04 Description</b>"));
            list.Add(new EventVariableDB("Var 05", "evVar05", 1, 0, 1, 0, 0, 0, "<b>Event Var 05 Description</b>"));
            list.Add(new EventVariableDB("Var 06", "evVar06", 1, 0, 1, 0, 0, 0, "<b>Event Var 06 Description</b>"));
            list.Add(new EventVariableDB("Var 07", "evVar07", 1, 0, 1, 0, 0, 0, "<b>Event Var 07 Description</b>"));
            list.Add(new EventVariableDB("Var 08", "evVar08", 1, 0, 1, 0, 0, 0, "<b>Event Var 08 Description</b>"));
            list.Add(new EventVariableDB("Var 09", "evVar09", 1, 0, 1, 0, 0, 0, "<b>Event Var 09 Description</b>"));
            list.Add(new EventVariableDB("Var 10", "evVar10", 1, 0, 1, 0, 0, 0, "<b>Event Var 10 Description</b>"));
            list.Add(new EventVariableDB("Var 11", "evVar11", 1, 0, 1, 0, 0, 0, "<b>Event Var 11 Description</b>"));
            list.Add(new EventVariableDB("Var 12", "evVar12", 1, 0, 1, 0, 0, 0, "<b>Event Var 12 Description</b>"));
            list.Add(new EventVariableDB("Var 13", "evVar13", 1, 0, 1, 0, 0, 0, "<b>Event Var 13 Description</b>"));
            list.Add(new EventVariableDB("Var 14", "evVar14", 1, 0, 1, 0, 0, 0, "<b>Event Var 14 Description</b>"));
            list.Add(new EventVariableDB("Var 15", "evVar15", 1, 0, 1, 0, 0, 0, "<b>Event Var 15 Description</b>"));
            list.Add(new EventVariableDB("Var 16", "evVar16", 1, 0, 1, 0, 0, 0, "<b>Event Var 16 Description</b>"));
            list.Add(new EventVariableDB("Var 17", "evVar17", 1, 0, 1, 0, 0, 0, "<b>Event Var 17 Description</b>"));
            list.Add(new EventVariableDB("Var 18", "evVar18", 1, 0, 1, 0, 0, 0, "<b>Event Var 18 Description</b>"));
            list.Add(new EventVariableDB("Var 19", "evVar19", 1, 0, 1, 0, 0, 0, "<b>Event Var 19 Description</b>"));
        }

        static public EventVariableDB[] GetEventVariables()
        {
            return list.ToArray();
        }

        static public EventVariableDB GetEventObject(int fkey)
        {
            EventVariableDB ev = null;

            foreach (EventVariableDB e in list)
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
            foreach (EventVariableDB e in updatedList)
            {
                list.Add(e);
            }

        }

    }

    public class EventVariableDB : iDDBHelpObject
    {
        public Int32 fKey;
        public String dispName;
        public String embName;
        public Int32 dataType;
        public Int32 scaleType;
        public Int32 units;
        public Int32 scaleInfo;
        public Int32 unitConversion;
        public Int32 formatString;
        public String helpText;
        static public Int32 key;

        public EventVariableDB(String d, String e, Int32 dt, Int32 st, 
                            Int32 u, Int32 si, Int32 uc, Int32 fs, String ht)
        {
            fKey = key++;
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

        public EventVariableDB(EventVariableDB e) : 
            this (e.dispName, e.embName, e.dataType, e.scaleType, 
                            e.units, e.scaleInfo, e.unitConversion, e.formatString, e.helpText)
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
            if (GlobalSettings.getEventVariableDisplayType() == NameType.DISPLAY)
            {
                return dispName;
            }
            else
            {
                return embName;
            }
        }
    }
}
