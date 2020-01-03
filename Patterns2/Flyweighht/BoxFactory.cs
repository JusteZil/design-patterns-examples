using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Flyweighht
{
    public class BoxFactory
    {
        private readonly Dictionary<string, Box> _boxCache;

        public BoxFactory()
        {
            _boxCache = new Dictionary<string, Box>();
        }
        public Box CreateBox(string type)
        {
            Box box;
            if (_boxCache.ContainsKey(type))
                _boxCache.TryGetValue(type, out box);
            else
            {
                switch (type)
                {
                    case "rectangular":
                        box = new RectangularBox(10, 20, 15);
                        break;
                    case "round":
                        box = new RoundBox(10, 10, 10);
                        break;
                    default:
                        box = new RoundBox(10, 10, 10);
                        break;
                }
                _boxCache.Add(type, box);
            }
            return box;
        }
    }
}
