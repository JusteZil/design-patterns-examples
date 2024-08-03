using Patterns2.ChainOfRresponsibility;
using System;

namespace Patterns2.ChainOfResponsibility
{
    public class ChainOrResponsibilityPattern : DesignPattern
    {
        public override string Name => "Chain of Responsibility";

        public override void Run()
        {
            var spamHandler = new SpamHandler();
            var fanHandler = new FanHandler();
            var complaintHandler = new ComplaintHandler();
            var unknownEmailHandler = new UnknownEmailHandler();

            spamHandler.Handler = fanHandler;
            fanHandler.Handler = complaintHandler;
            complaintHandler.Handler = unknownEmailHandler;

            Console.WriteLine("Spam email:");
            spamHandler.HandleEmail(new Email(EmailType.Spam));

            Console.WriteLine("\nFan email:");
            spamHandler.HandleEmail(new Email(EmailType.Fan));

            Console.WriteLine("\nComplaint email:");
            spamHandler.HandleEmail(new Email(EmailType.Complaint));

            Console.WriteLine("\nAdvertisement email:");
            spamHandler.HandleEmail(new Email(EmailType.Advertisement));

            fanHandler.Handler = null;
            Console.WriteLine("\n(Broken chain)Complaint email:");
            spamHandler.HandleEmail(new Email(EmailType.Complaint));
        }
    }
}
