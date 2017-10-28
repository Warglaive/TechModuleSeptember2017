using System;
using System.Text.RegularExpressions;
namespace _05.Match_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.?\d+)?($|(?=\s))";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            foreach (Match numMatch in matches)
            {
                Console.Write(numMatch + " ");
            }
            Console.WriteLine();
        }
    }
}