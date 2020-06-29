using DesignPatterns.Enums;
using DesignPatterns.Factory;
using DesignPatterns.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class ThermoStat
    {
        // public Actions Actions = new Actions();
       // int[] enumValues = new int[] { 0, 1, 3, 5 };
        private readonly Dictionary<Actions, ThermoStatFactory> _factories;
        public ThermoStat() 
        {
            _factories = new Dictionary<Actions, ThermoStatFactory>();
            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                 //var a = Enum.GetName(typeof(Actions), action);
                
                 var factory = (ThermoStatFactory)Activator.CreateInstance(Type.GetType("DesignPatterns." + Enum.GetName(typeof(Actions),action) + "ThermoStatFactory"));
                //var factory = Activator.CreateInstance(Type.GetType(a)) as ThermoStatFactory;
                _factories.Add(action, factory);
            }
        }

        public IThermoStat ExecuteCreate(Actions action, double temp) =>
            _factories[action].Create(temp);
    }
}
