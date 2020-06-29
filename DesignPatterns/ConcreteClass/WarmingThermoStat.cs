using DesignPatterns.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ConcreteClass
{
    public class WarmingThermoStat : IThermoStat
    {
        private readonly double _temp;
        public WarmingThermoStat(double temp)
        {
            _temp = temp;
        }

        public void Control()
        {
            Console.WriteLine("Warming the house to {_temp} degrees");
        }
    }
}
