using System;

namespace _02.Max_Method
{
    public class Program
    {
        public static void Main()
        {
            var largestNum = 0;
            largestNum = GetMax(largestNum); 
            Console.WriteLine(largestNum);
        }
        private static int GetMax(int largetNum)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var result = Math.Max(Math.Max(firstNum, secondNum), thirdNum);
            return result;
        }
    }
}