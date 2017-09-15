using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class SelfTestList
    {
        static List<SelfTestDB> list = new List<SelfTestDB>();

        static public void Init()
        {
            list.Add(new SelfTestDB("Self Test 1", 101, "ST_101", new List<SelfTestVariableDB>() { SelfTestVariableList.GetEventObject(0), SelfTestVariableList.GetEventObject(1) }, "<b>Sef Test 1 Description</b>"));
        }

        static public SelfTestDB[] GetObjects()
        {
            return list.ToArray();
        }

        static public void Update(object[] updatedList)
        {
            list.Clear();
            foreach (SelfTestDB e in updatedList)
            {
                list.Add(e);
            }
        }

    }


    public class SelfTestDB: iDDBHelpObject
    {
        public String name;
        public Int32 number; 
        public String embeddedName;
        public List<SelfTestVariableDB> variableList;
        public String helpText;
        public Int32 fKey;
        static Int32 key;

        public SelfTestDB(String n, Int32 num, String c, List<SelfTestVariableDB> list, String h)
        {
            name = n;
            number = num;
            embeddedName = c;
            variableList = list;
            helpText = h;
            fKey = key++;
        }

        public SelfTestDB(SelfTestDB ev)
            : this(ev.name, ev.number, ev.embeddedName, ev.variableList, ev.helpText)
        {}

        private SelfTestDB()
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
            return number.ToString() + " - " + name;
        }
     }


}
