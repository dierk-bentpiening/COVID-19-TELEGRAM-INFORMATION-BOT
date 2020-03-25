/*Copyright 2020 Dierk-Bent Piening, Roman Spies

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify,merge, publish, distribute, sublicense,
and/or sell copies of the Software,and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/



using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid19bot
{
    public class ConfigLoader
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

        public static string vURL()
        {
            string vurl = "";
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + vDBPATH());
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from URLLIST ORDER BY rowid DESC LIMIT 1", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
               
                while (reader.Read())
                {
                    vurl = reader.GetString(reader.GetOrdinal("URL"));
                    Console.WriteLine("### Abfrage des BL Bild Link data------------{0}");
                    
                }
                return vurl;
                connection.Close();
            }
            else
            {
                return "nodata";
            }
        }
    }
}

