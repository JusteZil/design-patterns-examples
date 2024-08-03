using System;

namespace Patterns2.ChainOfRresponsibility
{
    public class FanHandler : EmailHandler
    {
        private const string _handlerName = "Fan Handler";
        public override void HandleEmail(Email email)
        {
            if (email.Type == EmailType.Fan)
            {
                Console.WriteLine($"{_handlerName}: Email has been sent to CEO");
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
