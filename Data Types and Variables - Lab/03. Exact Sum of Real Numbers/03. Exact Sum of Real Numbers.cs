using System;

namespace _03.Exact_Sum_of_Real_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var persons = double.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());
            var coursesCount = persons / capacity;
            Console.WriteLine(Math.Ceiling(coursesCount));
        }
    }
}