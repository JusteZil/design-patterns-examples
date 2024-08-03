using DesignPatterns.Mediator.AlarmSystem;
using DesignPatterns.Mediator.ChatRoom;
using System;

namespace DesignPatterns.Mediator
{
    public class MediatorPattern : DesignPattern
    {
        public override string Name => "Mediator";

        public override void Run()
        {
            RunAlarmSystemExample();
            RunObserverExample();
        }

        private void RunAlarmSystemExample()
        {
            Console.WriteLine("Alarm system example:");
            var system = new AlarmSystem.AlarmSystem();

            var clock = new AlarmClock(system);
            var coffeeMachine = new CoffeeMachine(system);
            var heater = new Heater(system);
            var stereo = new Stereo(system);

            system.SetCoffeeMachine(coffeeMachine);
            system.SetHeater(heater);
            system.SetStereo(stereo);

            clock.AlarmOn();
            Console.WriteLine();
        }
        private void RunObserverExample()
        {
            Console.WriteLine("Mediator as Observer example:");
            var publicChatRoon = new PublicChatRoom();
            var vip1 = new VipColleague(publicChatRoon, "Alice");
            var vip2 = new VipColleague(publicChatRoon, "Bob");

            var reg1 = new RegularColleague(publicChatRoon, "Robert");
            var reg2 = new RegularColleague(publicChatRoon, "Marry");
            var reg3 = new RegularColleague(publicChatRoon, "Anasthasia");

            publicChatRoon.Register(vip1);
            publicChatRoon.Register(vip2);
            publicChatRoon.Register(reg1);
            publicChatRoon.Register(reg2);
            publicChatRoon.Register(reg3);

            vip1.Send("Bob", "Hey, how are you?");
            vip2.Send("Alice", "I am on a vacation now");
            reg3.Send("All", "How is everyone?");
        }
    }
}
