using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid19bot
{
    public class InfectionStatistic
    {
        public static void writeInfetctionNumbers(string vInfectionCount, string vDeath, string vRecovered, string vTimeDateDataSource, string vDateCrawlTimeDate) 
        {

            SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
            connection.Open();

            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO InfektionStatistics (ID, INFECTIONCOUNT, DEATH, RECOVERED, TIMEDATEDATASOURCE, CRAWLTIMEDATE) VALUES (NULL, $INFECTIONCOUNT, $DEATH, $RECOVERED, $TIMEDATEDATASOURCE, $CRAWLTIMEDATE)", connection);
            insertSQL.Parameters.Add("$INFECTIONCOUNT", System.Data.DbType.String).Value = vInfectionCount;
            insertSQL.Parameters.Add("$DEATH", System.Data.DbType.String).Value = vDeath;
            insertSQL.Parameters.Add("$RECOVERED", System.Data.DbType.String).Value = vRecovered;
            insertSQL.Parameters.Add("$TIMEDATEDATASOURCE", System.Data.DbType.String).Value = vTimeDateDataSource;
            insertSQL.Parameters.Add("$CRAWLTIMEDATE", System.Data.DbType.String).Value = vDateCrawlTimeDate;
            Console.WriteLine("### WRITTEN INFECTION DATA IN DB");
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
