using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.D.Good
{
    internal class CarGood
    {
        private readonly IEngineGood _engine;
        public CarGood(IEngineGood engine)
        {
            _engine = engine;
            // now car class depends on IEngineGood abstraction
            // if EngineGood class changes we don't need to change car class
        }

        public void Start()
        {
            _engine.Start();
            Console.WriteLine("Car started.");
        }
    }
}
