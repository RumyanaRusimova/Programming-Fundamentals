using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            PrintReversedNum(num);
        }

        private static void PrintReversedNum(string num)
        {
            num.ToCharArray();
            var reversedNum = num.Reverse().ToArray();
            Console.WriteLine(reversedNum);
        }
    }
}
