using System;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 0; i <= input.Count - 1; i++)
            {
                for (int j = 1; j <= input.Count - 1; j++)
                {
                    var currentCell = input[i];
                    var nextCell = input[j];
                    if (currentCell.Equals(nextCell))
                    {
                        var sum = currentCell + nextCell;
                        input.Remove(input[i]);
                        input.Remove(input[i]);
                        input.Insert(i, sum);
                        i = 0;
                        j = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}