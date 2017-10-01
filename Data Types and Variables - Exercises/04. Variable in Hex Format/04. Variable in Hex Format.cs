using System;

namespace _04.Variable_in_Hex_Format
{
    public class Program
    {
        public static void Main()
        {
            var n = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(n, 16));
        }
    }
}