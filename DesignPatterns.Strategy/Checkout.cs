namespace DesignPatterns.Strategy
{
    public class Checkout
    {
        private readonly Order order;

        public Checkout(Order order)
        {
            this.order = order;
        }

        //In theory Chekout class should take an instance of IShippingStrategy instead of Order
        //And our CalculateShipping method should take Order as a parameter
        //This is all that is left after strategy. No more if else block
        public decimal CalculateShipping(IShippingStrategy shippingMethod)
        {
            return shippingMethod.CalculateShipping(order);
        }
    }
}
