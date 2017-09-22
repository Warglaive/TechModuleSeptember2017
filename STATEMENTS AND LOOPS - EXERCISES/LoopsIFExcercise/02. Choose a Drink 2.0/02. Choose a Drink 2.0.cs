using System;

namespace _02.Choose_a_Drink_2._0
{
    public class Program
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0d;
            switch (profession)
            {
                case "Athlete": price = 0.70 * quantity;
                    Console.WriteLine($"The {profession} has to pay {price:f2}.");
                    break;
                case "SoftUni Student": price = 1.70 * quantity;
                    Console.WriteLine($"The {profession} has to pay {price:f2}.");
                    break;
                case "Businessman": price = 1.00 * quantity;
                    Console.WriteLine($"The {profession} has to pay {price:f2}.");
                    break;
                case "Businesswoman":  price = 1.00 * quantity;
                    Console.WriteLine($"The {profession} has to pay {price:f2}.");
                    break;
                default: price = 1.20 * quantity;
                    Console.WriteLine($"The {profession} has to pay {price:f2}.");
                    break;
            }
        }
    }
}
