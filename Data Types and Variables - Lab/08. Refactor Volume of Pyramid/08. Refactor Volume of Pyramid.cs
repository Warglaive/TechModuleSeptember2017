﻿using System;

namespace _08.Refactor_Volume_of_Pyramid
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Length: ");
            var lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            var volume = (lenght * height * width) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}