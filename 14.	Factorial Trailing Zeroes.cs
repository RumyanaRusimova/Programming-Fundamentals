using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Factorial
{
    class Program
    {
  

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            FindZoroDigits(factoriel);
            //  Console.WriteLine(factoriel);
        }
            public static void    FindZoroDigits( BigInteger factoriel)
            { 
         
            var count = 0;
          var digits =  factoriel.ToString().ToCharArray();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var currentChar = digits[i];
                if (digits[i]== '0')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
            }
        
    }
}


