using System;   
namespace _13.Vowel_or_Digit
{
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            var digit = 0d;
            
            if (entry == "a" || entry=="e" || entry == "i" || entry == "o" || entry == "u") 
            {
                Console.WriteLine("vowel");
            }
            else if (double.TryParse(entry, out digit))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}