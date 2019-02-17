using System;
using System.Threading;

namespace EventAndDelegate.VideoFormatter
{
    public class VideoEncoder
    {
        //Delegate
        public delegate void VideoEncoderEventHandler(object source, VideoArgs args);
        //Event
        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            System.Console.WriteLine("Video encoding...");
            Thread.Sleep(5000);
            OnVideoEncoded(video);
        }

        //Event Handler
        protected void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoArgs(video));
        }
    }
}