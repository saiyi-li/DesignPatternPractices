using System;

namespace AdapterPattern
{
    public class VlcPlayer:IAdvancedMediaPlayer
    {
        public void PlayVLC(string fileName)
        {
            Console.WriteLine("Playing VLC file. Name: " + fileName);
        }

        public void PlayMP4(string fileName)
        {
        }
    }
}
