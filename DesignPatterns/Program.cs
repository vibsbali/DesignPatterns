using System;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.ShippingSelector;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            //Note we no longer have to set the shipping type in Order
            var shippingMethodSelected = ShippingMethods.Fedex;
            var shippingMethod = new AllShippingMethods().GetShippingMethods(shippingMethodSelected);

            Console.WriteLine(new Checkout(order).CalculateShipping(shippingMethod));
        }
    }
}
