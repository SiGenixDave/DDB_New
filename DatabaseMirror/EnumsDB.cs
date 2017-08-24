using System;
using System.Collections.Generic;

namespace DDB
{
    public class Enums
    {
        public Int32 key;
        public String dispName;
        public List<String> strValues = new List<String>();
        public List<int> intValues = new List<int>();

        private Enums()
        {
        }

        public Enums(String dName, int []iValues, String[] sValues, Int32 k)
        {
            dispName = dName;
            key = k;
            for (int index = 0; index < sValues.Length; index++)
            {
                strValues.Add(sValues[index]);
            }
            for (int index = 0; index < iValues.Length; index++)
            {
                intValues.Add(iValues[index]);
            }
        }


        public Enums(Enums e)
        {
            dispName = e.dispName;
            key = e.key;
            for (int index = 0; index < e.strValues.Count; index++)
            {
                strValues.Add(e.strValues[index]);
                intValues.Add(e.intValues[index]);
            }
        }

        public override string ToString()
        {
            return dispName;
        }
    }

    public class EnumList
    {
        static public List<Enums> list = new List<Enums>();
        static public Int32 key;

        static public void AddVar(Enums e)
        {
            list.Add(e);
        }

        static public void DeleteVar(Enums e)
        {
            list.Remove(e);
        }

        static public Enums CreateVar(string name, int[] values, String []names)
        {
            Enums et = new Enums(name, values, names, key++);
            return et;
        }

        static public Enums GetEnumsCopy(int index)
        {
            Enums e = new Enums(list[index]);
            return e;
        }

        static public Enums GetVar(int index)
        {
            return list[index];
        }

        static public int GetVarCount()
        {
            return list.Count;
        }

        static public Enums[] GetEnums()
        {
            return list.ToArray();
        }


        static public void Init()
        {
            list.Add(new Enums("Traffic Light", new int[] {0, 1, 2}, new String[] {"Red", "Yellow", "Green"}, key++));
            list.Add(new Enums("Spin/Slide", new int[] {0, 1}, new String[] {"Spin", "Slide"}, key++));
            list.Add(new Enums("Contactor", new int[] {0, 255}, new String[] {"DeEnergized", "Energized"}, key++));
        }

    }

}