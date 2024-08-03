namespace DesignPatterns.ChainOfRresponsibility
{
    public abstract class EmailHandler
    {
        public EmailHandler Handler;

        public abstract void HandleEmail(Email email);
    }
}
