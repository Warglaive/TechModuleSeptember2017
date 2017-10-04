using System;

namespace _11.Convert_Speed_Units
{
    public class Program
    {
        public static void Main()
        {
            var meter = float.Parse(Console.ReadLine());
            //time taken
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            //print the speed, in meters per second, kilometers per hour and miles per hour.
            var oneMile = meter / 1609;
            var kilometers = meter * 0.001;
            var hrsToSecs = (hours * 60) * 60;
            var minsToSecs = minutes * 60;
            var totalTimeInSeconds = hrsToSecs + minsToSecs + seconds;
            var metersPerSecond = meter / totalTimeInSeconds;
            var kilometersPerHour = (float)kilometers / (totalTimeInSeconds / 60 / 60);
            var milesPerHour = oneMile / (totalTimeInSeconds / 60 / 60);
            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}