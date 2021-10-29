using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
   public  class Vehicle
    {
        public double DefaultFuelConsumption { get; set; } 
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double  FuelConsumption { get; set; }
        public Vehicle(int horsePower , double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
            DefaultFuelConsumption = 1.25;
        }

        public virtual void Drive(double km)
        {
            Fuel -= DefaultFuelConsumption * km;
        }
    }
}
