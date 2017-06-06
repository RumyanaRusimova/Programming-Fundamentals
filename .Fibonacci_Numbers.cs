using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            FindFibonacciNum(n);
        }

        private static void FindFibonacciNum(int n)
        {
          var f0 = 1;
            var f1 = 1;
            for (int i = 0; i < n-1 ; i++)
            {
                var result = f0 + f1;
                f0 = f1;
                f1 = result;
            }
         
           
            Console.WriteLine(f1);
        }
    }
}
