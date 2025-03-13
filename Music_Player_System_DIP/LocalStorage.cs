using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_System_DIP
{
    //Concrete implementations
    public class LocalStorage : IMusicSource
    {
        public void PlayTrack(string trackName)
        {
            Console.WriteLine($"Playing {trackName} from local storage...");
        }
    }
}
