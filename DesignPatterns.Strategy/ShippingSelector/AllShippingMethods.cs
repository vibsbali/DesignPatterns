using System.Collections.Generic;

namespace DesignPatterns.Strategy.ShippingSelector
{
    public class AllShippingMethods
    {
        private IDictionary<ShippingMethods, IShippingStrategy> AvailableShippingMethods { get; }

        public AllShippingMethods()
        {
            AvailableShippingMethods = new Dictionary<ShippingMethods, IShippingStrategy>
            {
                {ShippingMethods.Post, new GenericShippingStrategy()},
                {ShippingMethods.UPS, new UpsShippingStrategy()},
                {ShippingMethods.Fedex, new FedexShippingStrategy()}
            };
        }

        public IShippingStrategy GetShippingMethods(ShippingMethods shippingMethod)
        {
            return AvailableShippingMethods[shippingMethod];
        }
    }
}