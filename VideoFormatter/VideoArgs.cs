using System;

namespace EventAndDelegate.VideoFormatter
{
    public class VideoArgs : EventArgs
    {
        public VideoArgs(Video video)
        {
            this.Album = video;
        }
        public Video Album { get; private set; }
    }
}