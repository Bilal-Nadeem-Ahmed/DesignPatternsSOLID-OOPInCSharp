using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting");
        }
        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping");
        }
    }
}
