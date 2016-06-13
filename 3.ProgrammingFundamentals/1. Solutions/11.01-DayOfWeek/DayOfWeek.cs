using System;
using System.Globalization;

namespace _11._01_DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}