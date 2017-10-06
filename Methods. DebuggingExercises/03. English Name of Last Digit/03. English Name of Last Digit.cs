using System;

namespace _03.English_Name_of_Last_Digit
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = LastDigit(input);
            var print = PrintResult(result);
            Console.WriteLine(print);
        }

        private static string PrintResult(string result)
        {
            var digit = string.Empty;
            if (result == "1")
            {
                digit = "one";
            }
            else if (result == "2")
            {
                digit = "two";
            }
            else if (result == "3")
            {
                digit = "three";
            }
            else if (result == "4")
            {
                digit = "four";
            }
            else if (result == "5")
            {
                digit = "five";
            }
            else if (result == "6")
            {
                digit = "six";
            }
            else if (result == "7")
            {
                digit = "seven";
            }
            else if (result == "8")
            {
                digit = "eight";
            }
            else if (result == "9")
            {
                digit = "nine";
            }
            else if (result == "0")
            {
                digit = "zero";
            }
            return digit;
        }

        public static string LastDigit(string input)
        {
            char lastDigit = input[input.Length - 1];
            return lastDigit.ToString();
        }
    }
}