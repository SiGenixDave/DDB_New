using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    public class UnitsList
    {
        static List<Units> list = new List<Units>() 
        {
            new Units ("NONE", false),
            new Units ("Volts", false),
            new Units ("Meters", false),
            new Units ("Amps", false),
            new Units ("MPHPS", false),
        };

        static public void AddUnits(Units newUnit)
        {
            list.Add(newUnit);
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
        public Int32 id;
        public String name;
        public Boolean userDefinedUnits;
        static Int32 key = 0;

        private Units()
        {}

        public Units(String n, Boolean udu)
        {
            name = n;
            userDefinedUnits = udu;
            id = key++;
        }

        public override string ToString()
        {
            return name;
        }

    }

}
