using System;
using System.Collections.Generic;

namespace DDB
{
    public class Bitmask
    {
        public String dispName;
        public Int32 key;
        public String[] strValues = new String[32];

        private Bitmask()
        {
        }

        public Bitmask(String dName, String[] sValues, Int32 k)
        {
            dispName = dName;
            key = k;
            for (int index = 0; index < sValues.Length; index++)
            {
                strValues[index] = sValues[index];
            }
        }

        public Bitmask(String dName)
        {
            dispName = dName;
        }

        public Bitmask(Bitmask w)
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

    public class BitmaskList
    {
        static public List<Bitmask> list = new List<Bitmask>();
        static public Int32 key = 0;

        static public void AddVar(Bitmask w)
        {
            w.key = key++;
            list.Add(w);
        }

        static public Bitmask CreateVar(String disp)
        {
            Bitmask bmt = new Bitmask(disp);
            AddVar(bmt);
            return bmt;
        }
        

        static public Bitmask GetVar(int index)
        {
            return list[index];
        }

        static public int GetVarCount()
        {
            return list.Count;
        }

        static public Bitmask[] GetBitmasks()
        {
            return list.ToArray();
        }

        static public void Init()
        {
            String[] val = new String[32];
            list.Add(new Bitmask("BitMask 01", val, key++));
            list.Add(new Bitmask("BitMask 02", val, key++));
            list.Add(new Bitmask("BitMask 03", val, key++));
            list.Add(new Bitmask("BitMask 04", val, key++));
            list.Add(new Bitmask("BitMask 05", val, key++));
            list.Add(new Bitmask("BitMask 06", val, key++));
        }

    }

}