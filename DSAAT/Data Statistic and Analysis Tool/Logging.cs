using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Statistic_and_Analysis_Tool
{
    public 
    class Logging
    {
        public static void WriteLog(String vLogMessage)
        {
            try
            {
                CreateDirectory.createDir("DSAAT-Logs");
            }
            catch (Exception ex)
            {
                Console.WriteLine("### ERROR FAILED TO CREATE LOG DIRECTORY");
            }
            
            string vDateTime = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");

            string path = "DSAAT-Logs\\dsaatlog.dlog";

            bool done = false;

            while (!done)
            {
                done = true;

                try
                {
                    FileStream fileStream = null;
                    fileStream = File.Open(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);

                    using (StreamWriter fs = new StreamWriter(fileStream))
                    {
                        fs.WriteLine(vDateTime + " : " + vLogMessage);
                    };
                    fileStream.Close();
                }
                catch (IOException)
                {
                    done = false;

                }

            }
        }

    }
}
