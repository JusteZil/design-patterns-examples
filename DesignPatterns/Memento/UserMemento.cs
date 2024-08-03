using System;
using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class UserMemento
    {
        private string _name;
        private List<string> _hobbies;
        public UserMemento(string name, List<string> hobbies)
        {
            _name = name;
            _hobbies = hobbies;
        }

        public void GetState(User user)
        {
            if (_name != user.Name)
            {
                Console.WriteLine("Access denied");
            }
            else
            {
                user.UpdateState(_hobbies);
            }
        }
    }
}
