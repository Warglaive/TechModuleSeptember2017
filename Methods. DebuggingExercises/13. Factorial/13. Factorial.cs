using System;
using System.Numerics;

namespace _13.Factorial
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
            Console.WriteLine(bigInteger);
        }
    }
}