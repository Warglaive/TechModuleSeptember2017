using System;

namespace _01.Charity_Marathon
{
    public class Program
    {
        public static void Main()
        {
            var marathonDayCount = long.Parse(Console.ReadLine());
            var runnersCount = long.Parse(Console.ReadLine());
            var lapCount = long.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());
            var maxRunners = trackCapacity * marathonDayCount;
            if (runnersCount < maxRunners)
            {
                maxRunners = runnersCount;
            }
            var totalKilometers = (maxRunners * lapCount * trackLenght) / 1000;

            var totalMoney = totalKilometers * moneyPerKilometer;
            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}