using System;
using System.Text.RegularExpressions;
namespace _01.Match_Full_Name
{
    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine();
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var match = Regex.Matches(names, pattern);
            foreach (var name in match)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}