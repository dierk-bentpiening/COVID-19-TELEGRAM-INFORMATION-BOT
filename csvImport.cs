using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Data_Statistic_and_Analysis_Tool
{
    class CSVImport
    {
        public static void Main()
        {
            string[] bl_filter = { "Bayern", "Saarland", "Sachsen" };
            string[] start_dates = { "21.03.2020", "21.03.2020", "23.03.2020" };
            string[] stop_dates = { "03.04.2020", "03.04.2020", "05.04.2020" };



            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vPath = vDBALLBUFFER[0].ToString();
            Console.WriteLine(vPath);
            SQLiteConnection.CreateFile(vPath);
            var connectionDb = new SQLiteConnection($"URI=file:{vPath}");
            connectionDb.Open();
            var dbComm = new SQLiteCommand(connectionDb);
            dbComm.CommandText = "SELECT * FROM AusgangssperrenLK";
            SQLiteDataReader dataDump = dbComm.ExecuteReader();
            List<int> initializeDiscard = new List<int>();
            List<int> initializeUpdate = new List<int>();

            while (dataDump.Read())
            {
                var plzDbCurrent = dataDump.GetInt32(6);
                var bundeslandDbCurrent = dataDump.GetString(4);
                var vonDbCurrent = dataDump.GetString(2);
                var bisDbCurrent = dataDump.GetString(3);

                var neustopDate = stop_dates[Array.IndexOf(bl_filter, bundeslandDbCurrent)];
                var neustartDate = start_dates[Array.IndexOf(bl_filter, bundeslandDbCurrent)];
                if (neustartDate == vonDbCurrent & neustopDate == bisDbCurrent)
                {
                    initializeDiscard.Add(plzDbCurrent);
                }
                else
                {
                    initializeUpdate.Add(plzDbCurrent);
                }
            }
            var dbCommWrite = new SQLiteCommand(connectionDb);
            string[] lines = System.IO.File.ReadAllLines("", Encoding.GetEncoding(65001));
            //int itcounter = 0;
            string[] stadtStaaten = { "Berlin", "Hamburg", "Bremen" };
            foreach (var line in lines)
            {
                var splitUp = line.Split(',');
                var ortCurrent = splitUp[2].ToString();
                var plzCurrent = System.Convert.ToInt32(splitUp[3]);
                var landkreisCurrent = splitUp[4].ToString();
                var bundeslandCurrent = splitUp[5].ToString();
                

                if (bl_filter.Contains(bundeslandCurrent) &  initializeDiscard.Contains(plzCurrent))
                {

                }
                else if (bl_filter.Contains(bundeslandCurrent) & initializeUpdate.Contains(plzCurrent))
                {
                    dbCommWrite.CommandText = $"UPDATE AusgangssperrenLK SET BIS = {stop_dates[Array.IndexOf(bl_filter, bundeslandCurrent)]}, VON = {start_dates[Array.IndexOf(bl_filter, bundeslandCurrent)]} WHERE PLZ = {plzCurrent}";
                    dbCommWrite.ExecuteNonQuery();

                }
                else if (bl_filter.Contains(bundeslandCurrent))
                {
                    var vonCurrent = start_dates[Array.IndexOf(bl_filter, bundeslandCurrent)];
                    var bisCurrent = stop_dates[Array.IndexOf(bl_filter, bundeslandCurrent)];
                    var behoerdeCurrent = whichBehoerde(bundeslandCurrent, stadtStaaten);
                    
                    
                    dbCommWrite.CommandText = $"INSERT INTO AusgangssperrenLK (LKN, VON, BIS, Bundesland, BEHÖRDE, PLZ) VALUES ({landkreisCurrent},{vonCurrent},{bisCurrent},{bundeslandCurrent},{behoerdeCurrent},{plzCurrent})";
                    dbCommWrite.ExecuteNonQuery();
                }

            }


        connectionDb.Close();

            


        }
        public static string whichBehoerde(string input, string[] input2)
        {
            if (input2.Contains(input))
            {
                return $"Senat {input}";
            }
            else
            {
                return $"Staatskanzlei {input}";
            }
        }
    }
}
