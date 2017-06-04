using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =  int.Parse(Console.ReadLine());
            var hexaD = Convert.ToString(num,16).ToUpper();
            var bin = Convert.ToString(num, 2);
            Console.WriteLine(hexaD);
            Console.WriteLine(bin);
        
        }
    }
}
