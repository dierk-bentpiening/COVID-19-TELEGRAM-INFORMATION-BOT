using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Statistic_and_Analysis_Tool
{
    class PublicMessages
    {
        public static string vPublicMessage()
        {
            string vMessage = "";
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from PMESSAGES ORDER BY rowid DESC LIMIT 1", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    vMessage = reader.GetString(reader.GetOrdinal("MESSAGE"));
                    Console.WriteLine("### Abfrage der PUBLIC-MESSAGES data------------{0}");

                }
                return vMessage;
                connection.Close();
            }
            else
            {
                return "nodata";
            }
        }
    }
}
