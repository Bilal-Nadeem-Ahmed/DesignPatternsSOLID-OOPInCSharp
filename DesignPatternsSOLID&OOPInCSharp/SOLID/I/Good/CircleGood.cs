using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.I.Good
{
    internal class CircleGood: IShape2d
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
