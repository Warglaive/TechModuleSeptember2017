using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Character_Multiplier
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var firstWord = input[0].ToList();
            var secondWord = input[1].ToList();

            var leftLetters = new List<char>();

            var shortestWord = Math.Min(firstWord.Count, secondWord.Count);
            var biggestWord = new List<char>();

            if (firstWord.Count > secondWord.Count)
            {
                biggestWord = firstWord;
            }
            else
            {
                biggestWord = secondWord;
            }

            var totalSum = 0;

            for (int i = 0; i < shortestWord; i++)
            {
                var multiply = firstWord[i] * secondWord[i];
                totalSum += multiply;
                leftLetters = biggestWord.Skip(i + 1).ToList();
            }
            foreach (var letter in leftLetters)
            {
                totalSum += letter;
            }
            Console.WriteLine(totalSum);
        }
    }
}