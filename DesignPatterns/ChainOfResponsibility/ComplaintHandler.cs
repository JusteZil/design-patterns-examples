using System;

namespace DesignPatterns.ChainOfRresponsibility
{
    public class ComplaintHandler : EmailHandler
    {
        private const string _handlerName = "Complaint Handler";
        public override void HandleEmail(Email email)
        {
            if (email.Type == EmailType.Complaint)
            {
                Console.WriteLine($"{_handlerName}: Email has been sent to legal department");
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
