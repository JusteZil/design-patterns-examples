using System;

namespace DesignPatterns.Composite
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
            Console.WriteLine(new string('-', depth) + Name + ", " + Price);
        }
    }
}
