using System;

namespace _07.Training_Hall_Equipment
{
    public class Program
    {
        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfitems = int.Parse(Console.ReadLine());
            var subtotal = 0d;
            for (int i = 0; i < numberOfitems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());
                subtotal += itemPrice * itemCount;
                Console.WriteLine(itemCount > 1 ? $"Adding {itemCount} {itemName}s to cart."
                    : $"Adding {itemCount} {itemName} to cart.");
            }
            Console.WriteLine("Subtotal: ${0:f2}", subtotal);
            Console.WriteLine(subtotal <= budget ? $"Money left: ${(Math.Abs(budget - subtotal)):f2}" : $"Not enough. We need ${(Math.Abs(budget - subtotal)):f2} more.");
        }
    }
}