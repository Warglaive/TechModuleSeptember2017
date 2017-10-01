using System;

namespace _05.Boolean_Variable
{
    public class Program
    {
        public static void Main()
        {
            var n = Console.ReadLine();
            if (Convert.ToBoolean(n) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}