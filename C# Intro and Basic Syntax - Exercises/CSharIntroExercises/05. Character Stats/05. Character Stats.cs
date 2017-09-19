using System;

namespace _05.Character_Stats
{
    public class Program
    {
       public static void Main()
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            Console.Write("Health: |");
                for (int i = 0; i < currentHealth; i++)
                {
                Console.Write("|");
                }
            for (int i = 0; i < maximumHealth-currentHealth; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
            //Energy
            Console.Write("Energy: |");
            for (int i = 0; i < currentEnergy; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maximumEnergy-currentEnergy; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");
        }
    }
}