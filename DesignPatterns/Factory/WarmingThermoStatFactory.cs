using DesignPatterns.ConcreteClass;
using DesignPatterns.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class WarmingThermoStatFactory : ThermoStatFactory
    {
        public override IThermoStat Create(double temp) =>
            new WarmingThermoStat(temp);        
    }
}
