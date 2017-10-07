using System;

namespace _05.Fibonacci_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = FibunaciNumber(n);
            if (result == 0) 
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine(result);
        }

        public static int FibunaciNumber(int n)
        {
            int first = 0;
            int second = 1;
            int third = 0;
            for (int i = 0; i < n; i++)
            {
                third = first + second;
                first = second;
                second = third;
            }
            return third;
        }
    }
}