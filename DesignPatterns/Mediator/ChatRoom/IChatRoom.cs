namespace DesignPatterns.Mediator.ChatRoom
{
    public interface IChatRoom
    {
        public void Register(Colleague colleague);
        public void Broadcast(string to, Colleague colleague, string message);
    }
}
