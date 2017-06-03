using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondtLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            for (int i = thirdLetter; i >= firstLetter; i--)
            {
            }
            Console.Write($"{thirdLetter}{secondtLetter}{firstLetter}");
        }
    }
}
