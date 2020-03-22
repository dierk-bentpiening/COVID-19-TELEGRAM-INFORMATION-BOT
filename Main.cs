using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using NLog.Fluent;
using covid19bot;

namespace covid19bot
{
    class Program
    {
        static ITelegramBotClient botClient;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            botClient = new TelegramBotClient("1048276961:AAEqjnUyZedMU4N4Vc962K7YqPaVlhRPI2Q");
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(" " +
                "");
            Console.WriteLine(
              $"COVID-19 TELEGRAM INFROMATION SYSTEM \n(C) 2020 Dierk-Bent Piening, Roman Spies\nVersion 0.2A\nAll rights reserved\nLicensed under the MIT License\n_____________________________________________________________________________\n"
            );
            
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);

        }
        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            string vADateTime = DateTime.Now.ToString();
            try {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
      
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
                String[] seperator = { " " };
                Int32 count = 3;
                String[] cmdlist = e.Message.Text.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("#### Datenbankverbindung aufgebaut------------{0}");
                if (e.Message.Text != null || cmdlist[0] != null)
                {

                    Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");


                    if (cmdlist[0] == "i" || cmdlist[0] == "info" || cmdlist[0] == "Info" || cmdlist[0] == "I")
                    {

                        //Define your baseUrl
                        string baseUrl = "https://covid19-germany.appspot.com/now";
                        //Have your using statements within a try/catch block
                        try
                        {
                            //We will now define your HttpClient with your first using statement which will implements a IDisposable interface.
                            using (HttpClient client = new HttpClient())
                            {
                                //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                                using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                                {
                                    //Then get the content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                                    using (HttpContent content = res.Content)
                                    {
                                        //Now assign your content to your data variable, by converting into a string using the await keyword.
                                        var data = await content.ReadAsStringAsync();
                                        //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                                        if (content != null)
                                        {
                                            //Now log your data object in the console
                                            Console.WriteLine("### Abfrage der Infektions Daten: data------------{0}", JObject.Parse(data)["current_totals"]["cases"]);

                                            await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: 
                                                "COVID-19 Information Bot\n CODE: Dierk-Bent Piening, MED-BERATUNG: Roman Spies \n_____ Aktuelle Daten _____\n" + "Fälle: " + JObject.Parse(data)["current_totals"]["cases"] + " \nTodesfälle:" + JObject.Parse(data)["current_totals"]["deaths"] + "\nGeheilt: " + JObject.Parse(data)["current_totals"]["recovered"] + "\nZeitpunkt: " + JObject.Parse(data)["meta"]["time_source_last_updated_iso8601"] + "\nQuelle: " + JObject.Parse(data)["meta"]["source"]);
                                            InfectionStatistic.writeInfetctionNumbers(JObject.Parse(data)["current_totals"]["cases"].ToString(), JObject.Parse(data)["current_totals"]["deaths"].ToString(), JObject.Parse(data)["current_totals"]["recovered"].ToString(), JObject.Parse(data)["meta"]["time_source_last_updated_iso8601"].ToString(), DateTime.Now.ToString());
                                            await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                                        }
                                        else
                                        {
                                            Console.WriteLine("NO Data----------");
                                        }
                                    }
                                }
                            }
                            Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AktuelleInfektionen");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine("Exception Hit------------");
                            Console.WriteLine(exception);
                        }

                    }
                    else if (cmdlist[0] == "BL" || cmdlist[0] == "bl" || cmdlist[0] == "Bundesländer" || cmdlist[0] == "Bl")
                    {
                        Console.WriteLine("### LESE AKTUELLEN LINK AUS CONFIG DATEI EIN.");
                        string url = ConfigLoader.vURL();
                        Telegram.Bot.Types.Message message = await botClient.SendPhotoAsync(
                        chatId: e.Message.Chat,
                        photo: url,
                        caption: "<b>COVID-19 NACH BUNDESLÄNDERN</b>. <i>Source</i>: <a href=\"https://www.bild.de/ratgeber/2020/ratgeber/aktuelle-zahlen-zum-coronavirus-in-deutschland-69349102.bild.html\">Axel Springer SE BILD</a>", parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                          );
                        Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AktuelleInfektionenNachBundesländern");
                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                    }
                    else if (e.Message.Text == "!Ausgangssperre alle!" || e.Message.Text == "!ausgangssperre alle!")
                    {

                        connection.Open();
                        SQLiteCommand cmd = new SQLiteCommand("select * from AusgangssperrenLK", connection);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string vLK = reader.GetString(reader.GetOrdinal("LKN"));
                                string vBUNDESLAND = reader.GetString(reader.GetOrdinal("BUNDESLAND"));
                                string vDatumVON = reader.GetString(reader.GetOrdinal("VON"));
                                string vDatumBIS = reader.GetString(reader.GetOrdinal("BIS"));
                                string vBEHÖRDE = reader.GetString(reader.GetOrdinal("BEHÖRDE"));
                                int vPLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Ausgangsperre im Landkreis: " + vLK + " im Bundesland: " + vBUNDESLAND + " verhängt durch: " + vBEHÖRDE + "\n Gültig von:" + vDatumVON + " bis: " + vDatumBIS);
                                Console.WriteLine("### Abfrage der Ausgangssperren data------------{0}");


                            }
                            Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AusgangssperrenALLE");
                            await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                        }
                        connection.Close();

                    }
                    else if (cmdlist[0] == "Ausgangssperre" || cmdlist[0] == "ausgangssperre" || cmdlist[0] == "ausgangssperren")
                    {
                        if (cmdlist[1] == "bundesland" || cmdlist[1] == "Bundesland" || cmdlist[1] == "bl" || cmdlist[1] == "BL" || cmdlist[1] == "Bl")
                        {
                            connection.Open();
                            SQLiteCommand cmd = new SQLiteCommand("select * from AusgangssperrenLK where upper(BUNDESLAND) = upper('" + cmdlist[2] +"')", connection);
                            SQLiteDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string vLK = reader.GetString(reader.GetOrdinal("LKN"));
                                    string vBUNDESLAND = reader.GetString(reader.GetOrdinal("BUNDESLAND"));
                                    string vDatumVON = reader.GetString(reader.GetOrdinal("VON"));
                                    string vDatumBIS = reader.GetString(reader.GetOrdinal("BIS"));
                                    string vBEHÖRDE = reader.GetString(reader.GetOrdinal("BEHÖRDE"));
                                    int vPLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                                    await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Ausgangsperre im Landkreis: " + vLK + " im Bundesland: " + vBUNDESLAND + " verhängt durch: " + vBEHÖRDE + "\n Gültig von:" + vDatumVON + " bis: " + vDatumBIS);
                                    Console.WriteLine("### Abfrage der Ausgangssperren nach Bundesland data------------{0}");

                                }
                                Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AusgangssperreNachBundesland: " + cmdlist[2]);
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                            }
                            else
                            {
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Für das Bundesland: " + cmdlist[2] + " ist uns keine Ausgangssperre bekannt!");
                                Console.WriteLine("### Abfrage der Ausgangssperren nach Bundesland data------------{0}");
                                Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AusgangssperreNachBundesland: Unbekannt");
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                            }
                            connection.Close();


                        }
                        else if (cmdlist[1] == "LK" || cmdlist[1] == "Landkreis" || cmdlist[1] == "landkreis" || cmdlist[1] == "Lk" || cmdlist[1] == "lk")
                        {
                            connection.Open();
                            SQLiteCommand cmd = new SQLiteCommand("select * from AusgangssperrenLK where upper(LKN) like upper('%" + cmdlist[2] + "')", connection);
                            SQLiteDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string vLK = reader.GetString(reader.GetOrdinal("LKN"));
                                    string vBUNDESLAND = reader.GetString(reader.GetOrdinal("BUNDESLAND"));
                                    string vDatumVON = reader.GetString(reader.GetOrdinal("VON"));
                                    string vDatumBIS = reader.GetString(reader.GetOrdinal("BIS"));
                                    string vBEHÖRDE = reader.GetString(reader.GetOrdinal("BEHÖRDE"));
                                    int vPLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                                    await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Ausgangsperre im Landkreis: " + vLK + " im Bundesland: " + vBUNDESLAND + " verhängt durch: " + vBEHÖRDE + "\n Gültig von:" + vDatumVON + " bis: " + vDatumBIS + " mit der PLZ: " + vPLZ);
                                    Console.WriteLine("### Abfrage der Ausgangssperren nach Landkreis data------------{0}");

                                }
                                Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AusgangssperreNachLK: " + cmdlist[2]);
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                            }
                            else
                            {
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Für den Landkreis: " + cmdlist[2] + " ist uns keine Ausgangssperre bekannt!");
                                Console.WriteLine("### Abfrage der Ausgangssperren nach Bundesland data------------{0}");
                                Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AusgangssperreNachBundesland Unbekannt");
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                            }
                            connection.Close();


                        }
                        else
                        {

                            connection.Open();
                            SQLiteCommand cmd = new SQLiteCommand("select * from AusgangssperrenLK where PLZ = " + cmdlist[1], connection);
                            SQLiteDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string vLK = reader.GetString(reader.GetOrdinal("LKN"));
                                    string vBUNDESLAND = reader.GetString(reader.GetOrdinal("BUNDESLAND"));
                                    string vDatumVON = reader.GetString(reader.GetOrdinal("VON"));
                                    string vDatumBIS = reader.GetString(reader.GetOrdinal("BIS"));
                                    string vBEHÖRDE = reader.GetString(reader.GetOrdinal("BEHÖRDE"));
                                    int vPLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                                    await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Ausgangsperre im Landkreis: " + vLK + " im Bundesland: " + vBUNDESLAND + " verhängt durch: " + vBEHÖRDE + "\n Gültig von:" + vDatumVON + " bis: " + vDatumBIS);
                                    Console.WriteLine("### Abfrage der Ausgangssperren data------------{0}");
                                    
                                }
                                Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AusgangssperreNachPLZ: " + cmdlist[1]);
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                            }
                            else
                            {
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Für die PLZ: " + cmdlist[1] + " ist uns keine Ausgangssperre bekannt!");
                                Console.WriteLine("### Abfrage der Ausgangssperren data------------{0}");
                                Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "AusgangssperreNachPLZ: Unbekannt");
                                await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                            }
                            connection.Close();

                        }
                    }

                    else if (cmdlist[0] == "symptome" || cmdlist[0] == "Symptome" || cmdlist[0] == "erkennen")
                    {
                        Telegram.Bot.Types.Message message = await botClient.SendPhotoAsync(
                       chatId: e.Message.Chat,
                       photo: "https://www.coronavirus.sachsen.de/Themenbilder/sms-schema-coronavirus-dpa_rdax_780x1214_87.jpg",
                       caption: "<b>COVID-19 SYMPTOME</b>. <i>Source</i>: <a href=\"https://www.coronavirus.sachsen.de/coronavirus-faq.html\">Robert Koch Institut</a>", parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                         );
                        Console.WriteLine("### Abfrage der Symptome data------------{0}");
                        Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "Symptome");
                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                    }

                    else if (cmdlist[0] == "tipps" || cmdlist[0] == "Hygiene" || cmdlist[0] == "hygiene" || cmdlist[0] == "wie schützen")
                    {
                        Telegram.Bot.Types.Message message = await botClient.SendPhotoAsync(
                       chatId: e.Message.Chat,
                       photo: "https://img.zeit.de/wissen/gesundheit/2020-02/corona-grafik-verhaltensregeln-zweiterteil/original__495x960__desktop",
                       caption: "<b>SO SCHÜTZEN SIE SICH!</b>. <i>Source</i>: <a href=\"https://www.zeit.de/wissen/gesundheit/2020-02/coronavirus-hygienetipps-ansteckung-infektion-schutz\">ZEIT.DE</a>", parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                         );
                        Console.WriteLine("### Abfrage der SchutzDaten: data------------{0}");
                        Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "Hygiene");
                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                    }
                    else if (cmdlist[0] == "hilfe" || cmdlist[0] == "Hilfe" || cmdlist[0] == "h" || cmdlist[0] == "H")
                    {
                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG:_____\nSollten Sie den Verdacht haben, sich mit COVID-19 infiziert zu haben, wenden Sie sich an die bundesweite Ärtzte-Hotline 116117.\nBleiben Sie zu Hause!");
                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                        Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "Hilfe");
                    }

                    else
                    {


                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG:_____\nGib info oder Info oder i ein, um die Daten zu erhalten.\nUm die aktuellen Zahlen der Bundesländer zu erhalten, gebe BL oder bl oder Bundesländer ein\nAusgangssperre 26427 zeigt Dir an, ob eine Ausgangssperre für Deinen PLZ Bereich vorliegt, z.B: 26427\n Ausgangssperre Landkreis Diepholz zeigt Dir an, ob eine Ausgangssperre für Deinen Landkreis, z.B. Diepholz vorliegt, z.B: 26427\nAusgangssperre BL Bayern oder Ausgangssperre Bundesland Bayern zeigt Dir die Ausgangssperren der Gemeinden im Land Bayern an\nGeben Sie tipps oder hygiene ein, um Hinweise zum Schutz vor einer Covid-19 Infektion zu erhalten.\nDurch die Eingabe von symptome, erhalten Sie eine Auflistung der bekannten COVID-19 Symptome");
                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG AKTUELLE HINWEISE____\n" + PublicMessages.vPublicMessage());

                        Console.WriteLine("### Abfrage aber unbekannter Befehl------------{0}");
                        Statistics.newQueryLog(e.Message.Chat.Id.ToString(), vADateTime, "Unbekannter Befehl ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("*-*-*-*-* Ein Fehler ist aufgetreten und wurde abgefangen------------{0}" + ex);

            }
       
    //throw new NotImplementedException();
}
        
       

    }
}
