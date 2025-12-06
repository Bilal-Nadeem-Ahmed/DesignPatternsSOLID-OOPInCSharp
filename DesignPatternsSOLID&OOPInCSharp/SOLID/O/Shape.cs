using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.O
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        //public ShapeType Type { get; set; }
        //public double Radius { get; set; }
        //public double Width { get; set; }
        //public double Length { get; set; }

        //public double CalculateArea()
        //{
        //    switch (Type)
        //    {
        //        case ShapeType.Crircle:
        //            return Math.PI * Math.Pow(Radius,2);
        //        case ShapeType.Rectangle:
        //            return Width * Length;
        //        default:
        //            throw new NotSupportedException("Shape type not supported for area calculation.");
        //    }
        //}

        // having the above here is a violation of OCP
        // because every time we add a new shape type,
        // we have to modify this class.
        // To adhere to OCP, we should create separate classes for each shape type
        // that implement a common interface for area calculation.
        // This way, we can add new shapes without modifying existing code.

        // after the refactor we have created multiple classes inheriting from Shape
        // and each class implements its own CalculateArea method.
        // This adheres to OCP as we can add new shapes by creating new classes
        // without modifying the existing Shape class.
        // For example, we have Circle and Rectangle classes that inherit from Shape
        // and implement their own CalculateArea methods.
        // This way, we can easily add new shapes in the future
        // without changing the existing codebase.
        // This makes the code more maintainable and extensible.
        // This is the essence of the Open/Closed Principle.
        // OCP states that software entities (classes, modules, functions, etc.)
        // should be open for extension but closed for modification.
        // By following this principle, we can create a more robust and flexible codebase
        // that can adapt to changing requirements without introducing bugs or breaking existing functionality.
        // This is a key aspect of SOLID principles in object-oriented design.


    }
}
