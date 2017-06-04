using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var word = " ";
            for (int i = 0; i < n; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());
                if (char.IsLetter(currentChar) || true)
                {
                    
                    word += currentChar;
                }
               }
            Console.Write($"The word is:{word}");
        }
    }
}
