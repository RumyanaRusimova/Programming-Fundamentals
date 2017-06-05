using System;
using System.Globalization;


namespace Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);

            var enddDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;
            for (var date = startDate; date <= enddDate; date = date.AddDays(1))
            {


                if (date.DayOfWeek == DayOfWeek.Saturday ||
                 
                    date.DayOfWeek == DayOfWeek.Sunday)

                    holidaysCount++;
        }
    
            Console.WriteLine(holidaysCount);

        }
    }
}
    

