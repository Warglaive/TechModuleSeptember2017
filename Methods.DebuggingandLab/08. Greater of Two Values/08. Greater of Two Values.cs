using System;

namespace _08.Greater_of_Two_Values
{
    public class Program
    {
        public static void Main()
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                var firstValue = int.Parse(Console.ReadLine());
                var secondValue = int.Parse(Console.ReadLine());
                GetMax(firstValue, secondValue);
            }
            else if (type == "char")
            {
                var firstValue = char.Parse(Console.ReadLine());
                var secondValue = char.Parse(Console.ReadLine());
                GetMax(firstValue, secondValue);
            }
            else if (type == "string")
            {
                var firstValue = Console.ReadLine();
                var secondValue = Console.ReadLine();
                GetMax(firstValue, secondValue);
            }
        }

        public static void GetMax(int firstValue, int secondValue)//case int
        {
            var biggestNum = Math.Max(firstValue, secondValue);
            Console.WriteLine(biggestNum);
        }
        public static void GetMax(char firstValue, char secondValue)//case char
        {
            var biggestChar = Math.Max(firstValue, secondValue);
            Console.WriteLine((char)biggestChar);
        }

        public static void GetMax(string firstValue, string SecondValue)//case string
        {
            if (firstValue.CompareTo(SecondValue) >= 0)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(SecondValue);
            }
        }
    }
}