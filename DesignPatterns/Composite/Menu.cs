using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    class Menu : MenuComponent
    {
        public List<MenuComponent> MenuComponents;
        public string Name { get; set; }
        public Menu(string name) : base(false)
        {
            Name = name;
            MenuComponents = new List<MenuComponent>();
        }

        public void AddMenu(MenuComponent component)
        {
            MenuComponents.Add(component);
        }

        public void RemoveMenu(MenuComponent component)
        {
            MenuComponents.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            // Recursively display child nodes
            foreach (MenuComponent component in MenuComponents)
            {
                component.Display(depth + 2);
            }
        }
    }
}