using System;

namespace Patterns2
{
    public abstract class DesignPattern
    {
        public abstract string Name { get; }
        public abstract void Run();
        public void RunExample()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name}:\n");
            Console.ResetColor();

            Run();
            Console.WriteLine($"\n------------------------------------------");
        }
    }
}
