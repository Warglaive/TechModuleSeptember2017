using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    public class Program
    {
        public static void Main()
        {
            var totalPictures = int.Parse(Console.ReadLine());
            var timeToBeFilteredInSecs = int.Parse(Console.ReadLine());
            var goodPhotosPercent = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling(totalPictures * (goodPhotosPercent * 0.01));
            var filterTime = totalPictures * timeToBeFilteredInSecs;
            var totalUploadTIme = filteredPictures * uploadTime;
            var totalTime = filterTime + totalUploadTIme;

            var time = TimeSpan.FromSeconds(totalTime);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}