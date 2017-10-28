using System;
using System.Text.RegularExpressions;
namespace _04.Match_Dates
{
    public class Program
    {
        public static void Main()
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            foreach (Match date in Regex.Matches(input, pattern))
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}