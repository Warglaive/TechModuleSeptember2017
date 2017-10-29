using System;
using System.Text.RegularExpressions;
namespace _01.Extract_Emails
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                var email = match.ToString();
                if (!(email.StartsWith(".")
                    || email.StartsWith("-")
                    || email.StartsWith("_")))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}