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
            new Units ("NONE"),
            new Units ("Volts"),
            new Units ("Meters"),
            new Units ("Amps"),
            new Units ("MPHPS"),
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
        static Int32 key = 0;

        private Units()
        {

        }

        public Units(String n)
        {
            name = n;
            id = key++;
        }

        public override string ToString()
        {
            return name;
        }

    }

}
