using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Composite
{
    public class MenuItem : MenuComponent
    { 
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price) : base(true)
        {
            Name = name;
            Price = price;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name + ", " + Price);
        }
    }
}
