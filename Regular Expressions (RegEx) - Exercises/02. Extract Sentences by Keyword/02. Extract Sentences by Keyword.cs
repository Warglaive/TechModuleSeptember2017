using System;
using System.Text.RegularExpressions;
namespace _02.Extract_Sentences_by_Keyword
{
    public class Program
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var input = Console.ReadLine().Split(new[] { '.', '!', '?' }
            , StringSplitOptions.RemoveEmptyEntries);
            var pattern = "\\b" + word + "\\b";
            foreach (var sequenceMatch in input)
            {
                if (Regex.IsMatch(sequenceMatch, pattern))
                {
                    Console.WriteLine(sequenceMatch.Trim());
                }
            }
        }
    }
}