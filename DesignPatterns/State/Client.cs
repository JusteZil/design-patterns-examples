using System;

namespace DesignPatterns.State
{
    public class Client
    {
        private double _balance { get; set; }
        private IDiscount _discount;
        public string Name { get; set; }
        public int BonusPoints { get; set; } = 0;

        public Client(string name, double balance)
        {
            Name = name;
            _balance = balance;
            _discount = new NoDiscount();
        }

        public void Purchase(double price)
        {
            if (price > _balance)
            {
                Console.WriteLine("Not enough money");
            }

            var priceWithDiscount = _discount.HandlePurchaseDiscount(price, this);
            _balance -= priceWithDiscount; 
        }

        public void SetDiscount(IDiscount discount)
        {
            _discount = discount;
        }
    }
}
