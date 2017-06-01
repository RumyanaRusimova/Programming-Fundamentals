using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healtGosho = 100;
            int counterRounds = 1;
            while (healtGosho > 0 || healthPesho > 0)
            {
                if (counterRounds % 2 == 1)
                {
                    healtGosho -= damagePesho;
                    if (healtGosho <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", counterRounds);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healtGosho);
                                          
                    }
                }
                else
                {
                    healthPesho -= goshosDamage;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", counterRounds);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
                                       
                    }
                }

                if (counterRounds % 3 == 0 )
                {
                    healthPesho += 10;
                    healtGosho += 10;                
                }
                counterRounds++;
            }
        }
    }
  }

