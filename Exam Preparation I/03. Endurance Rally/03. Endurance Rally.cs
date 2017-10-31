using System;
using System.Linq;

namespace _03.Endurance_Rally
{
    public class Program
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split(' ').ToList();
            var zones = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var checkPointIndexes = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            foreach (var driver in drivers)
            {
                var counter = 0;
                var x = Convert.ToInt32(driver[0]);
                var startFuel = Convert.ToDouble(x);

                for (int index = 0; index < zones.Count; index++)
                {
                    if (counter <= checkPointIndexes.Count - 1)
                    {
                        if (index == checkPointIndexes[counter])
                        {
                            startFuel += Convert.ToDouble(zones[index]);
                            counter++;
                        }
                        else
                        {
                            startFuel -= Convert.ToDouble(zones[index]);
                        }
                    }
                    else
                    {
                        startFuel -= Convert.ToDouble(zones[index]);
                    }
                    if (startFuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {index}");
                        break;
                    }
                }
                if (startFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {startFuel:F2}");
                }
            }
        }
    }
}//60/100 judge