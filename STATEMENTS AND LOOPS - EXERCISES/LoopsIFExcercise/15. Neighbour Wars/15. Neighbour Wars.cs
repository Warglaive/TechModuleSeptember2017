using System;

namespace _15.Neighbour_Wars
{
    public class Program
    {
        public static void Main()
        {
            var goshoHP = 100;
            var peshoHP = 100;
            var roundCounter = 0;

            var peshoDMG = int.Parse(Console.ReadLine());
            var goshoDMG = int.Parse(Console.ReadLine());
            while (goshoHP > 0 || peshoHP > 0)
            {
                if (roundCounter % 2 == 0) // if even
                {
                    goshoHP -= peshoDMG;
                    if (goshoHP <= 0)
                    {
                        Console.WriteLine($"Pesho won in {roundCounter+1}th round.");
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP} health.");
                }
                else
                {
                    peshoHP -= goshoDMG;
                    if (peshoHP <= 0)
                    {
                        Console.WriteLine($"Gosho won in {roundCounter+1}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHP} health.");
                }
                roundCounter++;
                if (roundCounter % 3 == 0)
                {
                    goshoHP += 10;
                    peshoHP += 10;
                }
            }
        }
    }
}