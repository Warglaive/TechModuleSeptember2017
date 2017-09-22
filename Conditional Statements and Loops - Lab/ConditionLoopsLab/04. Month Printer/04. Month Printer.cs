using System;
using System.Globalization;
namespace _04.Month_Printer
{
    public class Program
    {
       public static void Main()
        {
            var monthNum = int.Parse(Console.ReadLine());
            if (monthNum>=1)
            {
                Console.WriteLine(monthNum < 13 ? CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(monthNum) : "Error!");
                return;
            }
            Console.WriteLine("Error!");
        }
    }
}