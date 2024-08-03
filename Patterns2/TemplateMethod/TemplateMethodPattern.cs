using System;

namespace Patterns2.TemplateMethod
{
    public class TemplateMethodPattern : DesignPattern
    {
        public override string Name => "Template Method";

        public override void Run()
        {
            var teaWithoutCondiments = new Tea(false);
            var teaWithCondiments = new Tea(true);

            var coffeeWithoutCondiments = new Coffee(false);
            var coffeeWithCondiments = new Coffee(true);

            Console.WriteLine("Tea without condiments:");
            teaWithoutCondiments.PrepareBeverage();

            Console.WriteLine("\nTea with condiments:");
            teaWithCondiments.PrepareBeverage();

            Console.WriteLine("\nCoffee without condiments:");
            coffeeWithoutCondiments.PrepareBeverage();

            Console.WriteLine("\nCoffee with condiments:");
            coffeeWithCondiments.PrepareBeverage();
        }
    }
}
