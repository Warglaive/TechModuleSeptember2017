using System;
using System.Linq;

namespace _05.Short_Words_Sorted
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(string.Join(", ",words.Where(x => x.Length < 5).OrderBy(a => a).Distinct()));
        }
    }
}