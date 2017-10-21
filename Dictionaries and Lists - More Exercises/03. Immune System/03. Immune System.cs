using System;
using System.Collections.Generic;

namespace _03.Immune_System
{
    public class Program
    {
        public static void Main()
        {
            var immuneSystemInitialHealth = double.Parse(Console.ReadLine());
            var healthStore = new List<double>();
            healthStore.Add(immuneSystemInitialHealth);
            var virusNames = new List<string>();
            var virusName = Console.ReadLine();
            while (virusName != "end")
            {
                immuneSystemInitialHealth = healthStore[0];
                var tempStrenght = 0;
                //virusStrenght
                foreach (var letter in virusName)
                {
                    tempStrenght += letter;
                }
                var virusStrength = tempStrenght / 3;
                //Time To Defeat - power * namelenght
                var timeToDefeat = 0;
                if (virusNames.Contains(virusName))
                {
                    timeToDefeat = (virusStrength * virusName.Length) / 3;
                }
                else
                {
                    timeToDefeat = virusStrength * virusName.Length;
                }//calc healt
                var currentHealth = healthStore[0] - timeToDefeat;
                var timeInMinutes = TimeSpan.FromSeconds(timeToDefeat);
                if (timeInMinutes.Hours > 0)
                {
                    var HrsToMin = timeInMinutes.Minutes + (timeInMinutes.Hours * 60);
                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeat} seconds");
                    if (currentHealth < 1) // if dead
                    {
                        Console.WriteLine($"Immune System Defeated.");
                        break;
                    }
                    Console.WriteLine($"{virusName} defeated in {HrsToMin}m {timeInMinutes.Seconds}s.");
                }
                else
                {
                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeat} seconds");
                    if (currentHealth < 1) // if dead
                    {
                        Console.WriteLine($"Immune System Defeated.");
                        break;
                    }
                    Console.WriteLine($"{virusName} defeated in {timeInMinutes.Minutes}m {timeInMinutes.Seconds}s.");
                }
                Console.WriteLine($"Remaining health: {Math.Floor(currentHealth)}");
                healthStore[0] = (int)currentHealth + ((int)currentHealth * 0.20);

                if (healthStore[0] > immuneSystemInitialHealth)
                {
                    healthStore[0] = immuneSystemInitialHealth;
                }
                virusNames.Add(virusName);
                virusName = Console.ReadLine();
            }
            if (virusName == "end")
            {
                Console.WriteLine($"Final Health: {(int)healthStore[0]}");
            }
        }
    }
}