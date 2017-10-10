using System;

namespace _11.Geometry_Calculator
{
    public class Program
    {
        public static void Main()
        {
            var figureType = Console.ReadLine().ToLower();
            switch (figureType)
            {
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var triangeHeight = double.Parse(Console.ReadLine());
                    var triangleArea = TriangleArea(triangleSide, triangeHeight);
                    Console.WriteLine("{0:f2}", triangleArea);
                    break;
                case "square":
                    var squareSide = double.Parse(Console.ReadLine());
                    var squareArea = SquareArea(squareSide);
                    Console.WriteLine("{0:f2}", squareArea);
                    break;
                case "rectangle":
                    var rectangleWidth = double.Parse(Console.ReadLine());
                    var rectangleHeight = double.Parse(Console.ReadLine());
                    var rectangleArea = RectangleArea(rectangleWidth, rectangleHeight);
                    Console.WriteLine("{0:f2}", rectangleArea);
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    var circleArea = CircleRadius(radius);
                    Console.WriteLine("{0:f2}", circleArea);
                    break;
            }
        }

        private static double CircleRadius(double radius)
        {
            var circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }

        private static double RectangleArea(double rectangleWidth, double rectangleHeight)
        {
            var rectangleArea = rectangleWidth * rectangleHeight;
            return rectangleArea;
        }

        private static double SquareArea(double squareSide)
        {
            var squareArea = Math.Pow(squareSide, 2);
            return squareArea;
        }

        private static double TriangleArea(double width, double height)
        {
            var triangleArea = 0.5 * width * height;
            return triangleArea;
        }
    }
}