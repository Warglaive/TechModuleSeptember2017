using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static bool isPrime(long number)
        {
            bool isPrime = true;
            if (number<=1)
            {
                isPrime = false;
            }
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