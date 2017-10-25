using System;

namespace TimeDifference
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            DateTime startTime = DateTime.Parse(input);
            var steps = double.Parse(Console.ReadLine()) % 86400; //ako vhoda e >= 1 den
            var secondsPerStep = double.Parse(Console.ReadLine());
            var allTimeInSeconds = (steps * secondsPerStep);
            TimeSpan spanTime = TimeSpan.FromSeconds(allTimeInSeconds);
            var result = startTime + spanTime;
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}