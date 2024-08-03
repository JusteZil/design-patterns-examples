using System;

namespace DesignPatterns.Proxy
{
    public class Image : ISubject
    {
        public void DisplayImage()
        {
            Console.WriteLine("Displaying image");
        }
    }
}
