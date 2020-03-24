using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Statistic_and_Analysis_Tool
{
    class Interpreter
    {
        public static void Shell()
        {
            Debug.AllocConsole();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("DSAAT Interpreter v. 1.0\n (C) 2020 Dierk-Bent Piening, Roman Spies\n__________________________________________________");
            String inputBuffer = "";
            while(true)
            {
                Console.Write("DSAAT> ");
                inputBuffer = Console.ReadLine();
            }


        }
    }
}
