using System;

namespace Patterns2.ChainOfRresponsibility
{
    public class UnknownEmailHandler : EmailHandler
    {
        public override void HandleEmail(Email email)
        {
            Console.WriteLine("Unknown Email Handler: Email unhandled");
        }
    }
}
