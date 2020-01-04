using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Mediator.ChatRoom
{
    public abstract class Colleague
    {
        public IChatRoom ChatRoom;
        public string Name;
        public Colleague(IChatRoom chatRoom, string name)
        {
            ChatRoom = chatRoom;
            Name = name;
        }

        public abstract void Send(string to, string message);
        public abstract void Receive(string from, string message);
    }
}
