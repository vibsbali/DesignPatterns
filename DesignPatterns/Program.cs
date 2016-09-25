using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Decorator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPizza pizza = new LargePizza();
            pizza = new CheeseDecorator(pizza);
            pizza = new HamDecorator(pizza);

            Console.WriteLine(pizza.CalculatePrice());
            Console.WriteLine(pizza.GetDescription());
        }
    }
}
