using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Polymorphism
{
    public class Vehicle
    {
        public string Brand {  get; set; }
        public string Model {  get; set; }
        public int Year {  get; set; }
        public virtual void Start()
        {
            Console.WriteLine("vehicle is starting");
        }
        public virtual void Stop()
        {
            Console.WriteLine("vehicle is stopping");
        }
    }
}
