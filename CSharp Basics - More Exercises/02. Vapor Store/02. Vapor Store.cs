using System;

namespace _02.Vapor_Store
{
    public class Program
    {
        public static void Main()
        {
            var currentBallance = decimal.Parse(Console.ReadLine());
            var totalMoney = currentBallance;
            var moneySpend = 0m;
            if (currentBallance > 0)
            {
                var game = Console.ReadLine();
                while (game != "Game Time")
                {
                    switch (game)
                    {
                        case "OutFall 4":
                            if (currentBallance <= 0)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                            if (currentBallance >= 39.99m)
                            {
                                currentBallance -= 39.99m;
                                Console.WriteLine("Bought OutFall 4");
                                moneySpend += 39.99m;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "CS: OG":
                            if (currentBallance <= 0)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                            if (currentBallance >= 15.99m)
                            {
                                currentBallance -= 15.99m;
                                Console.WriteLine("Bought CS: OG");
                                moneySpend += 15.99m;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "Zplinter Zell":
                            if (currentBallance <= 0)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                            if (currentBallance >= 19.99m)
                            {
                                currentBallance -= 19.99m;
                                Console.WriteLine("Bought Zplinter Zell");
                                moneySpend += 19.99m;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "Honored 2":
                            if (currentBallance <= 0)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                            if (currentBallance >= 59.99m)
                            {
                                currentBallance -= 59.99m;
                                Console.WriteLine("Bought Honored 2");
                                moneySpend += 59.99m;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "RoverWatch":
                            if (currentBallance <= 0)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                            if (currentBallance >= 29.99m)
                            {
                                currentBallance -= 29.99m;
                                Console.WriteLine("Bought RoverWatch");
                                moneySpend += 29.99m;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "RoverWatch Origins Edition":
                            if (currentBallance <= 0)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                            if (currentBallance >= 39.99m)
                            {
                                currentBallance -= 39.99m;
                                Console.WriteLine("Bought RoverWatch Origins Edition");
                                moneySpend += 39.99m;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                    }
                    game = Console.ReadLine();
                }
                var remaining = totalMoney - moneySpend;
                if (currentBallance <= 0)
                    Console.WriteLine("Out of money!");
                else
                    Console.WriteLine($"Total spent: ${moneySpend:f2}. " +
                                      $"Remaining: ${remaining:f2}");
            }
        }
    }
}