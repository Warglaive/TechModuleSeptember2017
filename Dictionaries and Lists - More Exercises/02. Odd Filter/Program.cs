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
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            RemoveOddNumbers(input);
            Convert(input);
            Console.WriteLine(string.Join(" ", input));
        }

        private static List<double> Convert(List<double> input)
        {
            for (int i = 0; i <= input.Count - 1; i++)
            {
                var min = input.Average();
                
                if (input[i] < min)
                {
                    input[i] -= 1;
                }
                else if (input[i] > min)
                {
                    input[i] += 1;
                }
            }
            return input;
        }

        public static List<double> RemoveOddNumbers(List<double> input)
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