using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Supermarket_Database
{
    public class Program
    {
        public static void Main()
        {
            var products = Console.ReadLine().Split().ToList();
            var supermarketStorage = new Dictionary<string, Dictionary<double, int>>();
            while (products[0] != "stocked")
            {
                var productName = products[0];
                var productPrice = double.Parse(products[1]);
                var productQuantity = int.Parse(products[2]);

                if (!supermarketStorage.ContainsKey(productName))
                {
                    supermarketStorage.Add(productName, new Dictionary<double, int>());
                }
                if (!supermarketStorage[productName].ContainsKey(productPrice))
                {
                    supermarketStorage[productName][productPrice] = 0;
                }
                supermarketStorage[productName][productPrice] = productQuantity;
                products = Console.ReadLine().Split().ToList();
            }
            var grandTotal = 0d;
            foreach (var productParts in supermarketStorage)
            {
                var name = productParts.Key;
                var price = productParts.Value.Keys.Last();
                var quantity = productParts.Value.Values.Sum();
                var total = quantity * price;
                Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${total:f2}");
                grandTotal += total;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}