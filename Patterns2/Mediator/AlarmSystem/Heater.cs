using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Mediator.AlarmSystem
{
    public class Heater : Item
    {
        public Heater(AlarmSystem alarmSystem) : base(alarmSystem)
        {
        }

        public void HeatingOn(int degrees)
        {
            Console.WriteLine("Heater turned on. {0} degrees", degrees);
        }
    }
}
