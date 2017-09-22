using System;

namespace _12.Number_Checker
{
    public class Program
    {
       public static void Main()
        {
            var n = Console.ReadLine();
            var theNum = 0;
            var isANum = int.TryParse(n, out theNum);
            Console.WriteLine(isANum == true ? "It is a number." : "Invalid input!");
        }
    }
}