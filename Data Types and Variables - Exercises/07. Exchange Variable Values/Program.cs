using System;

namespace _07.Exchange_Variable_Values
{
    public class Program
    {
        public static void Main()
        {
            var a = 5;
            var b = 10;
            Console.WriteLine($"Before: " +
                Environment.NewLine +
                $"a = {a}" +
                Environment.NewLine +
                $"b = {b}");
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After: " + Environment.NewLine + $"a = {a}" + Environment.NewLine + $"b = {b}");
        }
    }
}