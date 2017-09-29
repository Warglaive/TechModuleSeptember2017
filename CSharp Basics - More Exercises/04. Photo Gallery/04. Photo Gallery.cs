using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    public class Program
    {
        public static void Main()
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var size = decimal.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var date = day.ToString() + '/'
                 + month.ToString("00") + '/'
                 + year.ToString("0000")
                 + ' '
                 + hour.ToString("00") + ':'
                 + min.ToString("00");

            var parseTD = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            string format = "dd/MM/yyyy HH:mm";
            Console.WriteLine("Date Taken: {0}", parseTD.ToString(format));
            if (size < 1000)
            {
                Console.WriteLine("{0}B", size);
            }
            else if (size >= 1000 && size < 1000000)
            {
                Console.WriteLine("{0}KB", size / 1000);
            }
            else if (size >= 1000000)
            {
                Console.WriteLine("Size: {0}MB", size / 1000000m);
            }
            //To do Resolution
            var orientation = string.Empty;
            if (height < width)
            {
                orientation = "landscape";
            }
            else if (height > width)
            {
                orientation = "portrait";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
