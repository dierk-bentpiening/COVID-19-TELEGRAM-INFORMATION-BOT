using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Statistic_and_Analysis_Tool
{
    class ConfigLoader
    {
      
        public static string vFTPURI()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[1].ToString();

            return vDataBuffer;
        }
          public static String vDBPATH()
        {

            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[0].ToString();

            return vDataBuffer;
        }
        public static String vFTPUSERNAME()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[2].ToString();

            return vDataBuffer;
        }
        public static String vFTPPASSWORD()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[3].ToString();

            return vDataBuffer;

        }
        public static String vPUBLICURL()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[4].ToString();

            return vDataBuffer;
        }

        public static String vBOTAUTHCODE()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[5].ToString();

            return vDataBuffer;
        }
    }
}
