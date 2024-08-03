namespace Patterns2.Iterator
{
    public class Song
    {
        public string Artist { get; set; }
        public string SongName { get; set; }

        public Song(string artist, string songName)
        {
            Artist = artist;
            SongName = songName;
        }

        public override string ToString()
        {
            return $"{Artist}: {SongName}";
        }
    }
}
