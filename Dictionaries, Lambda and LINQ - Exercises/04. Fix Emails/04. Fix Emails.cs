using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fix_Emails
{
    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var email = Console.ReadLine();
            var result = new Dictionary<string, string>();
            while (name != "stop")
            {
                var emailParts = email.Split('.').ToList();
                if (emailParts[1].Equals("us") || emailParts[1].Equals("uk"))
                {
                    name = Console.ReadLine();
                    if (name == "stop")
                    {
                        break;
                    }
                    email = Console.ReadLine();
                    continue;
                }
                result[name] = email;
                name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                email = Console.ReadLine();
            }
            foreach (var KeyValuePair in result)
            {
                Console.WriteLine($"{KeyValuePair.Key} -> {KeyValuePair.Value}");
            }
        }
    }
}