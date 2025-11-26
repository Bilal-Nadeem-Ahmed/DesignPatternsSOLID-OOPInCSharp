using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Polymorphism
{
    internal class Plane: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Plane is starting");
        }
        public override void Stop()
        {
            Console.WriteLine("Plane is stopping");
        }
    }
}
