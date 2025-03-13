using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player_System_DIP
{
    //Testing the Dependency Inversion Principle 
    public class Program
    {
        public static void Main(string[] args)
        {
            var local = new LocalStorage();
            var playerFromLocal = new MusicPlayer(local);
            playerFromLocal.Play("SongA.mp3");
            var streaming = new StreamingService();
            var playerFromStreaming = new MusicPlayer(streaming);
            playerFromStreaming.Play("SongB");
            var radio = new RadioStation();
            var radioPlayer = new MusicPlayer(radio);
            radioPlayer.Play("Jazz FM");
            Console.ReadKey();
        }
    }
}
