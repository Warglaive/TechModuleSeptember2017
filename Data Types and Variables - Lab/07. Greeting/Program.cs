using System;

namespace _07.Greeting
{
    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var secondName = Console.ReadLine();
            var age = Console.ReadLine();
            Console.WriteLine($"Hello, {name} {secondName}. You are {age} years old.");
        }
    }
}