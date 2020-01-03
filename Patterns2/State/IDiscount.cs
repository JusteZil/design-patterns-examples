using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.State
{
    public interface IDiscount
    {
        public double HandlePurchaseDiscount(double price, Client client);
    }
}
