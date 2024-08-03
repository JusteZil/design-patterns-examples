namespace Patterns2.Iterator
{
    public class SongArray : Aggregate
    {
        private Song[] _songs;
        private int _index = 0;

        public SongArray()
        {
            _songs = new Song[100];
;       }

        public void Add(Song song)
        {
            _songs[_index++] = song;
        }

        public IIterator CreateIterator()
        {
            return new ArrayIterator(_songs);
        }
    }
}
