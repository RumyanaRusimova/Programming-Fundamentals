using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

           var  distance1 =  FindDistanceBetwinPoints(x1, y1, x2, y2);
            var distance2 = FindDistanceBetwinPoints(x3, y3, x4, y4);
            if (distance1 >= distance2)
            {
                if  ( IsClosestPointToCenter(x1, y1, x2, y2)) 
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (IsClosestPointToCenter(x3, y3, x4, y4)) 
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
         }

        private static double FindDistanceBetwinPoints (double x1, double y1, double x2, double y2)
        {
            
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + ( Math.Pow(y2 - y1, 2)));
      
            return distance;
        }

        private static bool IsClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            if (x1 * x1 + y1 * y1 <= x2 * x2 + y2 * y2)
            {
                return true;  
            }
            return false;           
                        
        }
    }
}


 
