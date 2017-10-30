using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _03.Camera_View
{
    public class Program
    {
        public static void Main()
        {
            var indices =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var inputLine = Console.ReadLine();

            int m = indices[0];
            int n = indices[1];
            var pattern = $"\\|\\<(.{{0,{m}}})(.{{0,{n}}})";
            var regex = new Regex(pattern);

            Match match = regex.Match(inputLine);

            var result = new List<string>();

            while (inputLine.Length > match.Index + 2 && match.Success)
            {
                string matchToAdd = match.Groups[2].Value;
                if (matchToAdd.Contains("|"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("|"));
                }
                if (matchToAdd.Contains("<"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("<"));
                }
                result.Add(matchToAdd);
                inputLine = inputLine.Substring(match.Index + 2);
                match = regex.Match(inputLine);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}