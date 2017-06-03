using System;


namespace Triples_Of_Latin_Letters
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char letter1 =(char)(i + 'a');
                        char letter2 = (char)(j + 'a');
                        char letter3 = (char)(k + 'a');


                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
                }
            }
           }
        }
    

