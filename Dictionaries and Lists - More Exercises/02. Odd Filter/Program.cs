using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private static List<int> Convert(List<int> input)
        {
            for (int i = 0; i <= input.Count - 1; i++)
            {
                var average = Math.Ceiling(input.Average());
                if (input[i] > average)
                {
                    input[i] += 1;
                }
                else if (input[i] <= average)
                {
                    input[i] -= 1;
                }
            }
            return input;
        }

        public static List<int> RemoveOddNumbers(List<int> input)
        {
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (input[i] % 2 != 0)
                {
                    input.Remove(input[i]);
                    i = 0;
                }
            }
            return input;
        }
    }
}
