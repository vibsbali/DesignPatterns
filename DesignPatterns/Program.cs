using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Decorator;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.ShippingMethod = "UPS";

            Console.WriteLine(new Checkout(order).CalculateShipping());
        }
    }
}
