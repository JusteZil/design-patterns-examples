using System.Collections.Generic;

namespace DesignPatterns.Flyweighht
{
    public class BoxFactory
    {
        private readonly Dictionary<BoxType, Box> _boxCache;

        public BoxFactory()
        {
            _boxCache = new Dictionary<BoxType, Box>();
        }

        public Box CreateBox(BoxType type)
        {
            Box box;
            if (_boxCache.ContainsKey(type))
            {
                _boxCache.TryGetValue(type, out box);
            }
            else
            {
                switch (type)
                {
                    case BoxType.Rectangular:
                        box = new RectangularBox(10, 20, 15);
                        break;
                    case BoxType.Round:
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
