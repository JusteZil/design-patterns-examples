using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Memento
{
    public class UserMemento
    {
        private User _user;
        public UserMemento(User user)
        {
            _user = new User(user.Name, user.PhoneNo, user.Hobbies);
        }

        public void GetState(User user)
        {
            if (user.Name != _user.Name)
            {
                Console.WriteLine("Access denied");
            }
            else
            {
                user.Hobbies = _user.Hobbies;
                user.PhoneNo = _user.PhoneNo;
                Console.WriteLine("User updated: {0}", _user);
            }
        }
    }
}
