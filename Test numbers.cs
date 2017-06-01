using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());
            var combinations = 0;
            var sum = 0;
            for (int d1 = n; d1 >= 1 ; d1--)
            {
                for (int d2 = 1; d2 <= m; d2++)
                {
                    var number = (d1 * d2) * 3;
                    sum += number;
                    combinations++;
                    if (sum >= num)
                    {
                        Console.WriteLine("{0} combinations",combinations);
                        Console.WriteLine($"Sum: {sum} >= {num}");
                        return;
                    }                
                                       
                   }
                }

            Console.WriteLine("{0} combinations",combinations);
            Console.WriteLine($"Sum: {sum}");

        }
       }
    }

