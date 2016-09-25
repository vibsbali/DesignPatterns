namespace DesignPatterns.Strategy
{
    public class GenericShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShipping(Order order)
        {
            //Afer some complex logicr
            return 2.00m;
        }
    }
}