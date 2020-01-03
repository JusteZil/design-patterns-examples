using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Chain_of_responsibility
{
    public class FanHandler : EmailHandler
    {
        public override void HandleEmail(string email)
        {
            if (email == "Fan")
                Console.WriteLine("Fan handler: Email has been sent to CEO");
            else
            {
                Console.WriteLine("Fan handler cannot handle this email");
                if (Handler != null)
                    Handler.HandleEmail(email);
                else
                    Console.WriteLine("Fan handler has no successor. Email unhandled");
            }
        }
    }
}
