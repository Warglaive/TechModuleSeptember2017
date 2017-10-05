using System;

namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new string[7];
            arr[0] = "Monday";
            arr[1] = "Tuesday";
            arr[2] = "Wednesday";
            arr[3] = "Thursday";
            arr[4] = "Friday";
            arr[5] = "Saturday";
            arr[6] = "Sunday";
            for (int i = 0; i < arr.Length; i++)
            {
                if (n == i+1)
                {
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    Console.WriteLine("Invalid Day!");
                }
            }
        }
    }
}