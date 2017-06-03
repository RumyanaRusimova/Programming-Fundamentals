using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceM = int.Parse(Console.ReadLine());
            var  hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            var totalSeconds = seconds + minutes * 60 +( hours * 60 * 60);
            var speedMPerSec =   (distanceM /totalSeconds);
            var speedKmPerHour = ( distanceM /1000) /( totalSeconds /60 / 60);
            var speedMilesPerHour = (distanceM /1609f) /( totalSeconds / 60 / 60);
            Console.WriteLine(speedMPerSec);
            Console.WriteLine(speedKmPerHour);
            Console.WriteLine(speedMilesPerHour);
        }
    }
}
