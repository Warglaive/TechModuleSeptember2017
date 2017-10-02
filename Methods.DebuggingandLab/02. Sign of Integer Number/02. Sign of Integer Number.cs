using System;

namespace _02.Sign_of_Integer_Number
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        private static int PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            return number;
        }
    }
}