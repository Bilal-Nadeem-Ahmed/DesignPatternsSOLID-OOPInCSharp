using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.D.Bad
{
    internal class Car
    {
        private Engine engine;
        public Car()
        {
            // tight coupling with car and engine class
            // if engine class changes we need to change car class too
            // this violates the dependency inversion principle
            engine = new Engine();
        }
        public void Start()
        {
            engine.Start();
            Console.WriteLine("Car started.");
        }
    }
}
