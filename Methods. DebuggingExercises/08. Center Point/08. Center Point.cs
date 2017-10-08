using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Center_Point
{
    public class Program
    {
        public static void Main()
        {
            ClosestToTheCentre();
        }

        private static void ClosestToTheCentre()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var result = new List<double>();
            if (Math.Abs(x1) > Math.Abs(x2))
            {
                result.Add(x2);
            }
            else if (Math.Abs(x1) < Math.Abs(x2))
            {
                result.Add(x1);
            }
            else
            {
                result.Add(x2);
            }
            if (Math.Abs(y1) > Math.Abs(y2))
            {
                result.Add(y2);
            }
            else if (Math.Abs(y1) < Math.Abs(y2))
            {
                result.Add(y1);
            }
            else
            {
                result.Add(y2);
            }
            var resultx = result.Distinct().ToList();
            if (resultx.Count > 1)
            {
                Console.WriteLine("(" + string.Join(", ", resultx) + ")");
            }
            else
            {
                Console.WriteLine("(" + $"{string.Join("", resultx)}" + ", " + ")");
            }
        }
    }
}