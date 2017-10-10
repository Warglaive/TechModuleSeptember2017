using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger bigInteger = 1;
            for (int i = n; i >= 1; i--)
            {
                bigInteger *= i;
            }
            var number = bigInteger;
            var zeroCounter = 0;
            BigInteger digit = 0;
            while (digit == 0)
            {
                digit = number % 10;
                number = number / 10;
                if (digit == 0)
                {
                    zeroCounter++;
                }
            }
            Console.WriteLine(zeroCounter);
        }
    }
}