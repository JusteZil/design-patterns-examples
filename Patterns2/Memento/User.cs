using System;
using System.Collections.Generic;

namespace Patterns2.Memento
{
    public class User
    {
        public string Name { get; set; }
        private string _phoneNo;
        private List<string> _hobbies;

        public User(string name, string phoneNo, List<string> hobbies)
        {
            Name = name;
            _phoneNo = phoneNo;
            _hobbies = hobbies;
            Console.WriteLine("User: {0}", this);
        }

        public void UpdateState(List<string> hobbies)
        {
            _hobbies = hobbies;
            Console.WriteLine("User updated: {0}", this);
        }

        public UserMemento CreateMemento()
        {
            Console.Write("Creating memento: ");
            return new UserMemento(Name, _hobbies);
        }

        public void GetMemento(UserMemento memento)
        {
            Console.WriteLine("{0} is trying to restore state from memento", Name);
            memento.GetState(this);
        }

        public override string ToString()
        {
            return Name + "(" + _phoneNo + "). Hobbies: " + string.Join(", ", _hobbies);
        }
    }
}
