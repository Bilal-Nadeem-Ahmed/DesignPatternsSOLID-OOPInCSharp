using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.L.Bad
{
    internal class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; } 
        public override double Area => Width * Height;
    }
}
