using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    public class Program
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').ToArray();
            var secondArray = Console.ReadLine().Split(' ').ToArray();
            var shorter = Math.Min(firstArray.Length, secondArray.Length);
            var leftToRightCounter = 0;
            var rightToLeftCounter = 0;
            for (int i = 0; i < shorter; i++) //first array
            {
                for (int j = i; j < shorter; j++)
                {
                    //second
                    if (firstArray[i].Equals(secondArray[j]))
                    {
                        leftToRightCounter++;
                    }
                    i++;
                }
            }
        }
    }
}