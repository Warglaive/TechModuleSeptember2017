using System;

namespace _05.Temperature_Conversion
{
    public class Program
    {
        public static void Main()
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            ConvertFromFahrenheitToCelsius(fahrenheit);
        }

        public static void ConvertFromFahrenheitToCelsius(double fahrenheit)
        {
            var celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("{0:f2}", celsius);
        }
    }
}