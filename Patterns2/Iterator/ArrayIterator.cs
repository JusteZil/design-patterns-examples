namespace Patterns2.Iterator
{
    public class ArrayIterator : IIterator
    {
        private Song[] _songs;
        private int _index;

        public ArrayIterator(Song[] songs)
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
            return _index < _songs.Length && _songs[_index] != null;
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
