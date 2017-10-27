using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _03.Match_Hexadecimal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern).Cast<Match>().ToList();
            Console.WriteLine(string.Join(" ", matches));
        }
    }
}