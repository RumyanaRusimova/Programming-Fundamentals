using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char b1 = char.Parse(Console.ReadLine());
            char b2 = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
             int count = 1;
            int pos1 = 0;
            int pos2 = 0;
            while(n > 0)
            {
                var speed = Console.ReadLine();
                if(count %2 != 0 )
                {
                    pos1 = pos1 + speed.Length;
                }
                else
                {
                    pos2 = pos2 + speed.Length;
                }
                if (speed == "UPGRADE")
                {
                    b1 = (char)(b1 + 3);
                    b2 = (char)(b2 + 3);
                }
                if (pos1 >= 50 || pos2 >= 50)
                {
                    
                    break;
                }
                count++;
                --n;
            }
            if(pos1 >= pos2)
            {
                Console.WriteLine(b1);
            }
            else
            {
                Console.WriteLine(b2);
            }
        }
    }
}
