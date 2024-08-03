using System;

namespace DesignPatterns.State
{
    public class MediumDiscount : IDiscount
    {
        public double HandlePurchaseDiscount(double price, Client client)
        {
            client.BonusPoints += 3;
            Console.WriteLine("Purchasing for {0} with medium 20% discount", price);
            Console.WriteLine("Total bonus points: {0}", client.BonusPoints);
            return price * 0.8;
        }
    }
}
