using System;

namespace _12.Test_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var formedNumber = 0;
            var totalSum = 0;
            var product = 0;
            var combinationCount = 0;
            for (int firstDigit = N; firstDigit >= 1; firstDigit--)
            {
                if (totalSum >= maxSum)
                {
                    break;
                }
                for (int secondDigit = 1; secondDigit <= M; secondDigit++)
                {
                    if (totalSum >= maxSum)
                    {
                        break;
                    }
                    formedNumber = firstDigit * secondDigit;
                    product = formedNumber * 3;
                    totalSum += product;
                    combinationCount++;
                }
            }
            Console.WriteLine($"{combinationCount} combinations");
            if (totalSum >= maxSum)
            {
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}