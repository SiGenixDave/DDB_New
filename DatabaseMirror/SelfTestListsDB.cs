using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{

    public class SelfTestListList
    {
        static List<SelfTestListDB> list = new List<SelfTestListDB>();

        static public void Init()
        {
            list.Add(new SelfTestListDB("Power Tests", 1, new List<SelfTestDB>() {SelfTestList.GetObject(0), SelfTestList.GetObject(1)} ));
            list.Add(new SelfTestListDB("Interactive Tests", 2, new List<SelfTestDB>() { SelfTestList.GetObject(2), SelfTestList.GetObject(3), SelfTestList.GetObject(4) }));
            list.Add(new SelfTestListDB("Engineering Tests", 3, new List<SelfTestDB>() { SelfTestList.GetObject(5), SelfTestList.GetObject(6), SelfTestList.GetObject(7) }));
        }

        static public SelfTestListDB[] GetObjects()
        {
            return list.ToArray();
        }

        static public void Update(object[] updatedList)
        {
            list.Clear();
            foreach (SelfTestListDB e in updatedList)
            {
                list.Add(e);
            }
        }

    }


    public class SelfTestListDB
    {
        public String name;
        public Int32 number; 
        public List<SelfTestDB> selfTestList;
        public Int32 fKey;
        static Int32 key;

        public SelfTestListDB(String n, Int32 num, List<SelfTestDB> sList)
        {
            name = n;
            number = num;
            selfTestList = sList;
            fKey = key++;
        }

        public SelfTestListDB(SelfTestListDB st)
            : this(st.name, st.number, st.selfTestList)
        {}

        private SelfTestListDB()
        {}

        public override string ToString()
        {
            return number.ToString() + " - " + name;
        }
     }


}
