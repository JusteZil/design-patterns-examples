using System;

namespace DesignPatterns.TemplateMethod
{
    public abstract class Beverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            AddBeverage();
            if (CondimentsNeeded())
                AddCondiments();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public virtual bool CondimentsNeeded()
        {
            return false;
        }

        public abstract void AddBeverage();

        public abstract void AddCondiments();
    }
}
