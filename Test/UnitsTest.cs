using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB.Test
{
    public class UnitsTest
    {
        static List <String> myDefines = new List<String>() 
        {
            "NONE",
            "Volts",
            "Meters",
            "Amps",
            "MPHPS",
        };

        static public void AddUnits(String newUnit)
        {
            myDefines.Add(newUnit);
        }

        static public void ModifyUnits(int index, String modifiedUnit)
        {
            myDefines[index] = modifiedUnit;
        }

        static public String[] GetUnits()
        {
            return myDefines.ToArray();
        }

        static public String GetUnit(Int32 index)
        {
            return myDefines[index];
        }

        static public void Delete(String unit)
        {
            myDefines.Remove(unit);
        }

        static public void Delete(String []units)
        {
            foreach (String u in units)
            {
                myDefines.Remove(u);
            }
        }


    }

}
