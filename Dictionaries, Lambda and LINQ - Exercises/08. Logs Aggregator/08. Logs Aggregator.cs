using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    public class Program
    {
        public static void Main()
        {
            var result = new SortedDictionary<string, SortedDictionary<string, int>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var IP = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);

                if (!result.ContainsKey(user))
                {
                    result.Add(user, new SortedDictionary<string, int>());
                }
                if (!result[user].ContainsKey(IP))
                {
                    result[user][IP] = 0;
                }
                result[user][IP] += duration;
            }
            foreach (var KvP in result)
            {
                Console.WriteLine($"{KvP.Key}: {KvP.Value.Values.Sum()} [{string.Join(", ", KvP.Value.Keys)}]");
            }
        }
    }
}