using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal voloume = 0m;
            var maxVoloume = 0m;
            var biggestModel = " ";
            for (int i = 0; i < n; i++)
            {
                var tipe = Console.ReadLine();
                var radius = decimal.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
              var currentVoloume = ( decimal)(Math.PI ) * radius * radius * height;
                if (currentVoloume > maxVoloume)
                {
                    maxVoloume =  currentVoloume;
                    biggestModel = tipe;
                } 
            }

            Console.WriteLine(biggestModel);
        }
    }
}
