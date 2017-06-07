using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeFigure = Console.ReadLine();
            
            if (typeFigure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var areaTriangle = CalculateAreaTriangle(side, height);
                Console.WriteLine("{0:F2}",areaTriangle);
            }
            else if(typeFigure == "square")
            {
                var side = double.Parse(Console.ReadLine());

                var areaSquare = CalculateAreaSquare(side);
                Console.WriteLine("{0:F2}", areaSquare);
            }
            else if(typeFigure == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                var areaRectangle = CalculateAreaRectangle(width, height);
                Console.WriteLine("{0:F2}",areaRectangle);
            }
            else if(typeFigure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());

                var areaCircle = CalculateAreaCircle(radius);
                Console.WriteLine("{0:F2}",areaCircle);
            }
        }

        private static double CalculateAreaCircle(double radius)
        {
            var areaCircle = Math.PI * radius * radius;
            return areaCircle;
        }

        private static double CalculateAreaRectangle(double width, double heigth)
        {
            var areaRectanfle = width * heigth;
            return areaRectanfle;
        }

        private static double CalculateAreaSquare( double side)
        {
            var areaSquare = Math.Pow(side, 2);
            return areaSquare;
        }

        private static double CalculateAreaTriangle(double side,double height)
        {
            var areaTriangle = side * height / 2;
            return areaTriangle;
        }
    }
}
