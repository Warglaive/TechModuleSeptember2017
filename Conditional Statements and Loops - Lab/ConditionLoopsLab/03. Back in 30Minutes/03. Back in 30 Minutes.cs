using System;

namespace _03.Back_in_30Minutes
{
    public class Program
    {
       public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var plusThirtyMins = minutes + 30;
            if (plusThirtyMins > 59)
            {
                hours += 1;
                plusThirtyMins -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{plusThirtyMins:d2}");
        }
    }
}
