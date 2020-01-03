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
                if(Handler != null)
                    Handler.HandleEmail(email);
                else
                Console.WriteLine("Complaint handler has no successor. Email unhandled");
            }
        }
    }
}
