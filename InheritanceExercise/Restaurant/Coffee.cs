using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
   public  class Coffee : HotBeverage
    {
        private const double coffeeMililiters = 50;
        private const decimal coffeePrice = 3.5M;
        public double Caffeine { get; set; }
        public Coffee(string name , double caffeine)
            :base(name,coffeePrice,coffeeMililiters)
        {
            Caffeine = caffeine;
        }
    }
}
