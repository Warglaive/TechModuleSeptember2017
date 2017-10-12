using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Min__Max__Sum__Average
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var storage = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                storage.Add(currentNum);
            }
            Console.WriteLine("Sum = " + storage.Sum());
            Console.WriteLine("Min = " + storage.Min());
            Console.WriteLine("Max = " + storage.Max());
            Console.WriteLine("Average = " + storage.Average());
        }
    }
}