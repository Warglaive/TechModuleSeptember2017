using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.User_Logs
{
    public class Program
    {
        public static void Main()
        {
            var result = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine().Split(new[] { " ", "IP=", "message=", "user=" }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "end")
            {
                var counter = 1;
                var IP = input[0];
                var message = input[1];
                var username = input[2];
                if (!result.ContainsKey(username))
                {
                    result.Add(username, new Dictionary<string, int>());
                }
                if (!result[username].ContainsKey(IP))
                {
                    result[username].Add(IP, 0);
                }
                result[username][IP] += counter;
                input = Console.ReadLine().Split(new[] { " ", "IP=", "message=", "user=" }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var outerPair in result)
            {
                Console.WriteLine($"{outerPair.Key}: ");

                var counter = outerPair.Value.Count; 
                foreach (var IPAndCOunter in outerPair.Value)
                {
                    if (counter != 1)
                    {
                        Console.Write($"{IPAndCOunter.Key} => {IPAndCOunter.Value}, ");
                        --counter;
                    }
                    else
                    {
                        Console.WriteLine($"{IPAndCOunter.Key} => {string.Join(", ", IPAndCOunter.Value)}.");
                    }
                }
            }
        }
    }
}