using System.Collections.Generic;

namespace Patterns2.Iterator
{
    public class ListIterator : IIterator
    {
        private List<Song> _songs;
        private int _index;

        public ListIterator(List<Song> songs)
        {
            _songs = songs;
            _index = 0;
        }

        public Song Current()
        {
            if (!HasNext())
            {
                return null;
            }

            return _songs[_index];
        }

        public Song First()
        {
            _index = 0;
            return _songs[_index];
        }

        public bool HasNext()
        {
            return _index < _songs.Count;
        }

        public void Next()
        {
            if (HasNext())
            {
                _index++;
            }
        }
    }
}
