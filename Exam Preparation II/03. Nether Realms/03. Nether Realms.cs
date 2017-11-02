using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _03.Nether_Realms
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ',', ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var result = new SortedDictionary<string, Dictionary<long, decimal>>();

            foreach (var demon in input)
            {//Health
                long demonHealth = 0;
                var healthPattern = @"[A-Za-z]";
                foreach (Match lettersMatch in Regex.Matches(demon, healthPattern))
                {
                    demonHealth += Convert.ToChar(lettersMatch.Value);
                }
                //
                //Damage
                var demonDamage = 0m;
                var damagePattern = @"\-?[0-9]\.?[0-9]?";
                foreach (Match letter in Regex.Matches(demon, damagePattern))//take num
                {
                    demonDamage += Convert.ToDecimal(letter.Value);
                }
                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        demonDamage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        demonDamage /= 2;
                    }
                }
                //Put In Dict
                if (!result.ContainsKey(demon))
                {
                    result.Add(demon, new Dictionary<long, decimal>());
                }
                if (!result[demon].ContainsKey(demonHealth))
                {
                    result[demon].Add(demonHealth, 0);
                }
                result[demon][demonHealth] = demonDamage;
            }
            foreach (var demonInfo in result)
            {
                foreach (var healthAndDmg in demonInfo.Value)
                {
                    Console.WriteLine($"{demonInfo.Key} - {healthAndDmg.Key} health, {healthAndDmg.Value:F2} damage");
                }
            }
        }
    }
}