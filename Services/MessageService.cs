using System;
using EventAndDelegate.VideoFormatter;

namespace EventAndDelegate.Services
{
    public class MessageService
    {
        public void SendText(object source, VideoArgs args)
        {
            System.Console.WriteLine($"Text sent for album {args.Album.Name}");
        }
    }
}