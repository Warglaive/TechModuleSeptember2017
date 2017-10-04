using System;

namespace _17.Print_Part_Of_ASCII_Table
{
    public class Program
    {
        public static void Main()
        {
            var numStart = int.Parse(Console.ReadLine());
            var numEnd = int.Parse(Console.ReadLine());
            for (int i = numStart; i <= numEnd; i++)
            {
                Console.Write(Convert.ToChar(i)+" ");
            }
            Console.WriteLine();
        }
    }
}