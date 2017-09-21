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
                                    new List<SelfTestMessageDB>(), 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 101 Description</b></br>")));
            list.Add(new SelfTestDB("Self Test 2", 102, "ST_102", 
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 102 Description</b></br>")));
            list.Add(new SelfTestDB("Self Test 3", 201, "ST_201",
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 201 Description</b></br>")));
            list.Add(new SelfTestDB("Self Test 4", 202, "ST_202",
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 202 Description</b></br>")));
            list.Add(new SelfTestDB("Self Test 5", 203, "ST_203",
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 203 Description</b></br>")));
            list.Add(new SelfTestDB("Self Test 6", 301, "ST_301",
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 301 Description</b></br>")));
            list.Add(new SelfTestDB("Self Test 7", 302, "ST_302",
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 302 Description</b></br>")));
            list.Add(new SelfTestDB("Self Test 8", 303, "ST_303",
                                    new List<SelfTestVariableDB>() { SelfTestVariableList.GetObject(2) },
                                    new List<SelfTestMessageDB>() { msg1, msg2 }, 
                                    new SelfTestMessageDB(0 ,"<b>Self Test 303 Description</b></br>")));
        }

        static public SelfTestDB[] GetObjects()
        {
            return list.ToArray();
        }

        static public SelfTestDB GetObject(Int32 index)
        {
            return list[index];
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
        public SelfTestMessageDB description;
        public Int32 fKey;
        static Int32 key;

        public SelfTestDB(String n, Int32 num, String c, List<SelfTestVariableDB> vList, List<SelfTestMessageDB> mList, SelfTestMessageDB d)
        {
            name = n;
            number = num;
            embeddedName = c;
            variableList = vList;
            messageList = mList;
            description = d;
            fKey = key++;
        }

        public SelfTestDB(SelfTestDB st)
            : this(st.name, st.number, st.embeddedName, st.variableList, st.messageList, st.description)
        {}

        private SelfTestDB()
        {}

        public void SaveHelpText(String helpText)
        {
            this.description.messageText = helpText;
        }

        public String GetHelpText()
        {
            return description.messageText;
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
