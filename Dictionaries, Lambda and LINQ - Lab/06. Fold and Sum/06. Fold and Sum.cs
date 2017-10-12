using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = input.Length / 4;
            var leftRow = input.Take(k).Reverse();
            var rightRow = input.Reverse().Take(k);
            var concat = leftRow.Concat(rightRow).ToList();
            var next = input.Skip(k).Take(2 * k).ToList();
            var sum = concat.Select((x, index) => x + next[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}