using System;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    public class Program
    {
        public static void Main()
        {
            var baseAndNum = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            BigInteger reminder = 0;
            var result = string.Empty;
            BigInteger n = baseAndNum[0];
            BigInteger number = baseAndNum[1];
            while (number > 0)
            {
                reminder = number % n;
                number /= n;
                result = reminder + result;
            }
            Console.WriteLine(result);
        }
    }
}