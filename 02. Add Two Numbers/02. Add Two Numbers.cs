using System;
namespace _02.Add_Two_Numbers
{
    public class Program
    {
       public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = firstNum + secondNum;
            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);
        }
    }
}