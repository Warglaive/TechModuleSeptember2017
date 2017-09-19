using System;

namespace _04.Beverage_Labels
{
    public class Program
    {
       public static void Main()
        {
            var productName = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100 = double.Parse(Console.ReadLine());
            var sugarContentPer100 = double.Parse(Console.ReadLine());
            var energyAndSugarPerVolume = volume * energyContentPer100;
            double sugars = sugarContentPer100 *volume/100;
            Console.WriteLine($"{volume}ml {productName}: {Environment.NewLine + energyAndSugarPerVolume/100}kcal, {sugars}g sugars");
        }
    }
}
