using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main()
        {
            var websiteNum = int.Parse(Console.ReadLine());
            var securityKey = BigInteger.Parse(Console.ReadLine());

            var affectedSitesNames = new List<string>();
            var totalMoneyLoss = new List<decimal>();

            for (int i = 0; i < websiteNum; i++)
            {
                var data = Console.ReadLine().Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
                var siteName = data[0].Trim();
                affectedSitesNames.Add(siteName);
                var siteVisits = decimal.Parse(data[1]);
                var siteCommercialPricePerVisit = decimal.Parse(data[2]);
                var siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalMoneyLoss.Add(siteLoss);
            }
            foreach (var siteName in affectedSitesNames)
            {
                Console.WriteLine(siteName);
            }
            Console.WriteLine($"Total Loss: {totalMoneyLoss.Sum():f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, websiteNum)}");
        }
    }
}