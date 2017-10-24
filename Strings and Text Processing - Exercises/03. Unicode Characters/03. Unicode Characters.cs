using System;

namespace _03.Unicode_Characters
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var toChars = input.ToCharArray();
            foreach (var letter in toChars)
            {
                Console.Write("\\u" + ((int)letter).ToString("x4"));
            }
            Console.WriteLine();
        }
    }
}