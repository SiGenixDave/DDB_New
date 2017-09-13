﻿using System;
using System.Collections.Generic;

namespace DDB
{
    public class WatchVarList
    {
        static public void Init()
        {

            list.Add(new WatchVarDB("Motion - Var 01", "motion01", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Motion - Var 01</b>"));
            list.Add(new WatchVarDB("Motion - Var 02", "motion02", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Motion - Var 02</b>"));
            list.Add(new WatchVarDB("Motion - Var 03", "motion03", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Motion - Var 03</b>"));
            list.Add(new WatchVarDB("Velocity - Var 01", "velocity01", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Velocity - Var 01</b>"));
            list.Add(new WatchVarDB("Velocity - Var 02", "velocity02", 0, 65535, 0, 65535, 1, 0, 1, 0, 0, 0, 0, 0, "<b>Velocity - Var 02</b>"));
        }

        static public List<WatchVarDB> list = new List<WatchVarDB>();

        static public WatchVarDB[] GetWatchVars()
        {
            return list.ToArray();
        }

    }
    
    public class WatchVarDB: iDDBHelpObject
    {
        public String dispName;
        public String embName;
        public Int32 minChart;
        public Int32 maxChart;
        public Int32 minVal;
        public Int32 maxVal;
        public Int32 dataType;
        public Int32 scaleType;
        public Int32 units; 
        public Int32 scaleInfo;
        public Int32 unitConversion;
        public Int32 formatString;
        public Int32 readWrite;
        public Int32 engineeringViewOnly;
        public String helpText;
        public Int32 fKey;
        static Int32 key;

        private WatchVarDB()
        {
        }


        public WatchVarDB(String d, String e, Int32 minC, Int32 maxC, Int32 minV, Int32 maxV, Int32 dt, Int32 st, 
                            Int32 u, Int32 si, Int32 uc, Int32 fs, Int32 rw, Int32 evo, String ht)
        {
            dispName = d;
            embName = e;
            minChart = minC;
            maxChart = maxC;
            minVal = minV;
            maxVal = maxV;
            dataType = dt;
            scaleType = st;
            units = u;
            scaleInfo = si;
            unitConversion = uc;
            formatString = fs;
            readWrite= rw;
            engineeringViewOnly = evo;
            helpText = ht;
            fKey = key++;
        }

        public WatchVarDB(WatchVarDB w)
        {
            dispName = w.dispName;
            embName = w.embName;
            minChart = w.minChart;
            maxChart = w.maxChart;
            minVal = w.minVal;
            maxVal = w.maxVal;
            dataType = w.dataType;
            scaleType = w.scaleType;
            units = w.units;
            scaleInfo = w.scaleInfo;
            unitConversion = w.unitConversion;
            formatString = w.formatString;
            readWrite = w.readWrite;
            engineeringViewOnly = w.engineeringViewOnly;
            helpText = w.helpText;
            fKey = key++;
        }

        public void SaveHelpText(string helpText)
        {
            this.helpText = helpText;
        }

        public string GetHelpText()
        {
            return this.helpText;
        }

        public override string ToString()
        {
            if (GlobalSettings.getWatchDisplayType() == NameType.DISPLAY)
            {
                return dispName;
            }
            else
            {
                return embName;
            }
        }

    }

}