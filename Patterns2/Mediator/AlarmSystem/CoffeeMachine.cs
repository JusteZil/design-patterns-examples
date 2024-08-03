using System;

namespace Patterns2.Mediator.AlarmSystem
{
    public class CoffeeMachine : Item
    {
        public CoffeeMachine(AlarmSystem alarmSystem) : base(alarmSystem)
        {
        }

        public void PrepareCoffee(string type)
        {
            Console.WriteLine("Preparing {0}", type);
        }
    }
}
