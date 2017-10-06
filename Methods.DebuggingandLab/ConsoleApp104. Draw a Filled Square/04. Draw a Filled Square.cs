using System;

namespace ConsoleApp104.Draw_a_Filled_Square
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintTopAndBottom(n);
            PrintMiddleRow(n);
            PrintTopAndBottom(n);
        }

        public static void PrintTopAndBottom(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        public static void PrintMiddleRow(int n)
        {
            for (int j = 0; j < n-2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}