using System;

namespace _09.Refactor_Special_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= num; i++)
            {
                var currentNum = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                var special = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{currentNum} -> {special}");
                total = 0;
                i = currentNum;
            }
        }
    }
}
