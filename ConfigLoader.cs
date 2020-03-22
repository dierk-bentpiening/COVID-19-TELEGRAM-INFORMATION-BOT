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
        public static string vDBPATH()
        {
            Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vDBPath = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            return vDBPath;
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
                    Console.WriteLine("### Abfrage der Ausgangssperren data------------{0}");
                    
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

