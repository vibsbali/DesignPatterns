namespace DesignPatterns.Strategy
{
    public class Checkout
    {
        private readonly Order order;

        public Checkout(Order order)
        {
            this.order = order;
        }

        public decimal CalculateShipping()
        {
            if (order.ShippingMethod == "Fedex")
            {
                //after some complex logic
                return 4.00m;
            }

            if (order.ShippingMethod == "Ups")
            {
                //after some complex logic
                return 3.00m;
            }

            return 2.00m;
        }
    }

    public class Order
    {
        public string ShippingMethod { get; set; }
    }
}
