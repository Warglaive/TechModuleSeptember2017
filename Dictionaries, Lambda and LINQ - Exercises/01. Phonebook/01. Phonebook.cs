using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split().ToList();
            var phoneBook = new Dictionary<string, string>();
            while (entry[0] != "END")
            {
                var command = entry[0];
                switch (command)
                {
                    case "A":
                        AddEntry(entry, phoneBook);
                        break;
                    case "S":
                        SearchContact(entry, phoneBook);
                        break;
                }

                entry = Console.ReadLine().Split().ToList();
            }
        }

        private static void SearchContact(List<string> entry, Dictionary<string, string> phoneBook)
        {
            var name = entry[1];
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine(name + " -> " + phoneBook[name]);
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        private static void AddEntry(List<string> entry, Dictionary<string, string> phoneBook)
        {
            var name = entry[1];
            var number = entry[2];
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook[name] = number;
            }
            else
            {
                phoneBook[name] = number;
            }
        }
    }
}
