using System;
using System.Collections.Generic;

namespace DDB
{
    public class BitmaskTest
    {
        public String dispName;
        public Int32 key;
        public String[] strValues = new String[32];

        private BitmaskTest()
        {
        }

        public BitmaskTest(String dName, String[] sValues, Int32 k)
        {
            dispName = dName;
            key = k;
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

        public override string ToString()
        {
            return dispName;
        }
    }

    public class BitmaskVarList
    {
        static public List<BitmaskTest> list = new List<BitmaskTest>();
        static public Int32 key = 0;

        static public void AddVar(BitmaskTest w)
        {
            w.key = key++;
            list.Add(w);
        }

        static public BitmaskTest CreateVar(String disp)
        {
            BitmaskTest bmt = new BitmaskTest(disp);
            AddVar(bmt);
            return bmt;
        }
        
        static public void DeleteVar(BitmaskTest w)
        {
            list.Remove(w);
        }


        static public BitmaskTest GetVar(int index)
        {
            return list[index];
        }

        static public int GetVarCount()
        {
            return list.Count;
        }

        static public BitmaskTest[] GetBitmasks()
        {
            return list.ToArray();
        }

        static public void Init()
        {
            String[] val = new String[32];
            list.Add(new BitmaskTest("BitMask 01", val, key++));
            list.Add(new BitmaskTest("BitMask 02", val, key++));
            list.Add(new BitmaskTest("BitMask 03", val, key++));
            list.Add(new BitmaskTest("BitMask 04", val, key++));
            list.Add(new BitmaskTest("BitMask 05", val, key++));
            list.Add(new BitmaskTest("BitMask 06", val, key++));
        }

    }

}