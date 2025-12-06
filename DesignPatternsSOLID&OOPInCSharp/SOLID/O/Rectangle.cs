using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.O
{
    internal class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }
      
        public override double CalculateArea()
        {
            return Width * Length;
        }
    }
}
