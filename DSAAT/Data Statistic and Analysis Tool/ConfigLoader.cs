using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Statistic_and_Analysis_Tool
{
    class ConfigLoader
    {
        public static string vDBPATH()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vDBPath = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            return vDBPath;
        }
    }
}
