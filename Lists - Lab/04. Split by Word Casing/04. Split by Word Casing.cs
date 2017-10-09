using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Split_by_Word_Casing
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ',', ' ', ':', '.', ';', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

            var uppercaseResult = new List<string>();
            var mixedcaseResult = new List<string>();
            var lowercaseResult = new List<string>();



            foreach (var word in input)
            {
                var lowercaseLetterCounter = 0;
                var uppercaseLetterCounter = 0;
                for (int i = 0; i <= word.Length - 1; i++)
                {
                    if (word[i] >= 97 && word[i] <= 122)
                    {
                        lowercaseLetterCounter++;
                    }
                    else if (word[i] < 65) //special check - mixed
                    {
                        //lowercaseLetterCounter++;
                    }
                    else
                    {
                        uppercaseLetterCounter++;
                    }
                }
                if (uppercaseLetterCounter == word.Length)
                {
                    uppercaseResult.Add(word);
                }
                else if (lowercaseLetterCounter == word.Length)
                {
                    lowercaseResult.Add(word);
                }
                else
                {
                    mixedcaseResult.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowercaseResult));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedcaseResult));
            Console.WriteLine("Upper-case: " + string.Join(", ", uppercaseResult));
        }
    }
}