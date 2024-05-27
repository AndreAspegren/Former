using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Former
{
    internal class Rektangel : Former
    {
        public double _width { get; set; }
        public double _height { get; set; }

        public Rektangel(string name, string color, double width, double height) : base(name, color)
        {
            _width = width;
            _height = height;
        }

        public override double calculateArea()
        {
            return _width * _height;
        }
    }
}
