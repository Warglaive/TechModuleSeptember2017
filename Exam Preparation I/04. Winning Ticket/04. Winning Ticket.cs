using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _04.Winning_Ticket
{
    public class Program
    {
        public static void Main() //50/100 in Judge
        {
            var ticketsInput = Console.ReadLine().Split(new[] { ',', ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var isMatch = false;

            var pattern = @"(?<left>[@#$^]{6,10}).*?(?<right>[@#$^]{6,10})";
            foreach (var ticket in ticketsInput) // is valid
            {
                if (ticket.Length == 20)
                {
                    var matches = Regex.Matches(ticket, pattern);

                    foreach (Match ticketMatch in matches)
                    {
                        isMatch = true;
                        var left = ticketMatch.Groups["left"].Value;
                        var right = ticketMatch.Groups["right"].Value;
                        var symbol = left[0];
                        var rightSymbol = right[0];
                        if (left.Length <= right.Length)
                        {
                            if (left.Length >= 6 && left.Length <= 9 && (symbol == rightSymbol))
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {left.Length}{symbol}");
                            }
                            else if (left.Length == 10 && left.Length == 10 && (symbol == rightSymbol))
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {left.Length}{symbol} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - no match");
                            }
                        }
                    }
                    if (!isMatch)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}