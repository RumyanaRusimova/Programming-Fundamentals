using System;


namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int powver = int.Parse(Console.ReadLine());
             var numberRaisedToPower= RaisedToPower( number, powver);
            Console.WriteLine(numberRaisedToPower);
        }
        static double RaisedToPower(double num,int powver)
        {
            double result = 1;

            for (int i = 0; i < powver; i++)

            {

                result *= num;
            }
                return result;
            }
        }
    }

