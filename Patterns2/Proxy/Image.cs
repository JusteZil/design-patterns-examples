using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Proxy
{
    public class Image : ISubject
    {
        public void DisplayImage()
        {
            Console.WriteLine("Displaying image");
        }
    }
}
