using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_System_DIP
{
    //Define the Interface
    public interface IMusicSource
    {
        void PlayTrack(string trackName);
    }
}
