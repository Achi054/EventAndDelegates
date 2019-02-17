using System;
using EventAndDelegate.VideoFormatter;

namespace EventAndDelegate.Services
{
    public class EmailService
    {
        public void SendEmail(object source, VideoArgs args)
        {
            System.Console.WriteLine($"Email sent for album {args.Album.Name}");
        }
    }
}