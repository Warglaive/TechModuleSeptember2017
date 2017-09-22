using System;

namespace _09.MultiplicationTabl
{
    public class Program
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
