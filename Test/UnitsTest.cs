using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    public class UnitsTestList
    {
        static Int32 key = 0;
        static List<UnitsTest> list = new List<UnitsTest>() 
        {
            new UnitsTest ("NONE", key++),
            new UnitsTest ("Volts", key++),
            new UnitsTest ("Meters", key++),
            new UnitsTest ("Amps", key++),
            new UnitsTest ("MPHPS", key++),
        };

        static public UnitsTest AddUnits(UnitsTest newUnit)
        {
            UnitsTest ut = new UnitsTest(newUnit.name, key++);
            list.Add(ut);
            return ut;
        }

        static public UnitsTest AddUnits(String name)
        {
            UnitsTest ut = new UnitsTest(name, key++);
            list.Add(ut);
            return ut;
        }

        static public void ModifyUnits(UnitsTest ut)
        {
            Int32 index = 0;

            while (index < list.Count)
            {
                if (list[index].key == ut.key)
                {
                    list[index] = ut;
                }
            }
        }

        static public UnitsTest[] GetUnits()
        {
            return list.ToArray();
        }

        static public void Delete(UnitsTest ut)
        {
            list.Remove(ut);
        }

    }

    public class UnitsTest
    {
        public Int32 key;
        public String name;

        private UnitsTest()
        {

        }

        public UnitsTest(String n, Int32 k)
        {
            name = n;
            key = k;
        }

        public override string ToString()
        {
            return name;
        }

    }

}
