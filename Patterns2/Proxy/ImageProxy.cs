using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Proxy
{
    public class ImageProxy : ISubject
    {
        private ISubject image;

        public ImageProxy()
        {
        }

        public void DisplayImage()
        {
            if(image == null)
            {
                Console.WriteLine("Loading image");
                image = new Image();
            }
            image.DisplayImage();
        }
    }
}
