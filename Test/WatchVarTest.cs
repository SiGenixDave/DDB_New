using System;
using System.Collections.Generic;

namespace DDB
{
    internal class WatchVarTest
    {
        public String dispName;
        public String embName;
        public Int32 minChart;
        public Int32 maxChart;
        public Int32 minVal;
        public Int32 maxVal;
        public Int32 units;
        public Int32 type;
        public Int32 readWrite;
        public String helpText;

        public WatchVarTest(String d, String e, Int32 minC, Int32 maxC, Int32 minV, Int32 maxV, Int32 u, Int32 t, Int32 rw, String help)
        {
            dispName = d;
            embName = e;
            minChart = minC;
            maxChart = maxC;
            minVal = minV;
            maxVal = maxV;
            units = u;
            type = t;
            readWrite = rw;
            helpText = help;
        }

        public WatchVarTest(WatchVarTest w)
        {
            dispName = w.dispName;
            embName = w.embName;
            minChart = w.minChart;
            maxChart = w.maxChart;
            minVal = w.minVal;
            maxVal = w.maxVal;
            units = w.units;
            type = w.type;
            readWrite = w.readWrite;
            helpText = w.helpText;
        }
    }

    internal class WatchVarList
    {
        static public List<WatchVarTest> list = new List<WatchVarTest>();

        static public void AddVar(WatchVarTest w)
        {
            list.Add(w);
        }

        static public void DeleteVar(WatchVarTest w)
        {
            list.Remove(w);
        }

        static public WatchVarTest GetWatchVarCopy(int index)
        {
            WatchVarTest w = new WatchVarTest(list[index]);
            return w;
        }
        
        static public WatchVarTest GetWatchVar(int index)
        {
            return list[index];
        }

        static public int GetWatchVarCount()
        {
            return list.Count;
        }

        static public void Init(FormMain mForm)
        {
            list.Add(new WatchVarTest("Motion - Var 01", "motion01", 0, 65535, 0, 65535, 1, 1, 0, "<b>Motion - Var 01</b><p>motion01"));
            list.Add(new WatchVarTest("Motion - Var 02", "motion02", 0, 255, 0, 255, 0, 0, 0, "<b>Motion - Var 02</b><p>motion02"));
            list.Add(new WatchVarTest("Motion - Var 03", "motion03", -20, 20, -200, 200, 4, 1, 1, "<b>Motion - Var 03</b><p>motion03"));
            list.Add(new WatchVarTest("Velocity - Var 01", "velocity01", 0, 100, 0, 100, 1, 0, 2, "<b>Velocity - Var 01</b><p>velocity01"));
            list.Add(new WatchVarTest("Velocity - Var 02", "velocity02", 0, 255, 0, 255, 0, 0, 1, "<b>Velocity - Var 02</b><p>velocity02"));
        }
    }
}