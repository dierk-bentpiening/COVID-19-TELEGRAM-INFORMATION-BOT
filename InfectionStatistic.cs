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
