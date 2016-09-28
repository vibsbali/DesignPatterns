namespace DesignPatterns.Strategy
{
    public class FedexShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShipping(Order order)
        {
            //Afer some complex logicr
            return 4.00m;
        }
    }
}