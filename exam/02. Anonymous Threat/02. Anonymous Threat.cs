using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Anonymous_Threat
{
   public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var result = new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "3:1")
                {
                    break;
                }
                var currentLine = inputLine.Split(' ').ToList();
                var command = currentLine[0];
                var startIndex = int.Parse(currentLine[1]);
                var endIndex = int.Parse(currentLine[2]);
                switch (command)
                {
                    case "merge":
                        result = Merge(input, startIndex, endIndex, result);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<string> Merge(List<string> input, int startIndex, int endIndex, List<string> result)
        {
            string currentWord = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                currentWord += input[i];
            }
            input.RemoveRange(startIndex, endIndex + 1);
            result.Add(currentWord);
            input.Insert(0, currentWord);
            return result;
        }
    }
}