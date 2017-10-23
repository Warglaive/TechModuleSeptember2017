using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    public class Program
    {
        public static void Main()
        {
            //if reversed is the same
            var input = Console.ReadLine().Split(new[] { ' ', ',', '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = new List<string>();
            foreach (var word in input)
            {
                var reverse = word.ToCharArray().Reverse().ToArray();
                var reversedWord = new string(reverse);
                if (word == reversedWord)
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", result.Distinct().OrderBy(x => x)));
        }
    }
}