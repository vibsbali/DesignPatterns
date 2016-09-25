namespace DesignPatterns.Decorator
{
    public class MediumPizza : AbstractPizza
    {
        public override string GetDescription()
        {
            return "This is a Medium Pizza";
        }

        public override decimal CalculatePrice()
        {
            return 5;
        }
    }
}