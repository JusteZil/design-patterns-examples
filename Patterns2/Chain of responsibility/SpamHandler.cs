using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Chain_of_responsibility
{
    public class SpamHandler : EmailHandler
    {
        public override void HandleEmail(string email)
        {
            if (email == "Spam")
                Console.WriteLine("Spam handler: Spam has been deleted");
            else
            {
                Console.WriteLine("Spam handler cannot handle this email");
                Handler.HandleEmail(email);
            }
        }
    }
}
