using System;

namespace Patterns2.Proxy
{
    public class ImageProxy : ISubject
    {
        private ISubject image;

        public void DisplayImage()
        {
            if (image == null)
            {
                Console.WriteLine("Loading image");
                image = new Image();
            }
            image.DisplayImage();
        }
    }
}
