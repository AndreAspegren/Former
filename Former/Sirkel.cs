﻿using System;
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
            return _radius * 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482;
        }
    }
}
