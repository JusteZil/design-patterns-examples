using Patterns2.Composite;
using Patterns2.Iterator;
using Patterns2.Template_Method;
using System;

namespace Patterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns Test\n");
            //TestTemplateMethod();
            //TestComposite();
            TestIterator();
        }

        public static void TestTemplateMethod()
        {
            Console.WriteLine("----------Template method----------");
            Tea teaWithoutCondiments = new Tea(false);
            Tea teaWithCondiments = new Tea(true);

            Coffee coffeeWithoutCondiments = new Coffee(false);
            Coffee coffeeWithCondiments = new Coffee(true);

            Console.WriteLine("\nTea without condiments:");
            teaWithoutCondiments.PrepareBeverage();

            Console.WriteLine("\nTea with condiments:");
            teaWithCondiments.PrepareBeverage();

            Console.WriteLine("\nCoffee without condiments:");
            coffeeWithoutCondiments.PrepareBeverage();

            Console.WriteLine("\nCoffee with condiments:");
            coffeeWithCondiments.PrepareBeverage();
            Console.WriteLine("----------------------------------\n");
        }

        public static void TestComposite()
        {
            Console.WriteLine("------------Composite------------");
            MenuItem menuItem1 = new MenuItem("Chocolate bar", 2.50);
            MenuItem menuItem2 = new MenuItem("Steak", 11.50);
            MenuItem menuItem3 = new MenuItem("Tomato soup", 3.20);
            MenuItem menuItem4 = new MenuItem("Pizza", 5.69);
            MenuItem menuItem5 = new MenuItem("Cappuccino", 3.50);
            MenuItem menuItem6 = new MenuItem("Table water", 1.50);

            Menu restaurantMenu = new Menu("Restaurant menu");

            Menu drinksMenu = new Menu("Drinks menu");
            drinksMenu.AddMenu(menuItem5);
            drinksMenu.AddMenu(menuItem6);

            Menu dessertsMenu = new Menu("Desserts menu");
            dessertsMenu.AddMenu(menuItem1);

            restaurantMenu.AddMenu(menuItem2);
            restaurantMenu.AddMenu(menuItem3);
            restaurantMenu.AddMenu(menuItem4);
            restaurantMenu.AddMenu(drinksMenu);
            restaurantMenu.AddMenu(dessertsMenu);

            restaurantMenu.Display(1);
            Console.WriteLine("----------------------------------\n");
        }

        public static void TestIterator()
        {
            Console.WriteLine("------------Iterator------------");
            Song song1 = new Song("Jordan Rakei", "Eye to Eye");
            Song song2 = new Song("Billie Eilish", "Bad guy");
            Song song3 = new Song("Tom Misch", "Movie");
            Song song4 = new Song("Jordan Rakei", "Mad world");
            Song song5 = new Song("Jordan Rakei", "Cauliflower");

            Aggregate songsArray = new SongArray();
            songsArray.Add(song1);
            songsArray.Add(song2);
            songsArray.Add(song3);
            songsArray.Add(song4);
            songsArray.Add(song5);

            Aggregate songsList = new SongList();
            songsList.Add(song1);
            songsList.Add(song2);
            songsList.Add(song3);
            songsList.Add(song4);
            songsList.Add(song5);

            IIterator arrayIterator = songsArray.CreateIterator();
            Console.WriteLine("--------------Songs Array------------------");
            for (; arrayIterator.HasNext(); arrayIterator.Next())
            {
                Song song = arrayIterator.CurrentElement();
                Console.WriteLine(song.ToString());
            }

            IIterator listIterator = songsList.CreateIterator();
            Console.WriteLine("--------------Songs List------------------");
            for (; listIterator.HasNext(); listIterator.Next())
            {
                Song song = listIterator.CurrentElement();
                Console.WriteLine(song.ToString());
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
