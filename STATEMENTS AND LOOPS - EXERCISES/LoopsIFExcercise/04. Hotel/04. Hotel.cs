using System;

namespace _04.Hotel
{
    public class Program
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studioPerNight = 0d;
            var doublePerNight = 0d;
            var suitePerNight = 0d;
            //
            if (month == "May" || month == "October")
            {
                studioPerNight = 50;
                doublePerNight = 65;
                suitePerNight = 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPerNight = 60;
                doublePerNight = 72;
                suitePerNight = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPerNight = 68;
                doublePerNight = 77;
                suitePerNight = 89;
            }
            //discont
            if ((month == "May" || month == "October") && nightsCount > 7)
            {
                studioPerNight = studioPerNight * 0.95;
            }
            else if ((month == "June" || month == "September") && nightsCount > 14)
            {
                doublePerNight = doublePerNight * 0.90;
            }
            else if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
            {
                suitePerNight = suitePerNight * 0.85;
            }

            var totalStudioPrice = studioPerNight * nightsCount;
            var totalDoublePrice = doublePerNight * nightsCount;
            var totalSuitePrice = suitePerNight * nightsCount;

            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                totalStudioPrice = totalStudioPrice - studioPerNight;
            }
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv." +
                Environment.NewLine +
                $"Double: {totalDoublePrice:f2} lv." +
                Environment.NewLine +
                $"Suite: {totalSuitePrice:f2} lv.");
        }
    }
}