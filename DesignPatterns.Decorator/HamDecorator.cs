namespace DesignPatterns.Decorator
{
    public class HamDecorator : PizzaDecorator
    {

        public HamDecorator(AbstractPizza pizza) : base(pizza)
        {
        }

        public override decimal CalculatePrice()
        {
            return base.CalculatePrice() + 3;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Ham";
        }
    }
}