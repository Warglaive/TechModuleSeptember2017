using System;

namespace _01.Hello__Name_
{
    public class Program
    {
        public static void Main()
        {
            ReceiveAndPrint();
        }

        private static void ReceiveAndPrint()
        {
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}