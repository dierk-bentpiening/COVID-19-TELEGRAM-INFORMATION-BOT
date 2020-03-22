using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid19bot
{
    public class Statistics
    {
        public static void newQueryLog(string vChatID, string vDateTime, string vQueryType)
        {
   
            
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
            connection.Open();

            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO statistics (ID, CHATID, DATETIME, QUERRYTYPE) VALUES (NULL, $chatid, $datetime, $querrytype)", connection);
            insertSQL.Parameters.Add("$chatid", System.Data.DbType.String).Value = vChatID;
            insertSQL.Parameters.Add("$datetime", System.Data.DbType.String).Value = vDateTime;
            insertSQL.Parameters.Add("$querrytype", System.Data.DbType.String).Value = vQueryType;
            try
            {
                insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
