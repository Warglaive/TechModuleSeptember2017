using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    public class Program
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studioPrice = 0d;
            var doublePrice = 0d;
            var suitePrice = 0d;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
            }
            //discount
            if (nightsCount > 7 && (month == "May" || month == "October"))
            {
                studioPrice = (studioPrice * 0.95) * nightsCount; //5%
                doublePrice *= nightsCount;
                suitePrice *= nightsCount;
            }
            else if (nightsCount > 14 && (month == "June" || month == "September"))
            {
                doublePrice = (doublePrice * 0.90) * nightsCount; //10%
                studioPrice *= nightsCount;
                suitePrice *= nightsCount;
            }
            else if (nightsCount > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suitePrice = (suitePrice * 0.85) * nightsCount; //15%
                doublePrice *= nightsCount;
                studioPrice *= nightsCount;
            }
            if (nightsCount > 7 && (month == "September" || month == "October"))  //maybe simple if, not else if
            {
                if (month == "September")
                {
                    studioPrice = (studioPrice * nightsCount) - studioPrice;
                    doublePrice *= nightsCount;
                    suitePrice *= nightsCount;
                }
                else
                {
                    studioPrice = (studioPrice * nightsCount) - studioPrice;
                    doublePrice *= nightsCount;
                    suitePrice *= nightsCount;
                }
            }
            else
            {
                studioPrice *= nightsCount;
                doublePrice *= nightsCount;
                suitePrice *= nightsCount;
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv." +
                Environment.NewLine + $"Double: {doublePrice:f2} lv." +
                Environment.NewLine + $"Suite: {suitePrice:f2} lv.");
        }
    }
}
