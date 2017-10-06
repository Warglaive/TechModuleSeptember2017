using System;

namespace _09.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Print(number);
        }

        public static void Print(int number)
        {
            int oddDigitsSum = SumOfOddDigits(number);
            int evenDigitsSum = SumOfEvenDigits(number);
            Console.WriteLine(oddDigitsSum * evenDigitsSum);
        }

        public static int SumOfOddDigits(int number)
        {
            var sumOfOddDigits = 0;
            while (number > 0)
            {
                var lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOfOddDigits += lastDigit;
                }
                number /= 10;
            }
            return sumOfOddDigits;
        }

        public static int SumOfEvenDigits(int number)
        {
            var sumOfEvenDigits = 0;
            while (number > 0)
            {
                var lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumOfEvenDigits += lastDigit;
                }
                number /= 10;
            }
            return sumOfEvenDigits;
        }
    }
}