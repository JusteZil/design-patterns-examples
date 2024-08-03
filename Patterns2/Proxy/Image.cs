using System;

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
