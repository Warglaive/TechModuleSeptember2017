using System;

namespace _05.Word_in_Plural
{
    public class Program
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var newWord = string.Empty;
            if (word.EndsWith("y"))
            {
                newWord = word.Remove(word.Length - 1);
                newWord += "ies";
            }
            else if (word.EndsWith("o")
                || word.EndsWith("ch")
                || word.EndsWith("s")
                || word.EndsWith("sh")
                || word.EndsWith("x")
                || word.EndsWith("z"))
            {
                newWord = word;
                newWord += "es";
            }
            else
            {
                newWord = word;
                newWord += "s";
            }
            Console.WriteLine(newWord);
        }
    }
}