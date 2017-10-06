using System;

namespace _06.Calculate_Triangle_Area
{
    public class Program
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = Area(width, height);
            Console.WriteLine(area);
        }

        public static double Area(double width, double height)
        {
            var area = width * height / 2;
            return area;
        }
    }
}