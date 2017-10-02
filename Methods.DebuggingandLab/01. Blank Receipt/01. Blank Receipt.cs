using System;

namespace _01.Blank_Receipt
{
    public class Program
    {
        public static void Main()
        {
            PrintReceit();
        }
        static void PrintReceit()
        {
            PrintHeader();
            PrintBody();
            printFooter();
        }
        private static void printFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9" + " SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
