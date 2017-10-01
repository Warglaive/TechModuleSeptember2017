using System;

namespace _06.Strings_And_Objects
{
    public class Program
    {
        public static void Main()
        {
            string one = "Hello";
            string two = "World";
            object concat = one + " " + two;
            string third = (string)concat;
            Console.WriteLine(third);
        }
    }
}