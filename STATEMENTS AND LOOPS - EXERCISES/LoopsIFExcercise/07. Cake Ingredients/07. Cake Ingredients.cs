using System;

namespace _07.Cake_Ingredients
{
    public class Program
    {
        public static void Main()
        {
            var ingredients = Console.ReadLine();
            int counter = 0;
            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                ingredients = Console.ReadLine();
                counter++;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
