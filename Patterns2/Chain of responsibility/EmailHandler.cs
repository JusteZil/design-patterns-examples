using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Chain_of_responsibility
{
    public abstract class EmailHandler
    {
        public EmailHandler Handler;

        public abstract void HandleEmail(string email);
    }
}
