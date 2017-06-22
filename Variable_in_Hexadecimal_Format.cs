using System;


namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = (Console.ReadLine());


            int convert = Convert.ToInt32(num, 16);
            Console.WriteLine(convert);
        }
    }
}
