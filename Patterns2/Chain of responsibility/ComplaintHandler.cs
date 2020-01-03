using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Chain_of_responsibility
{
    public class ComplaintHandler : EmailHandler
    {
        public override void HandleEmail(string email)
        {
            if (email == "Complaint")
                Console.WriteLine("Complaint handler: Email has been sent to legal department");
            else
            {
                Console.WriteLine("Complaint handler cannot handle this email");
                Handler.HandleEmail(email);
            }
        }
    }
}
