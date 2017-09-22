using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Passed_or_Failed
{
   public class Program
    {
       public static void Main()
        {
            var input = double.Parse(Console.ReadLine());
            bool passed = false;
            if (input >= 3.00)
            {
                passed = true;
            }
            Console.WriteLine(passed == true ? "Passed!" : "Failed!");
        }
    }
}
