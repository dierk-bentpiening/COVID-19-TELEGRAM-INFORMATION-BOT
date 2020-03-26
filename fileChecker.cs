using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Data_Statistic_and_Analysis_Tool
{
    class fileChecker
    {
        static bool checkForDb()
        {
            //Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[0].ToString();

            return System.IO.File.Exists(vDataBuffer);
        }
    }
}
