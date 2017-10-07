using System;

namespace _06.Prime_Checker
{
    public class Program
    {
        public static void Main()
        {
            var n = Math.Abs(long.Parse(Console.ReadLine()));
            bool result = isPrime(n);
            Console.WriteLine(result);
        }
        private static bool isPrime(long number)
        {
            bool isPrime = !(number <= 1);
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}