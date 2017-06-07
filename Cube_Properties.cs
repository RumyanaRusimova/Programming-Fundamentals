using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();
            if (parameter == "face")
            {
                var faceDiagonal = CalculateFaceDiagonalCube(side);
                Console.WriteLine("{0:F2}", faceDiagonal);
            }
            else if (parameter == "space")
            {
                var spaseDiagonal = CalculateSpaseDiagonalCube(side);
                Console.WriteLine("{0:F2}", spaseDiagonal);
            }
            else if (parameter == "volume")
            {
                var volume = CalculatVolumeCube(side);
                Console.WriteLine("{0:F2}", volume);
            }
            else if (parameter == "area")
            {
                var surfaceArea = CalculateSurfaceAreaCube(side);
                Console.WriteLine("{0:F2}", surfaceArea);
            }
        }

        private static double CalculateSurfaceAreaCube(double side)
        {
            var surfaceArea = 6 * Math.Pow(side, 2);
            return surfaceArea;
        }

        private static double CalculatVolumeCube(double side)
        {
            var volume = Math.Pow(side, 3);
            return volume;
        }

        private static double CalculateSpaseDiagonalCube(double side)
        {
            var spaceDiagonal = Math.Sqrt(3 * side * side);
            return spaceDiagonal;
        }

        private static double CalculateFaceDiagonalCube(double side)
        {
            var faceDiagonal = Math.Sqrt(2 * side * side);
            return faceDiagonal;
           
        }
    }
}
