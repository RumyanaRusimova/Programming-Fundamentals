using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var capacity = 255;
            var capacityLeft = capacity;
       
            for (int i = 1; i <= n; i++)
            {
                var currentQuantityL = int.Parse(Console.ReadLine());

                if (capacityLeft - currentQuantityL >= 0)
                {
                    capacityLeft -= currentQuantityL;

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            var filled = capacity - capacityLeft;
                    Console.WriteLine(filled);
                }
            }
        }
    

    











