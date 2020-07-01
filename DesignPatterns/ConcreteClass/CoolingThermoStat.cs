using DesignPatterns.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ConcreteClass
{
    public class CoolingThermoStat : IThermoStat
    {
        private readonly double _temp;
        public CoolingThermoStat(double temp)
        {
            _temp = temp;
        }
        public void Control()
        {
            Console.WriteLine($"Cooling the house {_temp} degrees");
        }
    }
}
