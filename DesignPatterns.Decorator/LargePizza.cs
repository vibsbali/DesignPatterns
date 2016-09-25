namespace DesignPatterns.Decorator
{
    public class LargePizza : AbstractPizza
    {
        public override string GetDescription()
        {
            return "This is a Large Pizza";
        }

        public override decimal CalculatePrice()
        {
            return 10;
        }
    }
}