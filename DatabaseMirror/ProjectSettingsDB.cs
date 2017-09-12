using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDB
{
    class ProjectSettingsDB
    {
        static List<URLTarget> urlList = new List<URLTarget>();
        static int functionFlags = 0x11;

        static public void Init()
        {
            urlList.Add(new URLTarget("url1.com", "myAliasURL1.com"));
            urlList.Add(new URLTarget("url2.com", "myAliasURL2.com"));
            urlList.Add(new URLTarget("url3.com", "myAliasURL3.com"));
            urlList.Add(new URLTarget("url4.com", "myAliasURL4.com"));
        }

        static public void AddURL (URLTarget urlTest)
        {
            urlList.Add(urlTest);
        }

        static public void DeleteURL (URLTarget urlTest)
        {
            urlList.Remove(urlTest);
        }

        static public URLTarget[] GetURLs()
        {
            return urlList.ToArray();
        }

        static public URLTarget GetURL(int index)
        {
            return urlList[index];
        }


        static public void SetFunctionFlags(int ff)
        {
            functionFlags = ff;
        }

        static public int GetFunctionFlags()
        {
            return functionFlags;
        }

    }

    class URLTarget
    {
        public String name;
        public String alias;

        public URLTarget(String n, String a)
        {
            name = n;
            alias = a;
        }
    }

}
