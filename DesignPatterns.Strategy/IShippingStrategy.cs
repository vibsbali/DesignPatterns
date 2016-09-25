namespace DesignPatterns.Strategy
{
    public interface IShippingStrategy
    {
        decimal CalculateShipping(Order order);
    }
}