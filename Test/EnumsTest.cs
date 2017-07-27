using System;
using System.Collections.Generic;

namespace DDB
{
    public class EnumsTest
    {
        public String dispName;
        public List<String> strValues = new List<String>();
        public List<int> intValues = new List<int>();

        private EnumsTest()
        {
        }

        public EnumsTest(String dName, int []iValues, String[] sValues)
        {
            dispName = dName;
            for (int index = 0; index < sValues.Length; index++)
            {
                strValues.Add(sValues[index]);
            }
            for (int index = 0; index < iValues.Length; index++)
            {
                intValues.Add(iValues[index]);
            }
        }

        public EnumsTest(String dName)
        {
            dispName = dName;
        }

        public EnumsTest(EnumsTest e)
        {
            dispName = e.dispName;
            for (int index = 0; index < e.strValues.Count; index++)
            {
                strValues.Add(e.strValues[index]);
                intValues.Add(e.intValues[index]);
            }
        }
    }

    public class EnumVarList
    {
        static public List<EnumsTest> list = new List<EnumsTest>();

        static public void AddVar(EnumsTest e)
        {
            list.Add(e);
        }

        static public void DeleteVar(EnumsTest e)
        {
            list.Remove(e);
        }

        static public EnumsTest GetEnumsCopy(int index)
        {
            EnumsTest e = new EnumsTest(list[index]);
            return e;
        }

        static public EnumsTest GetVar(int index)
        {
            return list[index];
        }

        static public int GetVarCount()
        {
            return list.Count;
        }

        static public String[] GetNames()
        {
            List<String> strList = new List<string>();
            foreach (EnumsTest e in list)
            {
                strList.Add(e.dispName);
            }

            return strList.ToArray();
        }


        static public void Init()
        {
            list.Add(new EnumsTest("Traffic Light", new int[] {0, 1, 2}, new String[] {"Red", "Yellow", "Green"}));
            list.Add(new EnumsTest("Spin/Slide", new int[] {0, 1}, new String[] {"Spin", "Slide"}));
            list.Add(new EnumsTest("Contactor", new int[] {0, 255}, new String[] {"DeEnergized", "Energized"}));
        }

    }

}