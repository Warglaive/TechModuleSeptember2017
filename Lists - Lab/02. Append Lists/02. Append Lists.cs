using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Append_Lists
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { '|' })
                .ToList();
            var result = new List<string>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                var splitValues = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                for (int j = 0; j <= splitValues.Count - 1; j++)
                {
                    result.Add(splitValues[j]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}