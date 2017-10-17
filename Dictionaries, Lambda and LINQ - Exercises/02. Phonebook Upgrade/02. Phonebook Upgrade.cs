using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Phonebook_Upgrade
{
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split().ToList();
            var phoneBook = new SortedDictionary<string, string>();
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
                    case "ListAll":
                        ListAll(entry, phoneBook);
                        break;
                }

                entry = Console.ReadLine().Split().ToList();
            }
        }

        private static void ListAll(List<string> entry, SortedDictionary<string, string> phoneBook)
        {
            foreach (var KvP in phoneBook)
            {
                Console.WriteLine($"{KvP.Key} -> {KvP.Value}");
            }
        }

        private static void SearchContact(List<string> entry, SortedDictionary<string, string> phoneBook)
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

        private static void AddEntry(List<string> entry, SortedDictionary<string, string> phoneBook)
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