using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Parking_Validation
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var carResult = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var command = input[0];
                switch (command)
                {
                    case "register":
                        Register(carResult, input);
                        break;
                    case "unregister":
                        Unreagister(carResult, input);
                        break;
                }
            }
            foreach (var userAndPlate in carResult)
            {
                Console.WriteLine($"{userAndPlate.Key} => {userAndPlate.Value}");
            }
        }

        private static void Unreagister(Dictionary<string, string> carResult, List<string> input)
        {
            var username = input[1];
            if (!carResult.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                carResult.Remove(username);
                Console.WriteLine($"user {username} unregistered successfully");
            }
        }

        private static void Register(Dictionary<string, string> carResult, List<string> input)
        {
            var username = input[1];
            var licensePlateNumber = input[2];
            bool isValid = false;
            isValid = ValidatePlateNumber(licensePlateNumber, isValid);
            if (isValid)
            {

                if (carResult.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {carResult.Values.Last()}");
                }
                else if (carResult.Values.Contains(licensePlateNumber))
                {
                    Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                }
                else
                {
                    carResult.Add(username, licensePlateNumber);
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                }
            }
            else
            {
                Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
            }

        }

        private static bool ValidatePlateNumber(string licensePlateNumber, bool isValid)
        {
            if (licensePlateNumber.Length == 8)
            {
                var licensePlateParts = licensePlateNumber.ToCharArray();
                if ((licensePlateParts[0] >= 65 && licensePlateParts[0] <= 90)
                    && (licensePlateParts[1] >= 65
                    && licensePlateParts[1] <= 90)
                    && (licensePlateParts[licensePlateParts.Length - 2] >= 65
                    && licensePlateParts[licensePlateParts.Length - 2] <= 90)
                    && (licensePlateParts[licensePlateParts.Length - 1] >= 65)
                    && (licensePlateParts[licensePlateParts.Length - 1] <= 90))
                {
                    for (int i = 2; i < licensePlateParts.Length - 2; i++)
                    {
                        if (int.TryParse(licensePlateParts[i].ToString(), out _))
                        {
                            isValid = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return isValid;
        }
    }
}