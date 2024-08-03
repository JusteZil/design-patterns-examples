using System;

namespace DesignPatterns.Iterator
{
    public class IteratorPattern : DesignPattern
    {
        public override string Name => "Iterator";

        public override void Run()
        {
            var song1 = new Song("Jordan Rakei", "Eye to Eye");
            var song2 = new Song("Billie Eilish", "Bad guy");
            var song3 = new Song("Tom Misch", "Movie");
            var song4 = new Song("Jordan Rakei", "Mad world");
            var song5 = new Song("Jordan Rakei", "Cauliflower");

            var songsArray = new SongArray();
            songsArray.Add(song1);
            songsArray.Add(song2);
            songsArray.Add(song3);
            songsArray.Add(song4);
            songsArray.Add(song5);

            var songsList = new SongList();
            songsList.Add(song1);
            songsList.Add(song2);
            songsList.Add(song3);
            songsList.Add(song4);
            songsList.Add(song5);

            IIterator arrayIterator = songsArray.CreateIterator();
            Console.WriteLine("Songs Array:");
            for (; arrayIterator.HasNext(); arrayIterator.Next())
            {
                var song = arrayIterator.Current();
                Console.WriteLine(song.ToString());
            }

            IIterator listIterator = songsList.CreateIterator();
            Console.WriteLine("\nSongs List:");
            for (; listIterator.HasNext(); listIterator.Next())
            {
                var song = listIterator.Current();
                Console.WriteLine(song.ToString());
            }
        }
    }
}
