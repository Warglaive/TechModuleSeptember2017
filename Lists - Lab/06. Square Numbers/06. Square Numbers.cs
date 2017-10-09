using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var num in input)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",result));
        }
    }
}