using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.I.Bad
{
    internal class SphereBad: IShapeBad
    {
        public double Radius { get; set; }
        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }
        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
    
}
