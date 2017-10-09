using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Remove_Negatives_and_Reverse
{
    public class Program
    {
        public static void Main()
        {
            var inpput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            inpput.Reverse();
            for (int i = 0; i <= inpput.Count - 1; i++)
            {
                if (inpput[i] > 0)
                {
                    result.Add(inpput[i]);
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}