using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Mediator.ChatRoom
{
    public class VipColleague : Colleague
    {
        public VipColleague(IChatRoom chatRoom, string name) : base(chatRoom, name)
        {

        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("{0} sent to {1}(Vip): '{2}'", from, Name, message);
        }

        public override void Send(string to, string message)
        {
            ChatRoom.Broadcast(to, this, message);
        }
    }
}
