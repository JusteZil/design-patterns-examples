using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.State
{
    public class Client
    {
        public string Name { get; set; }
        private double _balance { get; set; }

        public int BonusPoints { get; set; } = 0;

        private IDiscount _discount;

        public Client(string name, double balance)
        {
            Name = name;
            _balance = balance;
            _discount = new NoDiscount();
        }

        public void Purchase(double price)
        {
            if (price > _balance)
                Console.WriteLine("Not enough money");
            var priceWithDiscount = _discount.HandlePurchaseDiscount(price, this);
            _balance -= priceWithDiscount; 
        }

        public void SetDiscount(IDiscount discount)
        {
            _discount = discount;
        }
    }
}
