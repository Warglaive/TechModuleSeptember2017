using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split()
                .Where(digit => digit.Length == 2)
                .Select(x => new string(x.Reverse().ToArray()))
                .Select(x => Convert.ToChar(Convert.ToInt32(x, 16)))
                .Reverse()
                .ToList();
            Console.WriteLine(string.Join("", input));
        }
    }
}