using System;

namespace Patterns2.Mediator.AlarmSystem
{
    public class Stereo : Item
    {
        public Stereo(AlarmSystem alarmSystem) : base(alarmSystem)
        {
        }

        public void PlayMusic()
        {
            Console.WriteLine("Playing music from Spotify");
        }

        public void PlayNews()
        {
            Console.WriteLine("Broadcasting news");
        }
    }
}
