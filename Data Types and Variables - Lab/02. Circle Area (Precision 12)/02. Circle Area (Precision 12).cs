using System;

namespace _02.Circle_Area__Precision_12_
{
    public class Program
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("{0:f12}", area);
        }
    }
}