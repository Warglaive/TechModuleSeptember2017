using System;

namespace _01.X
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write('x'); //firstLine
            Console.Write(new string(' ', n - 2));
            Console.WriteLine('x');

            for (var i = 1; i < n / 2; i++) //firstPart
            {
                Console.Write(new string(' ', i));
                Console.Write('x');
                Console.Write(new string(' ', n - 2 - i * 2));
                Console.Write('x');
                Console.WriteLine(new string(' ', i));
            }
            //MidPart
            for (var i = 0; i < 1; i++)
            {
                Console.Write(new string(' ', n / 2));
                Console.WriteLine('x');
            }
            //secondPart
            for (var i = n / 2 - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', i));
                Console.Write('x');
                Console.Write(new string(' ', n - 2 - i * 2));
                Console.Write('x');
                Console.WriteLine(new string(' ', i));
            }
            //lastLineine
            Console.Write('x');
            Console.Write(new string(' ', n - 2));
            Console.WriteLine('x');
        }
    }
}