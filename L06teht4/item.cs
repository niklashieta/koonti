using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06teht4
{
    class item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public item() { }
        public item(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}