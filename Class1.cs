using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Event_Extesion_Methods
{
    public static class ExtensionMethod
    {
        public static int ToInt(this bool a)
        {
            if (a == true) { return 1; }
            else { return 0; }
           
        }

        public static DateTime ToDate(this string a)
        {
            string[] s = a.Split(new char[] { ',', '.' },StringSplitOptions.RemoveEmptyEntries);
            int.TryParse(s[0], out var date);
            int.TryParse(s[1], out var monsdey);
            int.TryParse(s[2], out var year);
            DateTime dateTime = new DateTime(year, monsdey,date);            
            return dateTime;
                
        }
        public static int ToInt(this double b)
        {
            int a = (int)b;            
            return a;
        }
        
    }
}
