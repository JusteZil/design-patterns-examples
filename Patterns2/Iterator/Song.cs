using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns2.Iterator
{
    public class Song
    {
        private string _artist;
        private string _songName;

        public Song(string artist, string songName)
        {
            _artist = artist;
            _songName = songName;
        }

        public override string ToString()
        {
            return _artist + "-" + _songName;
        }
    }
}
