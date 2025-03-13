using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_System_DIP
{
    //The MusicPlayer class now depends on the abstraction
    public class MusicPlayer
    {
        private readonly IMusicSource _source;
        public MusicPlayer(IMusicSource source)
        {
            _source = source;
        }

        public void Play(string name)
        {
            _source.PlayTrack(name);
        }
    }
}
