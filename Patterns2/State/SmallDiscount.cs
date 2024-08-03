using System;

namespace Patterns2.State
{
    public class SmallDiscount : IDiscount
    {
        public double HandlePurchaseDiscount(double price, Client client)
        {
            client.BonusPoints += 2;
            Console.WriteLine("Purchasing for {0} with small 10% discount", price);
            Console.WriteLine("Total bonus points: {0}", client.BonusPoints);
            if (client.BonusPoints > 10)
            {
                client.SetDiscount(new MediumDiscount());
            }

            return price * 0.9;
        }
    }
}
