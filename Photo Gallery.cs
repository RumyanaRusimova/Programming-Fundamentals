using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var fotoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = decimal.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
           

            Console.WriteLine($"Name: DSC_{fotoNumber:0000}.jpg");
            Console.WriteLine($"Date Taken: {day:00}/{month:00}/{year:0000} {hour:00}:{minutes:00}");
            if (size < 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size >= 1000 && size < 1000000)
            {
                size /= 1000;
                Console.WriteLine($"Size: {size}KB");
            }
            else
            {
                size /= 1000000;
                Console.WriteLine($"Size: {size}MB");
            }
            if(width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");

            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
        }
    }
}
