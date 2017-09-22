using System;

namespace _01.Choose_a_Drink
{
    public class Program
    {
       public static void Main()
        {
            var proffesion = Console.ReadLine();
            switch (proffesion)
            {
                case "Athlete": Console.WriteLine("Water");
                    break;
                case "Businessman": Console.WriteLine("Coffee");
                    break;

                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;

                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
