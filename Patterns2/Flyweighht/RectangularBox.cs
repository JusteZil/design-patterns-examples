using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Flyweighht
{
    public class RectangularBox : Box
    {
        public RectangularBox(int height, int width, int length) : base(height, width, length)
        {
        }
        public override void Display(string color)
        {
            Console.WriteLine("Rectangular box: ({0},{1},{2}) in color {3}", Height, Width, Length, color);
        }
    }
}
