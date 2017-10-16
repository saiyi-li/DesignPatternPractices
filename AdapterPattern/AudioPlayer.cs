using System;

namespace AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "mp3")
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            else if (audioType.ToLower() == "vlc" || audioType.ToLower() == "mp4")
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
