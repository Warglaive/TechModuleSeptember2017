using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _06.Replace_a_Tag
{
    public class Program
    {
        public static void Main()
        {
            string pattern = @"(?<first>.*)(?<open><a)(?<href>.*)(?<mid>>)(?<softUni>.*)(?<close><\/a>)(?<last>.*)";
            var input = Console.ReadLine();
            var totalResult = new List<string>();
            var firstReplacement = @"[URL";
            var midReplacement = @"]";
            var secondReplacement = @"[/URL]";
            var result = string.Empty;
            while (input != "end")
            {
                bool isMatch = false;
                var rgx = new Regex(input);
                foreach (Match tagMatch in Regex.Matches(input, pattern))
                {
                    isMatch = true;
                    var first = tagMatch.Groups["first"].Value;
                    var href = tagMatch.Groups["href"].Value;
                    var SoftUni = tagMatch.Groups["softUni"].Value;
                    var last = tagMatch.Groups["last"].Value;
                    result += first;
                    result += rgx.Replace(input, firstReplacement);
                    result += href;
                    result += rgx.Replace(input, midReplacement);
                    result += SoftUni;
                    result += rgx.Replace(input, secondReplacement);
                    result += last;
                    totalResult.Add(result);
                }
                if (!isMatch)
                {
                    totalResult.Add(input);
                }
                input = Console.ReadLine();
            }
            foreach (var word in totalResult)
            {
                Console.WriteLine(word);
            }
        }
    }
}