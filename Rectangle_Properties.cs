using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
           double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double per = 2 * width + 2 * height;
            double area = width * height;
            var diagonal = (Math.Sqrt((double)(width * width) +(double)( height * height)));

            Console.WriteLine(per);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
