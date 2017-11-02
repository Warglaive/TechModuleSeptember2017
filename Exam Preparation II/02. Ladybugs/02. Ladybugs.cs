using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs //50/100
{
    public class Program
    {
        public static void Main()
        {
            var fieldSize = long.Parse(Console.ReadLine());
            var ladyBugIndex = Console.ReadLine().Split().Select(long.Parse).ToList();
            var commands = Console.ReadLine().Split().ToList();

            var initialField = new List<long>();
            for (int i = 0; i < fieldSize; i++)
            {
                initialField.Add(0);
            }
            for (int i = 0; i < fieldSize; i++) //!
            {
                if (ladyBugIndex.Contains(i))
                {
                    initialField[i] = 1;
                }
            }
            while (commands[0] != "end")
            {
                var currentLadyBugIndex = int.Parse(commands[0]);
                var direction = commands[1];
                var lenght = int.Parse(commands[2]);
                if (currentLadyBugIndex > 1 && currentLadyBugIndex <= fieldSize)
                {
                    switch (direction)
                    {
                        case "right":
                            initialField[currentLadyBugIndex] = 0;
                            if (currentLadyBugIndex + lenght >= initialField.Count)
                            {
                                break;
                            }
                            //
                            while (initialField[lenght] == 1)
                            {
                                lenght = lenght + lenght;
                                if (lenght >= initialField.Count)
                                {
                                    break;
                                }
                            }
                            break;
                        case "left":
                            initialField[currentLadyBugIndex] = 0;
                            while (true)
                            {
                                if (initialField[currentLadyBugIndex - lenght] == 1)
                                {
                                    lenght = lenght + lenght;
                                    break;
                                }
                                initialField[currentLadyBugIndex - lenght] = 1;
                                break;
                            }
                            break;
                    }
                }
                commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", initialField));
        }
    }
}