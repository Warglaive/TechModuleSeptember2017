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

            for (int i = a; i < 5; i++)//first check if satisfied
            {
                if (a <= i)
                {
                    for (int k = i; k < 5; k++)
                    {
                        i++;
                        if (k < i)
                        {
                            for (int l = i; l < 5; l++)
                            {
                                i++;
                                if (l < i)
                                {
                                    for (int m = i; m <= 5; m++)
                                    {
                                        if (m <= i)
                                        {
                                            Console.WriteLine($"{a} {i} {k} {l} {m}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }//then print
        }
    }
}