using System;

namespace _10.Triangle_of_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}