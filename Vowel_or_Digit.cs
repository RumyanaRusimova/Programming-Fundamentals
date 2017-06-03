using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            int[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            bool isDigit = false;
            bool isVowel = false;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == ch)
                {
                    isVowel = true;
               }
            }
           
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == ch)
                {
                    isDigit = true;
                }
            }
            string result = "other";
            if (isDigit)
            {
                result = "digit";
            }
            else if (isVowel)
            {
                result = "vowel";
            }
            Console.WriteLine(result);
        }
    }
}

