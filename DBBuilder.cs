using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace Data_Statistic_and_Analysis_Tool
{
    class DBBuilder
    {
        public static void buildDB()
        {
            //Console.WriteLine("### LESE AKTUELLEN DBPATH AUS CONFIG DATEI EIN.");
            string vBuffer = System.IO.File.ReadAllText(@"C:\cbot.cfg");
            String[] seperator = { ";" };
            Int32 count = 6;
            String[] vDBALLBUFFER = vBuffer.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            String vDataBuffer = vDBALLBUFFER[0].ToString();
            String pathCorrected = Regex.Replace(vDataBuffer, "\\", "\\\\");
            SQLiteConnection.CreateFile(pathCorrected);
            var connectionDb = new SQLiteConnection($"URI=file:{pathCorrected}");
            connectionDb.Open();
            var dbComm = new SQLiteCommand(connectionDb);

            try
            {
                dbComm.CommandText = "CREATE TABLE AusgangssperrenLK ([ID] INTEGER NOT NULL PRIMARY KEY, [LKN] text not null, [VON] numeric not null, [BIS] numeric not null, [Bundesland] text not null, [BEHÖRDE] text, [PLZ] numeric)";
                dbComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Bei der Erstellung der Tabelle ist folgender Fehler aufgetreten: " + e.Message);
            }

            try
            {
                dbComm.CommandText = "CREATE TABLE Einreiseverbote ([ID] INTEGER NOT NULL PRIMARY KEY, [Nation] INTEGER, [VON] numeric not null, [BIS] INTEGER not null)";
                dbComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Bei der Erstellung der Tabelle ist folgender Fehler aufgetreten: " + e.Message);
            }

            try
            {
                dbComm.CommandText = "CREATE TABLE InfektionStatistics ([ID] INTEGER NOT NULL PRIMARY KEY, [INFEKTIONCOUNT] text not null, [TIMEDATEDATASOURCE] text not null, [CRAWLTIMEDATE] text not null, [DEATH] text not null, [RECOVERED] text not null)";
                dbComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Bei der Erstellung der Tabelle ist folgender Fehler aufgetreten: " + e.Message);
            }

            try
            {
                dbComm.CommandText = "CREATE TABLE PMESSAGES ([ID] INTEGER NOT NULL PRIMARY KEY, [MESSAGE] text not null)";
                dbComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Bei der Erstellung der Tabelle ist folgender Fehler aufgetreten: " + e.Message);
            }

            try
            {
                dbComm.CommandText = "CREATE TABLE URLLIST ([ID] INTEGER NOT NULL PRIMARY KEY, [URL] text not null)";
                dbComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Bei der Erstellung der Tabelle ist folgender Fehler aufgetreten: " + e.Message);
            }

            try
            {
                dbComm.CommandText = "CREATE TABLE statistics ([ID] INTEGER NOT NULL PRIMARY KEY, [CHATID] text not null, [QUERRYTYPE] text not null, [DATETIME] text not null)";
                dbComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Bei der Erstellung der Tabelle ist folgender Fehler aufgetreten: " + e.Message);
            }

            try
            {
                dbComm.CommandText = "CREATE TABLE InfectionWorldwide ([ID] INTEGER NOT NULL PRIMARY KEY, [IMAGEPATH] text not null, [DATETIME] numeric not null, [OCRText] text not null)";
                dbComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Bei der Erstellung der Tabelle ist folgender Fehler aufgetreten: " + e.Message);
            }






        }
    }
}
