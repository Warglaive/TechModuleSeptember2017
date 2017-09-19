using System;

namespace _01.Debit_Card_Number
{
    public class Program
    {
       public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:d4} {secondNum:d4} {thirdNum:d4} {fourthNum:d4}");
        }
    }
}
