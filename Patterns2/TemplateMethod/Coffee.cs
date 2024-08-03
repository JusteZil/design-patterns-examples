using System;

namespace Patterns2.TemplateMethod
{
    public class Coffee : Beverage
    {
        private bool _withCondiments = false;
        public Coffee(bool withCondiments)
        {
            _withCondiments = withCondiments;
        }

        public override void AddBeverage()
        {
            Console.WriteLine("Adding coffee grains");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
        public override bool CondimentsNeeded()
        {
            return _withCondiments;
        }
    }
}
