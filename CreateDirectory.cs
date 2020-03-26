using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Statistic_and_Analysis_Tool
{
    class CreateDirectory
    {
        public static void createDir(string path)
        {
            // ... Set to folder path we must ensure exists.
            try
            {
                Console.WriteLine("### CHECK IF DIRECTORY EXIST");
                // ... If the directory doesn't exist, create it.
                if (!Directory.Exists(path))
                {
                    Console.WriteLine("### CREATING DIRECTORY");
                    Directory.CreateDirectory(path);
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("#### ERROR: Failed to create directory");
            }
        }

    }
}
