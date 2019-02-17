using System;
using EventAndDelegate.Services;
using EventAndDelegate.VideoFormatter;

namespace EventAndDelegates
{
    class Program
    {
        public delegate double AreaCalculator(int radius);
        static void Main(string[] args)
        {
            var videoFormatter = new VideoEncoder();
            videoFormatter.VideoEncoded += new EmailService().SendEmail;
            videoFormatter.VideoEncoded += new MessageService().SendText;

            videoFormatter.Encode(new Video() { Name = "My Video" });
            Console.ReadLine();

            //Lambda Expression
            AreaCalculator areaOfCircleCalculater = (r) => 3.14 * r * r;
            double area = areaOfCircleCalculater(20);

            System.Console.WriteLine($"Area of circle {area}");

            //Func delegate
            Func<int, double> areaOfCircleFunc = (r) => 3.14 * r * r;
            double areaFunc = areaOfCircleFunc.Invoke(20);

            System.Console.WriteLine($"Area of circle using Func {area}");

            //Action delegate
            Action<int> areaOfCircleAction = (r) =>
            {
                Console.WriteLine($"Area of circle using Action {3.14 * r * r}");
            };
            areaOfCircleAction.Invoke(20);

            //Predicate delegate
            Predicate<int> isAreaGreaterThanRadius = (r) => r > (3.14 * r * r);
            bool isAreaGreater = isAreaGreaterThanRadius.Invoke(20);

            System.Console.WriteLine($"Is Area greater than radius, {isAreaGreater}");
            Console.ReadLine();
        }
    }
}
