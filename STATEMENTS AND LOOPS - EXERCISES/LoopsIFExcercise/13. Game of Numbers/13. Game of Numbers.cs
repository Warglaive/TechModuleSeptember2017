using System;

namespace _13.Game_of_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var magicalNum = int.Parse(Console.ReadLine());
            var sum = 0;
            var combinationsCount = 0;
            var first = 0;
            var second = 0;
            var isAnum = false;
            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    sum = i + j;
                    if (sum == magicalNum)
                    {
                        isAnum = true;
                        first = i;
                        second = j;
                    }
                    combinationsCount++;
                }
            }
            if (isAnum == true)
            {
                Console.WriteLine($"Number found! {first} + {second} = {magicalNum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicalNum}");
            }
        }
    }
}