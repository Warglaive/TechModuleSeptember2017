using System;

namespace _07.Math_Power
{
    public class Program
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());
            RaiseToPower(number, power);
        }

        public static void RaiseToPower(double number, double power)
        {
            var raiseToPower = Math.Pow(number, power);
            Console.WriteLine(raiseToPower);
        }
    }
}