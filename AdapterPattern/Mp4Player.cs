using System;

namespace AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVLC(string fileName)
        {
        }

        public void PlayMP4(string fileName)
        {
            Console.WriteLine("Playing MP4 file. Name: " + fileName);
        }
    }
}
