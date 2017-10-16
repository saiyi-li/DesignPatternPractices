using System;

namespace AdapterPattern
{
    public class MediaAdapter:IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.ToLower() == "vlc")
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType.ToLower() == "mp4")
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "vlc")
            {
                advancedMediaPlayer.PlayVLC(fileName);
            }
            else if (audioType.ToLower() == "mp4")
            {
                advancedMediaPlayer.PlayMP4(fileName);
            }
        }
    }
}
