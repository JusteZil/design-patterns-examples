using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.State
{
    public class NoDiscount : IDiscount
    {
        public double HandlePurchaseDiscount(double price, Client client)
        {
            client.BonusPoints++;
            Console.WriteLine("Purchasing for {0} with no discount", price);
            Console.WriteLine("Total bonus points: {0}", client.BonusPoints);
            if (client.BonusPoints > 2)
                client.SetDiscount(new MediumDiscount());
            return price;
        }
    }
}
