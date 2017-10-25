using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    public class Program
    {
        public static void Main()
        {
            var participantsList = Console.ReadLine()
                .Split(new[] { ' ', ',' }
            , StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            var availableSongsList = Console.ReadLine()
                .Split(new[] { ", " }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var nameSongAward = Console.ReadLine()
                .Split(new[] { ", " }
            , StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            var result = new Dictionary<string, Dictionary<string, List<int>>>();
            var awardCount = 0;
            while (nameSongAward[0] != "dawn")
            {
                var currentParticipant = nameSongAward[0];
                var song = nameSongAward[1];
                var award = nameSongAward[2];
                awardCount = 0;
                if (participantsList.Contains(currentParticipant) && availableSongsList.Contains(song))
                {
                    if (!result.ContainsKey(currentParticipant))
                    {
                        result.Add(currentParticipant, new Dictionary<string, List<int>>());
                    }
                    if (!result[currentParticipant].ContainsKey(award))
                    {
                        result[currentParticipant].Add(award, new List<int>());
                        awardCount++;
                    }
                    result[currentParticipant][award].Add(awardCount);
                }
                nameSongAward = Console.ReadLine()
                    .Split(new[] { ", " }
                        , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            //if zero awards check
            bool isAny = true;
            foreach (var awardsCount in result)
            {
                foreach (var x in awardsCount.Value.Values)
                {
                    if (x.Sum() < 1)
                    {
                        isAny = false;
                    }
                }
            }
            if (!isAny || result.Values.Count < 1)
            {
                Console.WriteLine($"No awards");
            }
            foreach (var participant in result
                .OrderByDescending(x => x.Value.Values.Count))
            {
                var total = 0;
                Console.Write($"{participant.Key}: ");
                foreach (var numbers in participant.Value.Values)
                {
                    foreach (var num in numbers)
                    {
                        total += num;
                    }
                }
                Console.Write($"{total} awards");
                Console.WriteLine();
                foreach (var award in participant.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"--{award.Key}");
                }
            }
        }
    }
}