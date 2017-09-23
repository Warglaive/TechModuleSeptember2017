using System;

namespace _06.Interval_of_Numbers
{
    public class Program
    {
       public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            var biggestNum = Math.Max(firstNum, secondNum);
            var smallerNum = Math.Min(firstNum, secondNum);

            for (int i = smallerNum; i <= biggestNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
