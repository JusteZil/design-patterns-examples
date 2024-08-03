using System.Collections.Generic;

namespace Patterns2.Iterator
{
    public class SongList : Aggregate
    {
        private List<Song> _songs;

        public SongList()
        {
            _songs = new List<Song>();
        }

        public void Add(Song song)
        {
            _songs.Add(song);
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(_songs);
        }
    }
}
