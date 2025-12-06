using DesignPatternsSOLID_OOPInCSharp.SOLID.L.Bad;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.L.Good
{
    public class Square : Shape
    {
  
        public double SideLength { get; set; }

        public override double Area => SideLength * SideLength;
    }
}
