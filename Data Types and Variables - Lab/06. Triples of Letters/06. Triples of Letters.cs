﻿using System;

namespace _06.Triples_of_Letters
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)('a' + i), (char)('a' + j), (char)('a' + k));
                    }
                }
            }
        }
    }
}