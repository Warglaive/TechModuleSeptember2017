using System;
using System.Linq;

namespace _14.Magic_Letter
{
    public class Program
    {
        public static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char notPrinterLetter = char.Parse(Console.ReadLine());

            var result = string.Empty;

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        result = i.ToString() + j.ToString() + k.ToString();
                        if (!result.Contains(notPrinterLetter))
                        {
                            Console.Write(result+" ");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}