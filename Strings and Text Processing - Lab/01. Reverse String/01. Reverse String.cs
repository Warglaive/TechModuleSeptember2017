using System;
using System.Linq;

namespace _01.Reverse_String
{
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().ToCharArray().Reverse().ToArray();
            var reversed = entry.ToString();
            Console.WriteLine(string.Join("", reversed));
        }
    }
}