using System;

namespace _14.Integer_to_Hex_and_Binary
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:X}",number);
            Console.WriteLine($"{Convert.ToString(number,2)}");
        }
    }
}