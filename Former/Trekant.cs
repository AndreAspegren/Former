using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Former
{
    internal class Trekant : Former
    {
        public double _base { get; set; }
        public double _height { get; set; }

        public Trekant(string name, string color, double @base, double height) : base(name, color)
        {
            _base = @base;
            _height = height;
        }

        public override double calculateArea()
        {
            return _base * _height / 2;
        }
    }
}
