using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Roli_The_Coder
{
    public class Program
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            var result = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (input[0] != "Time")
            {
                var ID = input[0];
                var eventName = input[1];
                if (eventName[0] != '#') //EventFormatCheck
                {
                    input = Console.ReadLine().Split().ToList();
                    continue;
                }
                var oldParticipants = input.Skip(2).ToList();
                var currentParticipants = new HashSet<string>(oldParticipants);
                if (dictionary.ContainsKey(ID))
                {
                    if (dictionary[ID].Keys.Contains(eventName))
                    {
                        dictionary[ID][eventName] = currentParticipants;
                    }
                    else
                    {
                        input = Console.ReadLine().Split(new[] { ' ', '\t' }
                            , StringSplitOptions.RemoveEmptyEntries).ToList();
                        continue;
                    }
                }
                if (!dictionary.ContainsKey(ID))
                {
                    dictionary.Add(ID, new Dictionary<string, HashSet<string>>());
                }
                if (!dictionary[ID].ContainsKey(eventName))
                {
                    dictionary[ID].Add(eventName, new HashSet<string>());
                }

                dictionary[ID][eventName] = currentParticipants;
                input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var KVP in dictionary.Values)
            {
                foreach (var keyValuePair in KVP)
                {
                    var eventName = keyValuePair.Key;
                    var participants = keyValuePair.Value;
                    if (!result.ContainsKey(eventName))
                    {
                        result.Add(eventName, new HashSet<string>());
                    }
                    result[eventName] = participants;
                }
            }
            foreach (var eventAndParticipants in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{eventAndParticipants.Key.Replace("#", "")} - {eventAndParticipants.Value.Count}");
                foreach (var participant in eventAndParticipants.Value.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}