using System;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.ShippingMethod = "UPS";

            var shippingMethod = new FedexShippingStrategy();

            Console.WriteLine(new Checkout(order).CalculateShipping(shippingMethod));
        }
    }
}
