using DesignPatterns.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public abstract class ThermoStatFactory
    {
        public abstract IThermoStat Create(double temp);       
    }
}
