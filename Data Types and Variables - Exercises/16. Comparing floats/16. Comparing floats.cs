using System;

namespace _16.Comparing_floats
{
    public class Program
    {
        public static void Main()
        {
            var precision = 0.000001; //we assume two numbers are equal 
            //if they are more closely to each other than some fixed constant eps. 
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var biggerNum = Math.Max(a, b);
            var smallerNum = Math.Min(a, b);
            var difference = biggerNum - smallerNum;
            bool isEqual = false;
            if (difference < precision)
            {
                isEqual = true;
            }
            Console.WriteLine(isEqual);
        }
    }
}