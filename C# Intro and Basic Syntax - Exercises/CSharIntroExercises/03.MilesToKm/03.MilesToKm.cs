using System;

namespace _03.MilesToKm
{
    public class Program
    {
       public static void Main()
        {
            var input = double.Parse(Console.ReadLine());
            var kmToMile = input * 1.60934;
            Console.WriteLine($"{kmToMile:f2}");
        }
    }
}
