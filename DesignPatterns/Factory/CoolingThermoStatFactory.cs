using DesignPatterns.ConcreteClass;
using DesignPatterns.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public abstract class CoolingThermoStatFactory : ThermoStatFactory
    {
        public override IThermoStat Create(double temp) =>       
         new CoolingThermoStat(temp);      
    }
}
