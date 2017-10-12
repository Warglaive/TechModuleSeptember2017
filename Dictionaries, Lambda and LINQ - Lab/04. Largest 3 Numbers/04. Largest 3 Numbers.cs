using System;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var realNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", realNumbers.OrderByDescending(x => x).Take(3)));
            
        }
    }
}