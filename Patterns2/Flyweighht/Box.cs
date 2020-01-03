using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Flyweighht
{
    public abstract class Box
    {
        public int Height;
        public int Width;
        public int Length;

        public Box(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
        public abstract void Display(string color);
    }
}
