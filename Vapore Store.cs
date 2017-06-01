using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currentBalans = decimal.Parse(Console.ReadLine());
            var totalMoney = currentBalans;        
      
            string gameOrder = Console.ReadLine();
            while (!gameOrder.Equals("Game Time"))
            {
                switch (gameOrder)
                {
                    case "OutFall 4":
                        if (currentBalans >= 39.99M)
                        {
                            currentBalans -= 39.99M;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (currentBalans >= 15.99M)
                        {
                            currentBalans -= 15.99M;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalans >= 19.99M)
                        {
                            currentBalans -= 19.99M;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentBalans >= 59.99M)
                        {
                            currentBalans -= 59.99M;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalans >= 29.99M)
                        {
                            currentBalans -= 29.99M;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (currentBalans >= 39.99M)
                        {
                            currentBalans -= 39.99M;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currentBalans <= 0M)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                gameOrder = Console.ReadLine();
            }                       
               
                if (gameOrder == "Game Time")
                {
                    Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", totalMoney - currentBalans,currentBalans );
                }
            }

        }
    }


    

