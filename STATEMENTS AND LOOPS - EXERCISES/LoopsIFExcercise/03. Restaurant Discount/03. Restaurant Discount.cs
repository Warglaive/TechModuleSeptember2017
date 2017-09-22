using System;

namespace _03.Restaurant_Discount
{
   public class Program
    {
       public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var packType = Console.ReadLine();
            var pricePerPerson = 0d;
            var discount = 0d;
            var hallPrice = 0d;
            var TotalPrice = 0d;
            var HallType = string.Empty;

            if (groupSize <= 50)
            {
                hallPrice = 2500;
                HallType = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100) 
            {
                hallPrice = 5000;
                HallType = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallPrice = 7500;
                HallType = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            //
            if (packType== "Normal")
            {
                discount = (hallPrice + 500) * 0.05;
                TotalPrice = (hallPrice + 500) - discount;
                pricePerPerson = TotalPrice / groupSize;
                Console.WriteLine($"We can offer you the {HallType + Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
            else if (packType=="Gold")
            {
                discount = (hallPrice + 750) * 0.10;
                TotalPrice = (hallPrice + 750) - discount;
                pricePerPerson = TotalPrice / groupSize;
                Console.WriteLine($"We can offer you the {HallType + Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
            else if (packType == "Platinum")
            {
                discount = (hallPrice + 1000) * 0.15;
                TotalPrice = (hallPrice + 1000) - discount;
                pricePerPerson = TotalPrice / groupSize;
                Console.WriteLine($"We can offer you the {HallType + Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}