using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    public class Program
    {
        public static void Main()//delete special number + delete special number - power and special number + power index
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>(input);
            var specialNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            var specialNumber = specialNumberAndPower[0];
            var power = specialNumberAndPower[1];

            for (int i = 0; i < result.Count - 1; i++)
            {
                if (input[i].Equals(specialNumber))
                {
                    for (int j = i - power; j <= (i + power) - 1; j++)//good for now(1, 2 tests)
                    {
                        if (i - power < 3 || i + power > 3)
                        {
                            break;
                        }
                        result.RemoveAt(j);
                    }

                }
            }
            Console.WriteLine(result.Sum());
        }
    }
}