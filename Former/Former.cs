using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Former
{
    public abstract class Former
    {
        public string _name { get; set; }
        public string _color { get; set; }

        public Former(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public abstract double calculateArea();
    }
}
