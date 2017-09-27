using System;
using System.Collections.Generic;

namespace DDB
{
    public class SelfTestGroupList
    {
        private static List<SelfTestGroupDB> list = new List<SelfTestGroupDB>();

        static public void Init()
        {
            list.Add(new SelfTestGroupDB("Logic & Passive Tests", 1, 100, 199, new List<SelfTestDB>() { SelfTestList.GetObject(0), SelfTestList.GetObject(1) }));
            list.Add(new SelfTestGroupDB("Interactive Tests", 2, 200, 299, new List<SelfTestDB>() { SelfTestList.GetObject(2), }));
            list.Add(new SelfTestGroupDB("Power Tests", 3, 300, 399, null));
            //new List<SelfTestDB>() { SelfTestList.GetObject(5), SelfTestList.GetObject(7) }
        }

        static public SelfTestGroupDB[] GetObjects()
        {
            return list.ToArray();
        }

        static public void Update(object[] updatedList)
        {
            list.Clear();
            foreach (SelfTestGroupDB e in updatedList)
            {
                list.Add(e);
            }
        }
    }

    public class SelfTestGroupDB
    {
        public String name;
        public Int32 number;
        public Int32 minTestNumber;
        public Int32 maxTestNumber;
        public List<SelfTestDB> selfTestList;
        public Int32 fKey;
        private static Int32 key;

        public SelfTestGroupDB(String n, Int32 num, Int32 min, Int32 max, List<SelfTestDB> sList)
        {
            name = n;
            number = num;
            minTestNumber = min;
            maxTestNumber = max;
            selfTestList = sList;
            fKey = key++;
        }

        public SelfTestGroupDB(SelfTestGroupDB st)
            : this(st.name, st.number, st.minTestNumber, st.maxTestNumber, st.selfTestList)
        { }

        private SelfTestGroupDB()
        { }

        public override string ToString()
        {
            return number.ToString() + " - " + name;
        }
    }
}