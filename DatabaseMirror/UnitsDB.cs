using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    public class UnitsList
    {
        static List<UnitsDB> list = new List<UnitsDB>() 
        {
            new UnitsDB ("NONE", false),
            new UnitsDB ("Volts", false),
            new UnitsDB ("Meters", false),
            new UnitsDB ("Amps", false),
            new UnitsDB ("MPHPS", false),
        };


        static public UnitsDB[] GetUnits()
        {
            return list.ToArray();
        }

    }

    public class UnitsDB
    {
        public Int32 id;
        public String name;
        public Boolean userDefinedUnits;
        static Int32 key = 0;

        private UnitsDB()
        {}

        public UnitsDB(String n, Boolean udu)
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
