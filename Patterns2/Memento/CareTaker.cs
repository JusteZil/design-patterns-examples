using System.Collections.Generic;

namespace Patterns2.Memento
{
    public class CareTaker
    {
        private List<UserMemento> _mementos;

        public CareTaker()
        {
            _mementos = new List<UserMemento>();
        }

        public UserMemento GetMemento()
        {
            return _mementos[_mementos.Count - 1];
        }

        public void Add(UserMemento memento)
        {
            _mementos.Add(memento);
        }
    }
}
