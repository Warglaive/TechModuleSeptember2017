using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Sum_Reversed_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var result = new List<int>();
            foreach (var digit in input)
            {
                var currentDigitString = string.Empty;
                var num = digit.ToCharArray();
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    currentDigitString += num[i].ToString();
                }
                var currentDigitInt = int.Parse(currentDigitString);
                result.Add(currentDigitInt);
            }
            Console.WriteLine(result.Sum());
        }
    }
}