using System.Collections.Generic;

namespace DesignPatterns.Mediator.ChatRoom
{
    public class PublicChatRoom : IChatRoom
    {
        private readonly Dictionary<string, Colleague> _colleagues = new Dictionary<string, Colleague>();

        public void Broadcast(string to, Colleague fromColleague, string message)
        {
            Colleague colleague;
            if (to == "All")
            {
                foreach (Colleague c in _colleagues.Values)
                {
                    c.Receive(fromColleague.Name, message);
                }
            }
            else if (_colleagues.ContainsKey(to))
            {
                _colleagues.TryGetValue(to, out colleague);
                colleague.Receive(fromColleague.Name, message);
            }
        }

        public void Register(Colleague colleague)
        {
            _colleagues.Add(colleague.Name, colleague);
        }
    }
}
