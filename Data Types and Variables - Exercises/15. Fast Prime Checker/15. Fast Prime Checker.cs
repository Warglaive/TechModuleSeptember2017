using System;

namespace _15.Fast_Prime_Checker
{
    public class Program
    {
        public static void Main()
        {
            int entry = int.Parse(Console.ReadLine());
            for (int num = 2; num <= entry; num++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(num); j++)
                {
                    if (num % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime}");
            }
        }
    }
}