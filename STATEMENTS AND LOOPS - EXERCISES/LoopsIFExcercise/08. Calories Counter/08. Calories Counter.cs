using System;

namespace _08.Calories_Counter
{
    public class Program
    {
        public static void Main()
        {
            var total = 0d;

            var ingradientsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < ingradientsCount; i++)
            {
                var ingredients = Console.ReadLine().ToLower();
                switch (ingredients)
                {
                    case "cheese":
                        total += 500;
                        break;
                    case "tomato sauce":
                        total += 150;
                        break;
                    case "salami":
                        total += 600;
                        break;
                    case "pepper":
                        total += 50;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {total}");
        }
    }
}
