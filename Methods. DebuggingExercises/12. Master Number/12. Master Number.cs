using System;

namespace _12.Master_Number
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                var isSymetric = IsSymetric(i); //Is symmetric (palindrome) if true = print
                var isDivisibleBy7 = SumOfDigitsDevisibleBy7(i);
                var gotEvenDigits = GotEvenDigits(i);
                if (isSymetric && isDivisibleBy7 && gotEvenDigits)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool GotEvenDigits(int number)
        {
            bool gotEvenDigit = false;
            while (number > 0)
            {
                var digit = number % 10;
                number = number / 10;
                if (digit % 2 == 0)
                {
                    gotEvenDigit = true;
                    break;
                }
            }
            return gotEvenDigit;
        }

        private static bool SumOfDigitsDevisibleBy7(int number)
        {
            bool isDivisibleBy7 = false;
            var sum = 0;
            while (number > 0)//sum digits of num
            {
                var digit = number % 10;
                number = number / 10;
                sum += digit;
            }
            if (sum % 7 == 0) //division check
            {
                isDivisibleBy7 = true;
            }
            return isDivisibleBy7;
        }

        public static bool IsSymetric(int number)
        {
            bool isSymetric = false;
            var n = number;
            var rev = 0;
            while (number > 0)
            {
                var dig = number % 10;
                rev = rev * 10 + dig;
                number = number / 10;
            }
            if (n == rev)
            {
                isSymetric = true;

            }

            return isSymetric;
        }
    }
}