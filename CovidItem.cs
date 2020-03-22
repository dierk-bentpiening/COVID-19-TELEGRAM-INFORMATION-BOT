using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid19bot
{
    class CovidItem
    {
     
        public CovidItem(string name, string url)
        {
            Name = name;
        }
      
        public string Name { get; set; }
    }
}
