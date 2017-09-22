using System;

namespace _01.Passed
{
    public class Program
    {
       public static void Main()
        {
            var input = double.Parse(Console.ReadLine());
            bool passed = false;
            if (input>=3.00)
            {
                passed = true;
            }
            Console.WriteLine(passed==true ? "Passed!" : "");
        }
    }
}