using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commandAndValue = Console.ReadLine().Split(' ').ToList();
            var command = commandAndValue[0];
            var result = new List<int>();
            while (command != "Odd" && command != "Even")
            {
                switch (command)
                {
                    case "Delete":
                        var element = int.Parse(commandAndValue[1]);
                        Delete(element, input);
                        break;//
                    case "Insert":
                        var insertElement = int.Parse(commandAndValue[1]);
                        var position = int.Parse(commandAndValue[2]);
                        Insert(insertElement, position, input);
                        break;
                }

                commandAndValue = Console.ReadLine().Split(' ').ToList();
                command = commandAndValue[0];
            }
            if (command == "Odd")
            {
                PrintOdd(input, result);
            }
            else
            {
                PrintEven(input, result);
            }
        }

        private static void PrintEven(List<int> input, List<int> result)
        {
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (input[i] % 2 == 0)
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void PrintOdd(List<int> input, List<int> resultOdd)
        {
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (input[i] % 2 != 0)
                {
                    resultOdd.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(" ", resultOdd));
        }

        public static void Delete(int element, List<int> input)
        {
            for (int i = 0; i <= input.Count - 1; i++)
            {
                if (input[i].Equals(element))
                {
                    input.Remove(element);
                    i = 0;
                }
            }
        }
        public static void Insert(int insertElement, int position, List<int> input)
        {
            input.Insert(position, insertElement);
        }
    }
}