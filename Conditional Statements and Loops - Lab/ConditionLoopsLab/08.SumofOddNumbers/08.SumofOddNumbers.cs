using System;

namespace _08.SumofOddNumbers
{
    public class Program
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n*2; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
