using System;
using System.Linq;

namespace _03.Text_Filter
{
    public class Program
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var input = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                if (input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(input);
        }
    }
}