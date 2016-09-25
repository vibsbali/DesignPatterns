using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            //Note we no longer have to set the shipping type in Order
            var shippingMethod = new FedexShippingStrategy();

            Console.WriteLine(new Checkout(order).CalculateShipping(shippingMethod));
        }
    }
}
