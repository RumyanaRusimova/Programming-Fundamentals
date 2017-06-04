using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();         
             long maxValue = 0L;

            switch (type)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }
            var n = int.Parse(Console.ReadLine());
            long thiefsId = long.MinValue;
            for (int i = 0; i < n; i++)
              {
                   var tempTd = long.Parse(Console.ReadLine());
                  if (tempTd > thiefsId && tempTd <= maxValue)
                {
                    thiefsId = tempTd;
                 }
              }
                    Console.WriteLine(thiefsId);
            }

        }
    }

