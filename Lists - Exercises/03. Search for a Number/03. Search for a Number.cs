using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Search_for_a_Number
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var takeResult = new List<int>();
            var takeCount = numbers[0];
            var deleteDigit = numbers[1];
            var searchForNumber = numbers[2];
            for (int i = 0; i < takeCount; i++)
            {
                takeResult.Add(input[i]);
            }
            takeResult.RemoveRange(0, deleteDigit);
            Console.WriteLine(takeResult.Contains(searchForNumber) ? "YES!" : "NO!");
        }
    }
}