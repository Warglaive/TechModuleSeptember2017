using System;

namespace _10.Multiplication2._0
{
    public class Program
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            var sum = 0;
            if (multiplier<=9)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    sum = n * i;
                    Console.WriteLine($"{n} X {i} = {sum}");
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    sum = n * multiplier;
                    Console.WriteLine($"{n} X {multiplier} = {sum}");
                }
            }
        }
    }
}
