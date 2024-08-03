using System;

namespace Patterns2.ChainOfRresponsibility
{
    public class SpamHandler : EmailHandler
    {
        private const string _handlerName = "Spam Handler";
        public override void HandleEmail(Email email)
        {
            if (email.Type == EmailType.Spam)
            {
                Console.WriteLine($"{_handlerName}: Spam has been deleted");
                return;
            }

            if (Handler != null)
            {
                Handler.HandleEmail(email);
            }
            else
            {
                Console.WriteLine($"{_handlerName} has no successor. Email unhandled");
            }
        }
    }
}
