using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Count_Numbers
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            var result = new Dictionary<int, int>();
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 0;
                }
                result[input[i]]++;
            }
            foreach (var KvP in result)
            {
                Console.Write(KvP.Key + " -> ");
                Console.WriteLine(KvP.Value);
            }
        }
    }
}