using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfOddEvenRigits(num);
            Console.WriteLine(result);


        }
        static long GetMultipleOfOddEvenRigits(int num)
        {
            var oddSum = SumOddDigits(num);
            var evenSum = SumEvenDigits(num);
            return oddSum * evenSum;
        }
        static long SumOddDigits(int num)
        {
            long sum = 0;
            num = Math.Abs(num);

            while (num > 0)
            {
                var digits = num % 10;
                if (num % 2 != 0)
                {
                    sum += digits;

                }
                num /= 10;
            }
            return sum;
        }

            static long SumEvenDigits(int num)
        {
            long sum = 0;
            num = Math.Abs(num);

            while (num > 0)
            {
                var digits = num % 10;
                if (num % 2 == 0)
                {
                    sum += digits;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
