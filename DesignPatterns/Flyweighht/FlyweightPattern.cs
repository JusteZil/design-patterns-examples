using System;

namespace DesignPatterns.Flyweighht
{
    public class FlyweightPattern : DesignPattern
    {
        public override string Name => "Flyweight";

        public override void Run()
        {
            var boxFactory = new BoxFactory();
            var blackRectangularBox = boxFactory.CreateBox(BoxType.Rectangular);
            blackRectangularBox.Display("Black");

            Box blackRoundBox = boxFactory.CreateBox(BoxType.Round);
            blackRoundBox.Display("Black");

            Box redRoundBox = boxFactory.CreateBox(BoxType.Round);
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
        }
    }
}
