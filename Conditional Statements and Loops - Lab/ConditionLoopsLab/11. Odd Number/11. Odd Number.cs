using System;

namespace _11.Odd_Number
{
    public class Program
    {
       public static void Main()
        {
            var oddInput = int.Parse(Console.ReadLine());
            while (oddInput%2==0)
            {
                Console.WriteLine("Please write an odd number.");
                oddInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", Math.Abs(oddInput));
        }
    }
}