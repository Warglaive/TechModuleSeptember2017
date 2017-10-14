using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Array_Manipulator
{
    public class Program
    {
        public static void Main()
        {
            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var input = Console.ReadLine().Split(' ').ToList();
            var result = new List<int>(integers);
            var command = input[0];
            while (command != "print")
            {
                switch (command)
                {
                    case "add":
                        var index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);
                        AddElement(index, element, result);
                        break;
                    case "addMany":
                        var addManyIndex = int.Parse(input[1]);
                        AddSetOfElements(input, result, addManyIndex);
                        break;
                    case "contains":
                        var containsElement = int.Parse(input[1]);
                        Contains(containsElement, result);
                        break;
                    case "remove":
                        var removeIndex = int.Parse(input[1]);
                        RemoveIndex(removeIndex, result);
                        break;
                    case "shift":
                        var positions = int.Parse(input[1]);
                        ShiftPositions(positions, result);
                        break;
                    case "sumPairs":
                        SumPairs(result);
                        break;
                }
                input = Console.ReadLine().Split(' ').ToList();
                command = input[0];
            }
            Console.Write("[");
            Console.Write(string.Join(", ", result));
            Console.WriteLine("]");
        }

        private static void SumPairs(List<int> result)
        {
            for (int i = 0; i < result.Count - 1; i++)
            {
                var sum = result[i] + result[i + 1];
                result.RemoveAt(i);
                result.RemoveAt(i);
                result.Insert(i, sum);
            }
        }

        private static void ShiftPositions(int positions, List<int> result) //possible bug
        {
            for (int i = 0; i < positions; i++)
            {
                result.Add(result[0]);
                result.RemoveAt(0);
            }
        }

        private static void RemoveIndex(int removeIndex, List<int> result)
        {
            result.RemoveAt(removeIndex);
        }

        private static void Contains(int containsElement, List<int> result)
        {
            for (int i = 0; i <= result.Count - 1; i++)
            {
                if (result[i].Equals(containsElement))
                {
                    Console.WriteLine(i);
                    break;
                }
                if (i == result.Count - 1 && !result[i].Equals(containsElement))
                {
                    Console.WriteLine(-1);
                    break;
                }
            }
        }

        private static void AddSetOfElements(List<string> input, List<int> result, int addManyIndex)
        {
            var elementsToTake = input.Skip(2).Select(int.Parse); // new 

            result.InsertRange(addManyIndex, elementsToTake);

        }

        private static void AddElement(int index, int element, List<int> result)
        {
            result.Insert(index, element);
        }
    }
}