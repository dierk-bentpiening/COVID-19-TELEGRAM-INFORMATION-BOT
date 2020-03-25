using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Statistic_and_Analysis_Tool
{
    class StartBot
    {
        public static void startingBot()
        {
            using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
            {
                String vRuntimePath = "CITBS/COVID-19 Information BOT.exe";
                pProcess.StartInfo.FileName = vRuntimePath;
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                pProcess.StartInfo.CreateNoWindow = false; //not diplay a windows
                pProcess.Start();
                string output = pProcess.StandardOutput.ReadToEnd(); //The output result
            }
        }
    }
}
