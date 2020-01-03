using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Chain_of_responsibility
{
    public class UnknownEmailHandler : EmailHandler
    {
        public override void HandleEmail(string email)
        {
            Console.WriteLine("Email got to UnknownEmailHandler. Email unhandled");
        }
    }
}
