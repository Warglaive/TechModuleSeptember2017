using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"\+359 2 \d{3} \d{4}\b|\+359-2-\d{3}-\d{4}\b";
            var input = Console.ReadLine();
            var phoneMatches = Regex.Matches(input, pattern);
            var matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToList();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}