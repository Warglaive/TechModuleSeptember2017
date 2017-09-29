using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    public class Program
    {
        public static void Main()
        {
            var BeatsPerMinute = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());
            Console.Write($"{Math.Round(numberOfBeats/4.0, 1)} bars - ");
            var beatsPerSecond = (numberOfBeats * 60) / BeatsPerMinute;
            var min = (int)beatsPerSecond / 60;
            beatsPerSecond -= min * 60;
            Console.WriteLine($"{min}m {Math.Floor(beatsPerSecond)}s");
        }
    }
}