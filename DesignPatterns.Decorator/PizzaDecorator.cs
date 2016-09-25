namespace DesignPatterns.Decorator
{
    public class PizzaDecorator : AbstractPizza
    {
        public PizzaDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
        }

        public AbstractPizza Pizza { get; private set; }

        public override string GetDescription()
        {
            return Pizza.GetDescription();
        }

        public override decimal CalculatePrice()
        {
            return Pizza.CalculatePrice();
        }
    }
}