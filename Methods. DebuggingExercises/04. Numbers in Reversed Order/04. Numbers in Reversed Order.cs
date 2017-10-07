using System;
using System.Linq;

namespace _04.Numbers_in_Reversed_Order
{
    public class Program
    {
        public static void Main()
        {
            Reverse();
        }

        public static void Reverse()
        {
            var input = decimal.Parse(Console.ReadLine());
            var reversedInput = new string(input.ToString().Reverse().ToArray()); //накрая записва с String, ne v char.
            decimal reversedDecimal;
            if (decimal.TryParse(reversedInput, out reversedDecimal))
            {
                Console.WriteLine(reversedDecimal);
            }
        }
    }
}