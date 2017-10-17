using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    public class Program
    {
        public static void Main()
        {
            var vault = new Dictionary<string, int>();
            for (int i = 0; ; i++)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                if (!vault.ContainsKey(resource))
                {
                    vault[resource] = 0;
                }
                vault[resource] += int.Parse(Console.ReadLine()); //it wasnt 'else' ... :D
            }
            foreach (var KvP in vault)
            {
                Console.WriteLine($"{KvP.Key} -> {KvP.Value}");
            }
        }
    }
}