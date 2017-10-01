using System;

namespace _01.Practice_Integers
{
    public class Program
    {
        public static void Main()
        {
            sbyte sbytex = -100;
            byte bytex = 128;
            short shortx = -3540;
            ushort ushortx = 64876;
            uint uintx = 2147483648;
            long longx = -1141583228;
            long longxx = -1223372036854775808;
            Console.WriteLine(sbytex
                + Environment.NewLine
                + bytex
                + Environment.NewLine
                + shortx
                + Environment.NewLine
                + ushortx
                + Environment.NewLine
                + uintx
                + Environment.NewLine
                + longx
                + Environment.NewLine
                + longxx);
        }
    }
}