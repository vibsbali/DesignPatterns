namespace DesignPatterns.Strategy
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShipping(Order order)
        {
            //Afer some complex logicr
            return 3.00m;
        }
    }
}