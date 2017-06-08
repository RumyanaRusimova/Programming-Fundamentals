using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int testing = 232;
           // Console.WriteLine(ContainsEvenDigit(testing));
            //Console.WriteLine(SumOfDigits(testing));
            //Console.WriteLine(IsPalindrome(testing));

            
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                //var currentNum = int.Parse(Console.ReadLine());
                var currentNum = i;
              if ( IsPalindrome(currentNum) &&
                    SumOfDigits(currentNum)&&
                    ContainsEvenDigit(currentNum))
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

        private static bool ContainsEvenDigit( int num)
        {
          foreach(var digit in num.ToString().ToCharArray())
            {
                var currentDigit = digit - '0';
                if(currentDigit % 2 == 0)
                {
                    return true;
                }
              
            }

            return false;

        }

        private static bool SumOfDigits(int num)
        {
            var sum = 0;
          foreach(var digit in num.ToString().ToCharArray())
            {
                
                sum += digit - '0';
               
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindrome(int num)
        {
            var numAsString = num.ToString();
            bool isPalindrome = true;
            for(int i = 0; i <= numAsString.Length/2; ++i)
            {
                if(numAsString[i] != numAsString[numAsString.Length-1-i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
