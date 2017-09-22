using System;

namespace _06.Theatre_Promotion
{
    public class Program
    {
       public static void Main()
        {
            var dayType = Console.ReadLine();
            var AgeOfPerson = int.Parse(Console.ReadLine());
            var price = 0;
            if (dayType == "Weekday" && 0 <= AgeOfPerson && AgeOfPerson <= 18)
            {
                price = 12;
                Console.WriteLine("{0}$", price);
                return;
            }
            else if (dayType == "Weekday" && 18 <= AgeOfPerson && AgeOfPerson <= 64)
            {
                price = 18;
                Console.WriteLine("{0}$", price);
                return;
            }
            else if (dayType == "Weekday" && 64 <= AgeOfPerson && AgeOfPerson <= 122)
            {
                price = 12;
                Console.WriteLine("{0}$", price);
                return;
            }
            //Weekend
            if (dayType == "Weekend" && 0 <= AgeOfPerson && AgeOfPerson <= 18)
            {
                price = 15;
                Console.WriteLine("{0}$", price);
                return;
            }
            else if (dayType == "Weekend" && 18 <= AgeOfPerson && AgeOfPerson <= 64)
            {
                price = 20;
                Console.WriteLine("{0}$", price);
                return;
            }
            else if (dayType == "Weekend" && 64 <= AgeOfPerson && AgeOfPerson <= 122)
            {
                price = 15;
                Console.WriteLine("{0}$", price);
                return;
            }
            
            //Holiday
            if (dayType == "Holiday" && 0 <= AgeOfPerson && AgeOfPerson <= 18)
            {
                price = 5;
                Console.WriteLine("{0}$", price);
                return;
            }
            else if (dayType == "Holiday" && 18 <= AgeOfPerson && AgeOfPerson <= 64)
            {
                price = 12;
                Console.WriteLine("{0}$", price);
                return;
            }
            else if (dayType == "Holiday" && 64 <= AgeOfPerson && AgeOfPerson <= 122)
            {
                price = 10;
                Console.WriteLine("{0}$", price);
                return;
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
