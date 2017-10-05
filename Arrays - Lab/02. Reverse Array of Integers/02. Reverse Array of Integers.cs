using System;

namespace _02.Reverse_Array_of_Integers
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for (int i = n - 1; i >= 0; i--)//readFromConsole and put into array
            {
                var currentNum = int.Parse(Console.ReadLine());
                arr[i] = currentNum;
            }
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}