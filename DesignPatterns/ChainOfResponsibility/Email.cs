namespace DesignPatterns.ChainOfRresponsibility
{
    public class Email
    {
        public Email(EmailType type)
        {
            Type = type;
        }

        public EmailType Type { get; set; }
    }
}
