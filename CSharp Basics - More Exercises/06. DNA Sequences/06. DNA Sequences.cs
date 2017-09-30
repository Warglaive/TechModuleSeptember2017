using System;

namespace _06.DNA_Sequences
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var lineCounter = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    for (int l = 1; l <= 4; l++)
                    {
                        var firstChar = string.Empty;
                        var secondChar = string.Empty;
                        var thirdChar = string.Empty;
                        if (i == 1)
                        {
                            firstChar = "A";
                        }
                        else if (i == 2)
                        {
                            firstChar = "C";
                        }
                        else if (i == 3)
                        {
                            firstChar = "G";
                        }
                        else
                        {
                            firstChar = "T";
                        }
                        //
                        if (k == 1)
                        {
                            secondChar = "A";
                        }
                        else if (k == 2)
                        {
                            secondChar = "C";
                        }
                        else if (k == 3)
                        {
                            secondChar = "G";
                        }
                        else
                        {
                            secondChar = "T";
                        }
                        //
                        if (l == 1)
                        {
                            thirdChar = "A";
                        }
                        else if (l == 2)
                        {
                            thirdChar = "C";
                        }
                        else if (l == 3)
                        {
                            thirdChar = "G";
                        }
                        else
                        {
                            thirdChar = "T";
                        }
                        var prefix = string.Empty;
                        var suffix = string.Empty;
                        if (i + k + l >= n)
                        {
                            prefix = "O";
                            suffix = "O";
                        }
                        else
                        {
                            prefix = "X";
                            suffix = "X";
                        }
                        lineCounter++;
                        if (lineCounter == 4)
                        {
                            Console.WriteLine(prefix + firstChar + secondChar + thirdChar + suffix + " ");
                            lineCounter = 0;
                        }
                        else
                        {
                            Console.Write(prefix + firstChar + secondChar + thirdChar + suffix + " ");
                        }
                    }
                }
            }
        }
    }
}