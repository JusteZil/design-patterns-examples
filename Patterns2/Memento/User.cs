using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Memento
{
    public class User
    {
        public string Name;
        public string PhoneNo;
        public List<string> Hobbies;
        public User(string name, string phoneNo, List<string> hobbies)
        {
            Name = name;
            PhoneNo = phoneNo;
            Hobbies = hobbies;
            Console.WriteLine("User: {0}", this);
        }

        public void UpdateState(string phoneNo, List<string> hobbies)
        {
            PhoneNo = phoneNo;
            Hobbies = hobbies;
            Console.WriteLine("User updated: {0}", this);
        }

        public UserMemento CreateMemento()
        {
            Console.Write("Creating memento: ");
            return new UserMemento(this);
        }

        public void GetMemento(UserMemento memento)
        {
            Console.WriteLine("{0} is trying to restore state from memento", Name);
            memento.GetState(this);
        }

        public override string ToString()
        {
            return Name + "(" + PhoneNo + "). Hobbies: " + String.Join(", ", Hobbies);
        }
    }
}
