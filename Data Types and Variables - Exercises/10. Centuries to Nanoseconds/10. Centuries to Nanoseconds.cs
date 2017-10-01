using System;

namespace _10.Centuries_to_Nanoseconds
{
    public class Program
    {
        public static void Main()
        {
            var centuries = decimal.Parse(Console.ReadLine());
            decimal centToyear = centuries * 100;
            decimal yearsToDays = (int)(centToyear * 365.2422m);
            decimal daysToHr = yearsToDays * 24;
            decimal HrToMin = daysToHr * 60;
            decimal minToSec = HrToMin * 60;
            decimal secToMiliSec = minToSec * 1000;
            decimal toMicroSec = secToMiliSec * 1000;
            decimal toNano = toMicroSec * 1000;
            Console.WriteLine(
                $"{centuries:f0} centuries = {centToyear:f0} years = {yearsToDays:f0} days = {daysToHr:f0} hours = {Math.Round(HrToMin)} minutes = {minToSec:f0} seconds = {secToMiliSec:f0} milliseconds = {toMicroSec:f0} microseconds = {toNano:f0} nanoseconds");
        }
    }
}