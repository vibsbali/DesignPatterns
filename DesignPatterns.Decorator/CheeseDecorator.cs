namespace DesignPatterns.Decorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(AbstractPizza pizza) : base(pizza)
        {
        }

        public override decimal CalculatePrice()
        {
            return base.CalculatePrice() + 2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Cheese";
        }
    }
}