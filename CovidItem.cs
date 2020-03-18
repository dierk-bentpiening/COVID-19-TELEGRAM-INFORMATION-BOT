using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareX_Main_Server
{
    class CovidItem
    {
        //Define the constructor of your PokeItem which is the same name as class, and is not returning anything.
        //Will take a string name, and url as a argument.
        public CovidItem(string name, string url)
        {
            Name = name;
        }
        //Your Properties are auto-implemented.
        public string Name { get; set; }
    }
}
