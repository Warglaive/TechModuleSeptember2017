using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var placeHolders = Console.ReadLine();
            var firstWordPattern = @"[A-Za-z]+";
            var matches = Regex.Matches(input, firstWordPattern);

            foreach (Match wordMatch in matches)
            {
                var pattern = @"";
            }
        }
    }
}