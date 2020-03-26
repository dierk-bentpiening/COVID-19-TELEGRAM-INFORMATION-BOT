using System;
using System.Collections.Generic;
using System.Data.SQLite;
using OpenQA.Selenium.PhantomJS;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.IO;

namespace Data_Statistic_and_Analysis_Tool
{
    class jhuDataExtraktion
    {
        public static async void startExtractAsync()
        {
         
            Debug.AllocConsole();
            Console.WriteLine("-- DSAAT Data Extraction Engine --\n(C) 2020 Dierk-Bent Piening, Roman Spies\nAll rights reserved\nLicensed under the MIT License\nThis Engine is using Selenium PhantomJS\n");
            Console.WriteLine("### STARTING EXTRACTION PROCESS ###");
            CreateDirectory.createDir("images");
            String vDateTime = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
            String vFileNameBuffer = vDateTime + ".png";
            String vDateiName = "images\\jhuwwi-" + vFileNameBuffer;
            String vURL = ConfigLoader.vPUBLICURL() + vFileNameBuffer;
            //Als Backup im Code:

           //IWebDriver driver = new PhantomJSDriver();
            //driver.Navigate().GoToUrl("https://gisanddata.maps.arcgis.com/apps/opsdashboard/index.html#/bda7594740fd40299423467b48e9ecf6");
            //System.Threading.Thread.Sleep(20000);
            //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(vDateiName, ImageFormat.Png);
            var driverService = PhantomJSDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driverService.LoadImages = true;
            driverService.ProxyType = "none";

            using (var driver = new PhantomJSDriver(driverService))
            {
                driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
                driver.Url = "https://www.arcgis.com/apps/opsdashboard/index.html#/5c7f096096ed482395f6a626150366e2";
                System.Threading.Thread.Sleep(25000);
                driver.GetScreenshot().SaveAsFile(vDateiName, System.Drawing.Imaging.ImageFormat.Png);
            }

            try

            {

                // FTP UPLOAD FUNCTION
                String sourcefilepath = vDateiName; // e.g. “d:/test.docx”
                String ftpurl = ConfigLoader.vFTPURI() + "/" + vFileNameBuffer; // e.g. ftp://serverip/foldername/foldername
                String ftpusername = ConfigLoader.vFTPUSERNAME();
                String ftppassword = ConfigLoader.vFTPPASSWORD();
                string filename = Path.GetFileName(vDateiName);
                string ftpfullpath = ftpurl;
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential(ftpusername, ftppassword);

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                FileStream fs = File.OpenRead(vDateiName);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                Stream ftpstream = ftp.GetRequestStream();
                ftpstream.Write(buffer, 0, buffer.Length);
                ftpstream.Close();
                Console.WriteLine("### UPLOADED: " + vFileNameBuffer + " to: " + ftpurl);


               // using (WebClient webClient = new WebClient())
               // {
               //     webClient.Credentials = new NetworkCredential(ConfigLoader.vFTPUSERNAME(), ConfigLoader.vFTPPASSWORD());
               //     await webClient.UploadFileTaskAsync(ConfigLoader.vFTPURI(), WebRequestMethods.Ftp.UploadFile, vDateiName);
               // }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
            connection.Open();
            
            Console.WriteLine("### SAVING IMAGE FILE AS: " + vDateiName);
            //var text = Tesseract.Helper.UtliTesseract.GetCaptchaStringFromImage(vDateiName);
            //Console.WriteLine(text.ToString());
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO InfectionWorldwide (ID, ImagePath, DateTime, OCRText) VALUES (NULL, $ImagePath, $DateTime, $OCRText)", connection);
            insertSQL.Parameters.Add("$ImagePath", System.Data.DbType.String).Value = vURL;
            insertSQL.Parameters.Add("$DateTime", System.Data.DbType.String).Value = vDateTime;
            insertSQL.Parameters.Add("$OCRText", System.Data.DbType.String).Value = "No Info Gathered";
            Console.WriteLine("### OCR Result: " + "NO INFO GATHERED");
            Console.WriteLine("### WRITTEN OCR DATA IN DATABASE");
            try
            {
                insertSQL.ExecuteNonQuery();
                MessageBox.Show(" Daten in Datenbank geschrieben!", "Abgeschlossen",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten!", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);

            }
        }
    }
}
