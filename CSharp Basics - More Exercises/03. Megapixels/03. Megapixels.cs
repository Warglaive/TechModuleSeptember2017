using System;
namespace _03.Megapixels
{
    public class Program
    {
        public static void Main()
        {
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());
            var count = (width * height) / 1000000m;
            Console.WriteLine($"{width}x{height} => {Math.Round(count, 1)}MP");
        }
    }
}