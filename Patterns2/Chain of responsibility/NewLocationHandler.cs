using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Chain_of_responsibility
{
    public class NewLocationHandler : EmailHandler
    {
        public override void HandleEmail(string email)
        {
            if (email == "Location")
                Console.WriteLine("Location handler: Email has been sent to bussiness development team");
            else
            {
                Console.WriteLine("Location handler cannot handle this email");
                Handler.HandleEmail(email);
            }
        }
    }
}
