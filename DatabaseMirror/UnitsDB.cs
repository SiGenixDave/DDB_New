using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    public class UnitsList
    {
        static Int32 key = 0;
        static List<Units> list = new List<Units>() 
        {
            new Units ("NONE", key++),
            new Units ("Volts", key++),
            new Units ("Meters", key++),
            new Units ("Amps", key++),
            new Units ("MPHPS", key++),
        };

        static public Units AddUnits(Units newUnit)
        {
            Units ut = new Units(newUnit.name, key++);
            list.Add(ut);
            return ut;
        }

        static public Units AddUnits(String name)
        {
            Units ut = new Units(name, key++);
            list.Add(ut);
            return ut;
        }

        static public void ModifyUnits(Units ut)
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

        static public Units[] GetUnits()
        {
            return list.ToArray();
        }

        static public void Delete(Units ut)
        {
            list.Remove(ut);
        }

    }

    public class Units
    {
        public Int32 key;
        public String name;

        private Units()
        {

        }

        public Units(String n, Int32 k)
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
