using System;

namespace _18.Different_Integers_Size
{
    public class Program
    {
        public static void Main()
        {
            var n = decimal.Parse(Console.ReadLine());
            bool sbyteFit = false;
            bool byteFit = false;
            bool shortFit = false;
            bool ushortFit = false;
            bool intFit = false;
            bool uintFit = false;
            bool longFit = false;
            if (n > 9223372036854775807)
            {
                Console.WriteLine($"{n} can't fit in any type");
                return;
            }
            else
            {
                Console.WriteLine($"{n} can fit in: ");
                // sbyte < byte < short < ushort < int < uint < long
                if (n >= -128 && n <= 127)
                {
                    sbyteFit = true;
                    Console.WriteLine("* sbyte");
                }
                if (n >= 0 && n <= 255)
                {
                    byteFit = true;

                    Console.WriteLine("* byte");
                }
                if (n >= -32768 && n <= 32767)
                {
                    shortFit = true;
                    Console.WriteLine("* short");
                }
                if (n >= 0 && n <= 65535)
                {
                    ushortFit = true;
                    Console.WriteLine("* ushort");
                }
                if (n >= -2147483648 && n <= 2147483647)
                {
                    intFit = true;
                    Console.WriteLine("* int");
                }
                if (n >= 0 && n <= 4294967295)
                {
                    uintFit = true;
                    Console.WriteLine("* uint");
                }
                if (n >= -9223372036854775808 && n <= 9223372036854775807)
                {
                    longFit = true;
                    Console.WriteLine("* long");
                }
            }
        }
    }
}