using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_System_DIP
{
    public class StreamingService : IMusicSource
    {
        public void PlayTrack(string trackName)
        {
            Console.WriteLine($"Streaming {trackName} from online service...");
        }
    }
}
