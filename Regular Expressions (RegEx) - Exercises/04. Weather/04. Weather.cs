using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _04.Weather
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"(?<city>[A-Z]{2})(?<temp>\d{1,2}\.\d{1,2})([A-Za-z]+)(?=[|])";
            var result = new Dictionary<string, Dictionary<double, string>>();
            var input = Console.ReadLine();
            while (input != "end")
            {
                foreach (Match wordMatch in Regex.Matches(input, pattern))
                {
                    var city = Convert.ToString(wordMatch.Groups["city"]);
                    var temp = Convert.ToDouble(wordMatch.Groups["temp"].Value);
                    var type = Convert.ToString(wordMatch.Groups[1]);

                    if (!result.ContainsKey(city))
                    {
                        result.Add(city, new Dictionary<double, string>());
                    }
                    else
                    {
                        result.Remove(city); //key cant be rewrited - remove it and add it again
                        result.Add(city, new Dictionary<double, string>());
                    }
                    if (!result[city].ContainsKey(temp))
                    {
                        result[city][temp] = type;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var CityPair in result.OrderBy(x => x.Value.Keys.Average()))
            {
                var city = CityPair.Key;
                foreach (var tempTypePairs in CityPair.Value)
                {
                    var temp = tempTypePairs.Key;
                    var type = tempTypePairs.Value;
                    Console.WriteLine($"{city} => {temp:f2} => {type}");
                }
            }
        }
    }
}