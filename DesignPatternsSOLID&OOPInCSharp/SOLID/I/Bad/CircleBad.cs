using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.I.Bad
{
    internal class CircleBad : IShapeBad
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        // This method is not applicable to Circle, thus violating the Interface Segregation Principle
        // by forcing CircleBad to implement a method it doesn't need.
        // In a better design, CircleBad would implement an interface that only includes the Area method.
        // For example, we could have an I2DShape interface with just the Area method.
        // Here, we throw a NotImplementedException to indicate that this method is not supported.
        // This is a code smell and indicates a design issue.
        // A better approach would be to refactor the interfaces to avoid such situations.
        // 2d shapes should not be forced to implement 3d shape methods.

        public double Volume()
        {
            throw new InvalidOperationException("volume na on a 2d shape");
        }
    }
}
