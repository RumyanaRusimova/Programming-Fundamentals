using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimeter = char.Parse(Console.ReadLine());
            var evenOdd = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var concat = "";
            for (int i = 1; i <= n; i++)
            {
                var currentWord = Console.ReadLine();
                if (i % 2 == 0 && evenOdd == "even")
                {
                    concat += currentWord + delimeter;
                }
                else if(i % 2 ==1 && evenOdd == "odd")
                {
                    concat += currentWord + delimeter;
                }
            }
            concat = concat.Remove(concat.Length - 1, 1);
            Console.WriteLine(concat);
        }
    }
}
