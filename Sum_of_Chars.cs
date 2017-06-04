using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                var currentchar = char.Parse(Console.ReadLine());
                 int num = (int)currentchar;
                sum += num;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
