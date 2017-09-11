using System;
using System.Collections.Generic;

namespace DDB
{
    public class EnumsDB
    {
        public Int32 fKey;
        public String dispName;
        public List<String> strValues = new List<String>();
        public List<int> intValues = new List<int>();

        static Int32 key;

        private EnumsDB()
        {
        }

        public EnumsDB(String dName)
        {
            dispName = dName;
            fKey = key++;
        }

        public EnumsDB(String dName, int []iValues, String[] sValues)
        {
            dispName = dName;
            fKey = key++;
            for (int index = 0; index < sValues.Length; index++)
            {
                strValues.Add(sValues[index]);
            }
            for (int index = 0; index < iValues.Length; index++)
            {
                intValues.Add(iValues[index]);
            }
        }


        public EnumsDB(EnumsDB e): this(e.dispName, e.intValues.ToArray(), e.strValues.ToArray())
        { }

        public override string ToString()
        {
            return dispName;
        }
    }

    public class EnumList
    {
        static public List<EnumsDB> list = new List<EnumsDB>();


        static public EnumsDB[] GetEnums()
        {
            return list.ToArray();
        }

        static public void Init()
        {
            list.Add(new EnumsDB("Traffic Light", new int[] {0, 1, 2}, new String[] {"Red", "Yellow", "Green"}));
            list.Add(new EnumsDB("Spin/Slide", new int[] {0, 1}, new String[] {"Spin", "Slide"}));
            list.Add(new EnumsDB("Contactor", new int[] {0, 255}, new String[] {"DeEnergized", "Energized"}));
        }

    }

}