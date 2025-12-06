using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Composition
{
    internal class Car
    {
        private Engine engine = new Engine();
        private Wheels wheels = new Wheels();
        private Chassis chassis = new Chassis();
        private Seats seats = new Seats();


        public void StartCar()
        {
            chassis.Support();
            engine.Start();
            wheels.Rotate();
            seats.Sit();
            Console.WriteLine("Car has started and is ready to go!");
        }   

    }
}
