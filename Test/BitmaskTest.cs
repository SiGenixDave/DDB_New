using System;
using System.Collections.Generic;

namespace DDB
{
    public class BitmaskTest
    {
        public String dispName;
        public String[] strValues = new String[32];

        private BitmaskTest()
        {
        }

        public BitmaskTest(String dName, String[] sValues)
        {
            dispName = dName;
            for (int index = 0; index < sValues.Length; index++)
            {
                strValues[index] = sValues[index];
            }
        }

        public BitmaskTest(String dName)
        {
            dispName = dName;
        }

        public BitmaskTest(BitmaskTest w)
        {
            dispName = w.dispName;
            for (int index = 0; index < w.strValues.Length; index++)
            {
                strValues[index] = w.strValues[index];
            }
        }
    }

    public class BitmaskVarList
    {
        static public List<BitmaskTest> list = new List<BitmaskTest>();

        static public void AddVar(BitmaskTest w)
        {
            list.Add(w);
        }

        static public void DeleteVar(BitmaskTest w)
        {
            list.Remove(w);
        }

        static public BitmaskTest GetMitmaskCopy(int index)
        {
            BitmaskTest w = new BitmaskTest(list[index]);
            return w;
        }

        static public BitmaskTest GetVar(int index)
        {
            return list[index];
        }

        static public int GetVarCount()
        {
            return list.Count;
        }

        static public String[] GetBitmasks()
        {
            List<String> strList = new List<string>();
            foreach (BitmaskTest b in list)
            {
                strList.Add(b.dispName);
            }

            return strList.ToArray();
        }

        static public void Init()
        {
            String[] val = new String[32];
            list.Add(new BitmaskTest("BitMask 01", val));
            list.Add(new BitmaskTest("BitMask 02", val));
            list.Add(new BitmaskTest("BitMask 03", val));
            list.Add(new BitmaskTest("BitMask 04", val));
            list.Add(new BitmaskTest("BitMask 05", val));
            list.Add(new BitmaskTest("BitMask 06", val));
        }

    }

}