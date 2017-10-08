using System;

namespace _09.Longer_Line
{
    public class Program
    {
        public static void Main()
        {
            NearestToCenter();
            LongerLine();
        }

        private static void LongerLine()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());



        }

        private static void NearestToCenter()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x1Abs = Math.Abs(x1);
            double y1Abs = Math.Abs(y1);
            double x2Abs = Math.Abs(x2);
            double y2Abs = Math.Abs(y2);
            Console.WriteLine(x1Abs + y1Abs <= x2Abs + y2Abs ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }

    }
}
