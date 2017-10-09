using System;
using System.Linq;

namespace _05.Sort_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join("<= ", input));
        }
    }
}