using System;
using System.Linq;

namespace _05.Magic_exchangeable_words
{
    public class Program
    {
        public static void Main()
        {
            //mahash vsichki ednakvi i pechatash true ako sa ravni inache false
            var input = Console.ReadLine().Split().ToList();
            var firstWord = input[0].Distinct();
            var secondWord = input[1].Distinct();
            Console.WriteLine(firstWord.Count() == secondWord.Count() ? "true" : "false");
        }
    }
}