using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Filter
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            RemoveOddNumbers(input);
            Convert(input);
            Console.WriteLine(string.Join(" ", input));
        }

        private static void Convert(List<int> input)
        {
            var average = Math.Ceiling(input.Average());
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (input[i] > average)
                {
                    input[i] += 1;
                }
                else if (input[i] <= average)
                {
                    input[i] -= 1;
                }
            }
        }

        public static void RemoveOddNumbers(List<int> input)
        {
            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (input[i] % 2 != 0)
                {
                    input.Remove(input[i]);
                    i = input.Count;
                }
            }
        }
    }
}