namespace DesignPatterns.Composite
{
    public class CompositePattern : DesignPattern
    {
        public override string Name => "Composite";

        public override void Run()
        {
            var menuItem1 = new MenuItem("Chocolate bar", 2.50);
            var menuItem2 = new MenuItem("Steak", 11.50);
            var menuItem3 = new MenuItem("Tomato soup", 3.20);
            var menuItem4 = new MenuItem("Pizza", 5.69);
            var menuItem5 = new MenuItem("Cappuccino", 2.50);
            var menuItem6 = new MenuItem("Table water", 1.50);

            var drinksMenu = new Menu("Drinks menu");
            drinksMenu.AddMenu(menuItem5);
            drinksMenu.AddMenu(menuItem6);

            var dessertsMenu = new Menu("Desserts menu");
            dessertsMenu.AddMenu(menuItem1);

            var restaurantMenu = new Menu("Restaurant menu");
            restaurantMenu.AddMenu(menuItem2);
            restaurantMenu.AddMenu(menuItem3);
            restaurantMenu.AddMenu(menuItem4);
            restaurantMenu.AddMenu(drinksMenu);
            restaurantMenu.AddMenu(dessertsMenu);

            restaurantMenu.Display(1);
        }
    }
}
