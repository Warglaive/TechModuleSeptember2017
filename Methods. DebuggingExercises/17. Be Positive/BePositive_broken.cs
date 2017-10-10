using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        var countSequences = long.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            var input = new List<int>();
            var letsParse = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            bool anyNumsFound = false;
            for (int j = 0; j <= letsParse.Count - 1; j++)
            {
                int number;
                if (int.TryParse(letsParse[j], out number))
                {
                    input.Add(number);
                    anyNumsFound = true;
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }

            bool found = false;
            if (anyNumsFound)
            {

                for (int j = 0; j <= input.Count - 1; j++)
                {
                    int currentNum = input[j];

                    if (currentNum > -1)
                    {
                        Console.Write(currentNum + " ");

                        found = true;
                    }
                    else if (j + 1 == input.Count)
                    {
                        continue;
                    }
                    else
                    {
                        currentNum += input[j + 1];

                        if (currentNum > -1)
                        {
                            Console.Write(currentNum + " ");
                            found = true;
                        }
                        j += 1;
                    }
                    if (j >= input.Count - 1 && found)
                    {
                        Console.WriteLine();
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}