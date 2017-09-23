using System;

namespace _09.Count_the_Integers
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var integer = 0;
            var counter = 0;
            while (int.TryParse(input, out integer))
            {
                input = Console.ReadLine();
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
