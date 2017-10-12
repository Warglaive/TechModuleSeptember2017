using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToList();
            var dict = new Dictionary<string, int>();
            foreach (var num in input)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }
                dict[num]++;
            }
            var listResult = new List<string>();
            foreach (var pair in dict)
            {
                if (pair.Value % 2 == 1)
                {
                    listResult.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", listResult));
        }
    }
}