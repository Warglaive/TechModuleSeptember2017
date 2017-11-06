using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '|', '-', '>' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();
            while (input[0] != "thetinggoesskrra")
            {
                string dataSet;
                if (input.Count == 1)
                {
                    dataSet = input[0];
                    if (!result.ContainsKey(dataSet))
                    {
                        result.Add(dataSet, new Dictionary<string, long>());
                    }
                    if (cache.ContainsKey(dataSet))
                    {
                        foreach (var KVP in cache)
                        {
                            result[dataSet] = KVP.Value;
                        }
                    }
                }
                else
                {
                    var dataKey = input[0];
                    var dataSize = long.Parse(input[1]);
                    dataSet = input[2];
                    if (result.ContainsKey(dataSet))
                    {
                        result[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                        }
                        cache[dataSet].Add(dataKey, dataSize);
                    }
                }
                input = Console.ReadLine().Split(new[] { ' ', '|', '-', '>' }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            long totalSum = 0;
            var dataSetFinal = string.Empty;
            foreach (var KVP in result.OrderByDescending(x => x.Value.Values.Sum()))
            {
                foreach (var Sum in KVP.Value)
                {
                    dataSetFinal = KVP.Key;
                    totalSum += Sum.Value;
                }
                break;
            }
            if (result.Keys.Count > 0)
            {
                Console.WriteLine($"Data Set: {dataSetFinal}, Total Size: {totalSum}");
                foreach (var KVP in result.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    foreach (var Sum in KVP.Value)
                    {
                        Console.WriteLine($"$.{Sum.Key}");
                    }
                    break;
                }
            }
        }
    }
}