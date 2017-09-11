using System;
using System.Collections.Generic;

namespace DDB
{
    public class BitmaskDB
    {
        public String dispName;
        public Int32 fKey;
        public String[] strValues = new String[32];
        static Int32 key;

        private BitmaskDB()
        {}

        public BitmaskDB(String dName, String[] sValues)
        {
            dispName = dName;
            fKey = key++;
            for (int index = 0; index < sValues.Length; index++)
            {
                strValues[index] = sValues[index];
            }
        }

        public BitmaskDB(String dName)
        {
            dispName = dName;
            fKey = key++;
            for (int index = 0; index < strValues.Length; index++)
            {
                strValues[index] = null;
            }
        }

        public BitmaskDB(BitmaskDB w): this(w.dispName, w.strValues)
        {}

        public override string ToString()
        {
            return dispName;
        }
    }

    public class BitmaskList
    {
        static public List<BitmaskDB> list = new List<BitmaskDB>();

        static public BitmaskDB[] GetBitmasks()
        {
            return list.ToArray();
        }

        static public void Init()
        {
            String[] val = new String[32];
            list.Add(new BitmaskDB("BitMask 01", val));
            list.Add(new BitmaskDB("BitMask 02", val));
            list.Add(new BitmaskDB("BitMask 03", val));
            list.Add(new BitmaskDB("BitMask 04", val));
            list.Add(new BitmaskDB("BitMask 05", val));
            list.Add(new BitmaskDB("BitMask 06", val));
        }

    }

}