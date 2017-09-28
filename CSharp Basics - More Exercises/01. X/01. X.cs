using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var formula = (n - 2) - 2;
            Console.Write('x');//firstLine
            Console.Write(new string(' ', n - 2));
            Console.WriteLine('x');

            for (int i = 1; i < n / 2; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write('x');
                Console.Write(new string(' ', ((n - 2) - i * 2)));
                Console.Write('x');
                Console.WriteLine(new string(' ', i));

            }

            Console.Write('x');//lastLineine
            Console.Write(new string(' ', n - 2));
            Console.WriteLine('x');
        }
    }
}
