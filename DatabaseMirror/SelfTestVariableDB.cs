using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class SelfTestVariableList
    {
        static List<SelfTestVariableDB> list = new List<SelfTestVariableDB>();

        static public void Init()
        {
            list.Add(new SelfTestVariableDB("Var 00", "stVar00", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 00 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 01", "stVar01", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 01 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 02", "stVar02", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 02 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 03", "stVar03", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 03 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 04", "stVar04", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 04 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 05", "stVar05", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 05 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 06", "stVar06", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 06 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 07", "stVar07", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 07 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 08", "stVar08", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 08 Description</b>"));
            list.Add(new SelfTestVariableDB("Var 09", "stVar09", 1, 0, 1, 0, 0, 0, "<b>Self Test Var 09 Description</b>"));
        }

        static public SelfTestVariableDB[] GetSelfTestVariables()
        {
            return list.ToArray();
        }

        static public SelfTestVariableDB GetObject(int fkey)
        {
            SelfTestVariableDB ev = null;

            foreach (SelfTestVariableDB e in list)
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
            foreach (SelfTestVariableDB e in updatedList)
            {
                list.Add(e);
            }

        }

    }

    public class SelfTestVariableDB
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

        public SelfTestVariableDB(String d, String e, Int32 dt, Int32 st, 
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

        public SelfTestVariableDB(EventVariableDB e) : 
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
            if (GlobalSettings.getSelfTestVariableDisplayType() == NameType.DISPLAY)
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
