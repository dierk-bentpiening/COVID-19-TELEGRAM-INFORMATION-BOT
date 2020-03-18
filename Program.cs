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

namespace ShareX_Main_Server
{
    class Program
    {
        static ITelegramBotClient botClient;
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("922905799:AAEWiaIlJLx8Y356Hcf3FdOEAdLyTsp47bM");

            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(" " +
                "");
            Console.WriteLine(
              $"COVID-19 TELEGRAM INFROMATION SYSTEM \n(C) 2020 Dierk-Bent Piening\nVersion 0.2A\nAll rights reserved"
            );

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);

        }
        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            String dbpath = "C:\\CISB.sqlite3";
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbpath);
            String[] seperator = { " " };
            Int32 count = 2;
            String[] cmdlist = e.Message.Text.Split(seperator, count, StringSplitOptions.RemoveEmptyEntries);
            if (e.Message.Text != null || cmdlist[0] != null)
            {

                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");


                if (cmdlist[0] == "i" || cmdlist[0] == "info" || cmdlist[0] == "Info")
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
                                        Console.WriteLine("data------------{0}", JObject.Parse(data)["current_totals"]["cases"]);

                                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "COVID-19 Information Bot by Dierk-Bent Piening \n_____ Aktuelle Daten _____\n" + "Fälle: " + JObject.Parse(data)["current_totals"]["cases"] + " \nTodesfälle:" + JObject.Parse(data)["current_totals"]["deaths"] + "\nGeheilt: " + JObject.Parse(data)["current_totals"]["recovered"] + "\nZeitpunkt: " + JObject.Parse(data)["meta"]["time_source_last_updated_iso8601"] + "\nQuelle: " + JObject.Parse(data)["meta"]["source"]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("NO Data----------");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Exception Hit------------");
                        Console.WriteLine(exception);
                    }

                }
                else if (cmdlist[0] == "BL" || cmdlist[0] == "bl" || cmdlist[0] == "Bundesländer" || cmdlist[0] == "Bl")
                {
                    Telegram.Bot.Types.Message message = await botClient.SendPhotoAsync(
                    chatId: e.Message.Chat,
                    photo: "https://bilder.bild.de/fotos-skaliert/aktuelle-faelle-coronavirus-covid-19-in-deutschland-kartemap--infografik-69071094/1322,w=993,q=high,c=0.bild.gif",
                    caption: "<b>COVID-19 NACH BUNDESLÄNDERN</b>. <i>Source</i>: <a href=\"https://www.bild.de/ratgeber/2020/ratgeber/aktuelle-zahlen-zum-coronavirus-in-deutschland-69349102.bild.html\">Axel Springer SE BILD</a>", parseMode: Telegram.Bot.Types.Enums.ParseMode.Html
                      );
                }
                else if (e.Message.Text == "Ausgangssperre alle" || e.Message.Text == "ausgangssperre alle")
                {
                 
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from AusgangssperrenLK", connection);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            string vLK = reader.GetString(reader.GetOrdinal("LKN"));
                            string vBUNDESLAND = reader.GetString(reader.GetOrdinal("BUNDESLAND"));
                            string vDatumVON = reader.GetString(reader.GetOrdinal("VON"));
                            string vDatumBIS = reader.GetString(reader.GetOrdinal("BIS"));
                            string vBEHÖRDE = reader.GetString(reader.GetOrdinal("BEHÖRDE"));
                            int vPLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                            await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Ausgangsperre im Landkreis: " + vLK + " im Bundesland: " + vBUNDESLAND + " verhängt durch: " + vBEHÖRDE + "\n Gültig von:" + vDatumVON + " bis: " + vDatumBIS);
                        }
                    connection.Close();

                }
                else if (cmdlist[0] == "Ausgangssperre" || cmdlist[0] == "ausgangssperre" || cmdlist[0] == "ausgangssperren")
                {
             
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from AusgangssperrenLK where PLZ = " + cmdlist[1], connection);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            string vLK = reader.GetString(reader.GetOrdinal("LKN"));
                            string vBUNDESLAND = reader.GetString(reader.GetOrdinal("BUNDESLAND"));
                            string vDatumVON = reader.GetString(reader.GetOrdinal("VON"));
                            string vDatumBIS = reader.GetString(reader.GetOrdinal("BIS"));
                            string vBEHÖRDE = reader.GetString(reader.GetOrdinal("BEHÖRDE"));
                            int vPLZ = reader.GetInt32(reader.GetOrdinal("PLZ"));
                            await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Ausgangsperre im Landkreis: " + vLK + " im Bundesland: " + vBUNDESLAND + " verhängt durch: " + vBEHÖRDE + "\n Gültig von:" + vDatumVON + " bis: " + vDatumBIS);
                        }
                    else
                    {
                        await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "Für die PLZ: " + cmdlist[1] + " ist uns keine Ausgangssperre bekannt!");
                    }
                    connection.Close();

                }


                else
                {
                  
                    
                    await botClient.SendTextMessageAsync(chatId: e.Message.Chat, text: "_____ACHTUNG:_____\nGib info oder Info oder i ein um die Daten zu erhalten.\nUm die aktuellen Zahlen der Bundesländer zu erhalten gebe BL oder bl oder Bundesländer ein\n Ausgangssperre alle oder ausgangssperre alle zeigt dir alle geltenden Ausgangssperren an\n Ausgangssperre 26427 zeigt dir an ob eine Ausgangssperre für deinen PLZ Bereich vorliegt z.B: 26427");
            }
            }
        }

       

    }
}
