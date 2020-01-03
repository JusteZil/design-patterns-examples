using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Template_Method
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
