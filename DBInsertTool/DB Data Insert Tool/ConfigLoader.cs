using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Data_Insert_Tool
{
    public class ConfigLoader
    {
        public static string vDBPATH()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vDBPath = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            return vDBPath;
        }
    }
}
