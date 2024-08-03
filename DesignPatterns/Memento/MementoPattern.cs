using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    internal class MementoPattern : DesignPattern
    {
        public override string Name => "Memento";

        public override void Run()
        {
            var careTaker = new CareTaker();
            var user1 = new User("Alice", "+37064586339", new List<string> { "Dancing", "Swimming" });
            var user2 = new User("Bob", "+37074185239", new List<string> { "Boxing" });

            careTaker.Add(user1.CreateMemento());

            user1.UpdateState(new List<string> { "Sports", "Fishing" });
            var memento = careTaker.GetMemento();
            user1.GetMemento(memento);
            user2.GetMemento(memento);
        }
    }
}
