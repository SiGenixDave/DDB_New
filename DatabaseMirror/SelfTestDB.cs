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
            SelfTestMessageDB msg1 = new SelfTestMessageDB(1, "Step (1) Message</br>");
            SelfTestMessageDB msg2 = new SelfTestMessageDB(2, "Step (2) Message</br>");
            list.Add(new SelfTestDB("Self Test 1", 101, "ST_101", 
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(0), SelfTestVariableList.GetObject(1) }, 
                                    new List<SelfTestMessageDB>(), "<b>Self Test 101 Description</b></br>"));
            list.Add(new SelfTestDB("Self Test 2", 102, "ST_102", 
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, "<b>Self Test 102 Description</b></br>"));
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
        public List<SelfTestMessageDB> messageList;
        public String descriptionText;
        public Int32 fKey;
        static Int32 key;

        public SelfTestDB(String n, Int32 num, String c, List<SelfTestVariableDB> vList, List<SelfTestMessageDB> mList, String h)
        {
            name = n;
            number = num;
            embeddedName = c;
            variableList = vList;
            messageList = mList;
            descriptionText = h;
            fKey = key++;
        }

        public SelfTestDB(SelfTestDB st)
            : this(st.name, st.number, st.embeddedName, st.variableList, st.messageList, st.descriptionText)
        {}

        private SelfTestDB()
        {}

        public void SaveHelpText(String helpText)
        {
            this.descriptionText = helpText;
        }

        public String GetHelpText()
        {
            return descriptionText;
        }

        public override string ToString()
        {
            return number.ToString() + " - " + name;
        }
     }

    public class SelfTestMessageDB : iDDBHelpObject
    {
        public Int32 number;
        public String messageText;
        public Int32 fKey;
        static Int32 key;

        public SelfTestMessageDB(Int32 num, String m)
        {
            number = num;
            messageText = m;
            fKey = key++;
        }

        public SelfTestMessageDB(SelfTestMessageDB st)
            : this(st.number, st.messageText)
        { }

        private SelfTestMessageDB()
        { }

        public void SaveHelpText(String helpText)
        {
            this.messageText = helpText;
        }

        public String GetHelpText()
        {
            return messageText;
        }

        public override string ToString()
        {
            return number.ToString();
        }

    }



}
