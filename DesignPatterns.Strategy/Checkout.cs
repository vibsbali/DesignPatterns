namespace DesignPatterns.Strategy
{
    public class Checkout
    {
        private readonly Order order;

        public Checkout(Order order)
        {
            this.order = order;
        }

        //This is all that is left after strategy. No more if else block
        public decimal CalculateShipping(IShippingStrategy shippingMethod)
        {
            return shippingMethod.CalculateShipping(order);
        }
    }
}
