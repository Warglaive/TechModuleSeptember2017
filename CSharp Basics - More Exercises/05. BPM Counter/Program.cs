using System;

namespace _05.BPM_Counter
{
    public class Program
    {
        public static void Main()
        {
            var beatsPerMinute = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());
            Console.Write($"{Math.Round(numberOfBeats/4.0, 1)} bars - ");
            var beatsPerSecond = (numberOfBeats * 60) / beatsPerMinute;
            var min = (int)beatsPerSecond / 60;
            beatsPerSecond -= min * 60;
            Console.WriteLine($"{min}m {Math.Floor(beatsPerSecond)}s");
        }
    }
}