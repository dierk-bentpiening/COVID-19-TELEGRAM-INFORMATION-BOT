using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium;
using System.Drawing.Imaging;
using System.Windows.Forms;
using IronOcr;

namespace Data_Statistic_and_Analysis_Tool
{
    class jhuDataExtraktion
    {
        public static void startExtract()
        {
            String vDateTime = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
            String vDateiName = "jhuwwi-" + vDateTime + ".png";
            IWebDriver driver = new PhantomJSDriver();
            driver.Navigate().GoToUrl("https://www.arcgis.com/apps/opsdashboard/index.html#/5c7f096096ed482395f6a626150366e2");
            System.Threading.Thread.Sleep(20000);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(vDateiName, ImageFormat.Png);
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + ConfigLoader.vDBPATH());
            connection.Open();
            var Ocr = new AdvancedOcr()
            {
                CleanBackgroundNoise = true,
                EnhanceContrast = true,
                EnhanceResolution = true,
                Language = IronOcr.Languages.English.OcrLanguagePack,
                Strategy = IronOcr.AdvancedOcr.OcrStrategy.Advanced,
                ColorSpace = AdvancedOcr.OcrColorSpace.Color,
                DetectWhiteTextOnDarkBackgrounds = true,
                InputImageType = AdvancedOcr.InputTypes.Document,
                RotateAndStraighten = true,
                ReadBarCodes = true,
                ColorDepth = 4
            };
            Console.WriteLine(vDateiName);
            var vOcrResult = Ocr.Read(vDateiName);
            string vInfectionWordlwide = vOcrResult.ToString();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO InfectionWorldwide (ID, ImagePath, DateTime, OCRText) VALUES (NULL, $ImagePath, $DateTime, $OCRText)", connection);
            insertSQL.Parameters.Add("$ImagePath", System.Data.DbType.String).Value = vDateiName;
            insertSQL.Parameters.Add("$DateTime", System.Data.DbType.String).Value = vDateTime;
            insertSQL.Parameters.Add("$OCRText", System.Data.DbType.String).Value = vInfectionWordlwide;

            Console.WriteLine("### OCR Result: " + vInfectionWordlwide);
            Console.WriteLine("### WRITTEN AUSGANGSSPERRE DATA IN DB");
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
