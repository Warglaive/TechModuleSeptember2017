using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    public class Program
    {
        public static void Main()
        {
            IsPrime();
        }
        public static void IsPrime()
        {
            var listedResult = new List<long>();
            var startNumber = long.Parse(Console.ReadLine());
            var endNumber = long.Parse(Console.ReadLine());
            for (long i = startNumber; i <= endNumber; i++)
            {
                var counter = 0;
                for (int j = 1; j <= endNumber; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    listedResult.Add(i);
                }
            }
            Console.WriteLine(string.Join(", ", listedResult));
        }
    }
}