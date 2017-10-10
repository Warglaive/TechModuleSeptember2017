using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int endIndex = int.Parse(Console.ReadLine());

        var search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;

                if (endIndex > text.Length)
                {
                    endIndex = text.Length;
                }
                if (i + endIndex < text.Length)
                {
                    string matchedString = text.Substring(i + 1, endIndex);
                    Console.WriteLine("p" + matchedString);
                    i += endIndex;
                }
                else
                {
                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                }
            }
        }
        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}