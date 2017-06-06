using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
       
       static void Main(string[] args)
            {
                var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

                FindPrimeNumberInRange(a, b);
            }

        private static List<int> FindPrimeNumberInRange(int startNum, int endNum)
        {

            var result = new List<int>();

            for (int i = startNum; i <= endNum; ++i)
            {
                if(isPrime(i))
                {
                    result.Add(i);
                }
            }
            return result;
        
    }
        private static bool isPrime(long number)
        {
            if (number < 2) return false;
            bool isPrime = true;
            for (int div = 2; div <= Math.Sqrt(number); div++)
            {
                if (number % div == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

    }
}
