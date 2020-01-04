using Patterns2.Chain_of_responsibility;
using Patterns2.Composite;
using Patterns2.Flyweighht;
using Patterns2.Interpreter;
using Patterns2.Interpreter.Calculator;
using Patterns2.Interpreter.Relationship;
using Patterns2.Interpreter.Roman;
using Patterns2.Iterator;
using Patterns2.Mediator.ChatRoom;
using Patterns2.Mediator.AlarmSystem;
using Patterns2.Proxy;
using Patterns2.State;
using Patterns2.Template_Method;
using System;
using System.Collections.Generic;
using Patterns2.Memento;

namespace Patterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns Test\n");
            //TestTemplateMethod();
            //TestComposite();
            //TestIterator();
            //TestFlyweight();
            //TestState();
            //TestVirtualProxy();
            //TestChainOfResponsibility();
            //TestInterpreterRoman();
            //TestInterpreterCalculator();
            //TestInterpreterRelationships();
            //TestMediatorAsObserver();
            //TestMediator();
            TestMemento();
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

        public static void TestFlyweight()
        {
            Console.WriteLine("----------------------Flyweight----------------------");
            BoxFactory boxFactory = new BoxFactory();
            Box blackRectangularBox = boxFactory.CreateBox("rectangular");
            blackRectangularBox.Display("Black");

            Box blackRoundBox = boxFactory.CreateBox("round");
            blackRoundBox.Display("Black");

            Box redRoundBox = boxFactory.CreateBox("round");
            redRoundBox.Display("Red");

            Box unsharedBox = new UnsharedBox(10, 20, 15);
            unsharedBox.Display("Green");

            Console.WriteLine("Changing boxes width to be 100:");
            blackRectangularBox.Width = 100;
            blackRoundBox.Width = 100;

            blackRectangularBox.Display("Black");
            blackRoundBox.Display("Black");
            redRoundBox.Display("Red");
            unsharedBox.Display("Green");

            Console.WriteLine("---------------------------------------------------\n");
        }

        public static void TestState()
        {
            Console.WriteLine("----------------------State----------------------");
            Client client = new Client("Jonas Jonaitis", 200);
            client.Purchase(5);
            client.Purchase(5);
            client.Purchase(10);
            client.Purchase(20);
            client.Purchase(40);
            client.Purchase(5);
            client.Purchase(5);
            client.Purchase(20);
            Console.WriteLine("---------------------------------------------------\n");
        }

        public static void TestVirtualProxy()
        {
            Console.WriteLine("----------------------Virtual Proxy----------------------");
            ISubject image = new ImageProxy();
            image.DisplayImage();
            image.DisplayImage();
            Console.WriteLine("---------------------------------------------------\n");
        }

        public static void TestChainOfResponsibility()
        {
            Console.WriteLine("----------------------Chain of Responsibility----------------------");
            EmailHandler spamHandler= new SpamHandler();
            EmailHandler fanHandler = new FanHandler();
            EmailHandler complaintHandler = new ComplaintHandler();
            EmailHandler newLocationHandler = new NewLocationHandler();
            EmailHandler unknownEmailHandler = new UnknownEmailHandler();

            spamHandler.Handler = fanHandler;
            fanHandler.Handler = complaintHandler;
            complaintHandler.Handler = newLocationHandler;
            newLocationHandler.Handler = unknownEmailHandler;

            Console.WriteLine("Spam email:");
            spamHandler.HandleEmail("Spam");

            Console.WriteLine("\nFan email");
            spamHandler.HandleEmail("Fan");

            Console.WriteLine("\nComplaint email:");
            spamHandler.HandleEmail("Complaint");

            Console.WriteLine("\nNew location email:");
            spamHandler.HandleEmail("Location");

            Console.WriteLine("\nAdvertisement email:");
            spamHandler.HandleEmail("Advertisement");


            complaintHandler.Handler = null;
            Console.WriteLine("\n(Broken chain)New Location email:");
            spamHandler.HandleEmail("Location");

            Console.WriteLine("---------------------------------------------------\n");
        }
        public static void TestInterpreterRoman()
        {
            Console.WriteLine("----------------------Interpreter Roman----------------------");

            string roman = "MCMXXVIII";
            Interpreter.Roman.Context context = new Interpreter.Roman.Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);
            Console.WriteLine("---------------------------------------------------\n");
        }
        public static void TestInterpreterCalculator()
        {
            Console.WriteLine("----------------------Interpreter Calculator----------------------");
            ExpressionParser expParser = new ExpressionParser();
            expParser.Parse("2 5 +");

            Console.WriteLine("---------------------------------------------------\n");
        }
        public static void TestInterpreterRelationships()
        {
            Console.WriteLine("----------------------Interpreter Relationships----------------------");
            Expr person1 = new Terminal("Tom");
            Expr person2 = new Terminal("Luke");
            Expr isSingle = new OrExpression(person1, person2);

            Expr alice = new Terminal("Alice");
            Expr committed = new Terminal("Committed");
            Expr isCommitted = new AndExpression(alice, committed);

            Interpreter.Relationship.Context context = new Interpreter.Relationship.Context("Tom");
            Console.WriteLine(isSingle.Interpret(context));
            context.SetInput("Andrew");
            Console.WriteLine(isSingle.Interpret(context));

            context.SetInput("Committed, Alice");
            Console.WriteLine(isCommitted.Interpret(context));
            context.SetInput("Single, Alice");
            Console.WriteLine(isCommitted.Interpret(context));

            Console.WriteLine("---------------------------------------------------\n");
        }
        public static void TestMediatorAsObserver()
        {
            Console.WriteLine("----------------------Mediator as Observer----------------------");
            PublicChatRoom publicChatRoon = new PublicChatRoom();
            VipColleague vip1 = new VipColleague(publicChatRoon, "Alice");
            VipColleague vip2 = new VipColleague(publicChatRoon, "Bob");

            RegularColleague reg1 = new RegularColleague(publicChatRoon, "Robert");
            RegularColleague reg2 = new RegularColleague(publicChatRoon, "Marry");
            RegularColleague reg3 = new RegularColleague(publicChatRoon, "Anasthasia");

            publicChatRoon.Register(vip1);
            publicChatRoon.Register(vip2);
            publicChatRoon.Register(reg1);
            publicChatRoon.Register(reg2);
            publicChatRoon.Register(reg3);

            vip1.Send("Bob", "Hey, how are you?");
            vip2.Send("Alice", "I am on a vacation now");
            reg3.Send("All", "How is everyone?");

            Console.WriteLine("---------------------------------------------------\n");
        }

        public static void TestMediator()
        {
            Console.WriteLine("----------------------Mediator----------------------");
            AlarmSystem system = new AlarmSystem();
            
            AlarmClock clock = new AlarmClock(system);
            CoffeeMachine coffeeMachine = new CoffeeMachine(system);
            Heater heater = new Heater(system);
            Stereo stereo = new Stereo(system);

            system.SetAlarmClock(clock);
            system.SetCoffeeMachine(coffeeMachine);
            system.SetHeater(heater);
            system.SetStereo(stereo);

            clock.AlarmOn();           
            Console.WriteLine("---------------------------------------------------\n");
        }

        public static void TestMemento()
        {
            Console.WriteLine("----------------------Memento----------------------");
            CareTaker careTaker = new CareTaker();
            User user1 = new User("Alice", "+37064586339", new List<string> { "Dancing", "Swimming" });
            User user2 = new User("Bob", "+37074185239", new List<string> { "Boxing" });

            careTaker.Add(user1.CreateMemento());

            user1.UpdateState(user1.PhoneNo, new List<string> { "Sports", "Fishing" });
            UserMemento memento = careTaker.GetMemento();
            user1.GetMemento(memento);
            user2.GetMemento(memento);
            Console.WriteLine("---------------------------------------------------\n");
        }
    }
}
