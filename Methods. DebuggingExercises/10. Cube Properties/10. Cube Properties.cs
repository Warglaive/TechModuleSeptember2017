using System;

namespace _10.Cube_Properties
{
    public class Program
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            if (type == "face")
            {
                var face = FaceDiagonalsLenght(side);
                Console.WriteLine("{0:f2}", face);
            }
            else if (type == "space")
            {
                var space = SpaceDiagonals(side);
                Console.WriteLine("{0:f2}", space);
            }
            else if (type == "volume")
            {
                var volume = VolumeDiagonal(side);
                Console.WriteLine("{0:f2}", volume);
            }
            else if (type == "area")
            {
                var area = GetArea(side);
                Console.WriteLine("{0:f2}", area);
            }
        }

        private static double GetArea(double side)
        {
            var area = 6 * Math.Pow(side, 2);
            return area;
        }

        public static double VolumeDiagonal(double side)
        {
            var volume = Math.Pow(side, 3);
            return volume;
        }

        public static double SpaceDiagonals(double side)
        {
            var space = Math.Sqrt(3 * Math.Pow(side, 2));
            return space;
        }

        public static double FaceDiagonalsLenght(double side)
        {
            var face = Math.Sqrt(2 * Math.Pow(side, 2));
            return face;
        }
    }
}