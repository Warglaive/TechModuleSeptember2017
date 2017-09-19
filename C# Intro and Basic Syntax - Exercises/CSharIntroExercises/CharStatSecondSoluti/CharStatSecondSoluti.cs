using System;

namespace CharStatSecondSoluti
{
    public class CharStatSecondSoluti
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
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', maximumHealth-currentHealth));
            Console.Write("|");
            //Energy
            Console.WriteLine();
            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maximumEnergy-currentEnergy));
            Console.Write("|");
        }
    }
}
