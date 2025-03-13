using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_System_DIP
{
    public class RadioStation : IMusicSource
    {
        public void PlayTrack(string stationName)
        {
            Console.WriteLine($"Tuning into {stationName} radio station...");
        }
    }
}
