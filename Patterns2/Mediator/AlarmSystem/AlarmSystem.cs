using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Mediator.AlarmSystem
{
    public class AlarmSystem
    {

        AlarmClock _clock;
        Stereo _stereo;
        Heater _heater;
        CoffeeMachine _coffeeMachine;

        public AlarmSystem()
        {
        }
        public void SetAlarmClock(AlarmClock clock)
        {
            _clock = clock;
        }

        public void SetCoffeeMachine(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public void SetHeater(Heater heater)
        {
            _heater = heater;
        }

        public void SetStereo(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void SetAlarmOn()
        {
            Console.WriteLine("Good morning! Date: {0}", DateTime.Now);
            Console.WriteLine("Making your {0} pleasant:", DateTime.Now.DayOfWeek);
            _heater.HeatingOn(22);
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                _stereo.PlayNews();
                _coffeeMachine.PrepareCoffee("Expresso");
            }
            else if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday ||
                DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                _stereo.PlayMusic();
                _coffeeMachine.PrepareCoffee("Cappuccino");
            }
            else
            {
                _coffeeMachine.PrepareCoffee("Regular coffee");
            }
        }
    }
}
