namespace DesignPatterns.Mediator.ChatRoom
{
    public abstract class Colleague
    {
        public IChatRoom ChatRoom { get; set; }
        public string Name { get; set; }
        public Colleague(IChatRoom chatRoom, string name)
        {
            ChatRoom = chatRoom;
            Name = name;
        }

        public abstract void Send(string to, string message);
        public abstract void Receive(string from, string message);
    }
}
