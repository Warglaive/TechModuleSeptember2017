using System;
using System.Text.RegularExpressions;
namespace _05.Key_Replacer
{
    public class Program
    {
        public static void Main()
        {
            var keyString = Console.ReadLine();
            var textString = Console.ReadLine();
            var keyPattern = @"^([A-Za-z]+)(?:[\\|<])(?:.*)(?:[\\|<])([A-Za-z]+)$";

            var keyMatch = Regex.Match(keyString, keyPattern);
            if (keyMatch.Success)//take 2 words to look between them
            {
                var startKey = keyMatch.Groups[1].Value;
                var endKey = keyMatch.Groups[2].Value;

                var textPattern = $"{startKey}(?<word>.*?){endKey}";
                var matches = Regex.Matches(textString, textPattern);

                var result = string.Empty;

                foreach (Match wordMatch in matches)
                {
                    result += wordMatch.Groups["word"];
                }
                if (result.Length > 0)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Empty result");
                }
            }
        }
    }
}