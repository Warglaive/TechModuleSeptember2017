using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var satisfied = false;

            for (int i = a; i <= b; i++)//first check if satisfied
            {
                i++;
                for (int k = i; k < b; k++)
                {
                    i++;
                    for (int l = i; l < b; l++)
                    {
                        i++;
                        for (int m = i; m <= b; m++)
                        {
                            i++;
                            for (int v = i; v <= b; v++)
                            {
                                Console.WriteLine($"{a} {k} {l} {m} {v}");
                            }
                        }
                    }
                }
            }
        }
    }
}