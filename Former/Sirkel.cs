using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Former
{
    internal class Sirkel : Former
    {
        public double _radius { get; set; }

        public Sirkel(string name, string color, double radius) : base(name, color)
        {
            _radius = radius;
        }
        public override double calculateArea()
        {
            return _radius * 3.14;
        }
    }
}
