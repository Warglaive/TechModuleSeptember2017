using System;
using System.Linq;

namespace _01.Sort_Times
{
    public class Program
    {
        public static void Main()
        {
            var time = Console.ReadLine().Split(' ').Select(TimeSpan.Parse).ToList();
            var counter = 0;
            foreach (var VARIABLE in time.OrderBy(x => x.Hours).ThenBy(x => x.Minutes))
            {
                if (time.Count - 1 > counter)
                {
                    Console.Write($"{VARIABLE.Hours:00}:{VARIABLE.Minutes:00}, ");
                    counter++;
                }
                else
                {
                    Console.Write($"{VARIABLE.Hours:00}:{VARIABLE.Minutes:00}");
                }
            }
        }
    }
}