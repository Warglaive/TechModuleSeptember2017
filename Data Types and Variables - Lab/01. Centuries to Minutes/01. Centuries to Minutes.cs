﻿using System;

namespace _01.Centuries_to_Minutes
{
    public class Program
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine("{0}" +
                              " centuries = {1}" +
                              " years = {2}" +
                              " days = {3}" +
                              " hours = {4}" +
                              " minutes", centuries, years, days, hours, minutes);
        }
    }
}
