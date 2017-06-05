using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var metricUnit = Console.ReadLine();
            var value = decimal.Parse(Console.ReadLine());
            switch(metricUnit)
            {
                case "miles":
                    var km = (value * 1.6m);
                    Console.WriteLine($"{value} miles = {km:F2} kilometers");                
                break;
                case "inches":
                    var cm = value * 2.54m;
                    Console.WriteLine($"{value} inches = {cm:F2} centimeters");
                    break;
                case "feet":
                    var cm2 = value * 30m;
                    Console.WriteLine($"{value} feet = {cm2:F2} centimeters");
                    break;
                case "yards":
                    var m = value * 0.91m;
                    Console.WriteLine($"{value} yards = {m:F2} meters");
                    break;
                case "gallons":
                    var liters = value * 3.8m;
                    Console.WriteLine($"{value} gallons = {liters:F2} liters");
                    break;
                default:
                   Console.WriteLine("error");
                    break;
            }
        }
    }
}
