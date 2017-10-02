using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                PrintLine(i, n);
            }

        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}