using DesignPatterns.Enums;
using System;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var coolingThermostat = new ThermoStat().ExecuteCreate(Actions.Cooling, 17.5);
            coolingThermostat.Control();
            coolingThermostat = new ThermoStat().ExecuteCreate(Actions.Warming , 21.5);
            coolingThermostat.Control();
            Console.ReadKey();
        }
    }
}
