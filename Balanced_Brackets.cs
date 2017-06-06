using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool pastOpening = false;
            bool balanced = true;

            for(int i = 0; i < n; ++i)
            {
                string line = Console.ReadLine();
                if(line == "(")
                {
                    if(pastOpening) //предишната скоба е била пак отваряща, значи е unbalanced
                    {
                        balanced = false;
                        break;
                    }
                    else //маркираме, че сме минали през отваряща
                    {
                        pastOpening = true;
                    }
                }
                else if (line == ")")
                {
                    if (pastOpening) //предната е била отваряща, т.е имаме валидна двойка, рестартираме pastOpening за да следим за следващата двойка от скоби
                    {
                        pastOpening = false;
                    }
                    else //предишната скоба (ако има такава не е била отваряща, значи е unbalanced)
                    {
                        balanced = false;
                        break;
                    }
                }

            }
            if (pastOpening) //ако последната скоба е била отваряща, значи е unbalanced
            {
                balanced = false;
            }

            string result = balanced ? "BALANCED" : "UNBALANCED";
            Console.WriteLine(result);
        }
    }
}

