using System;

namespace _5._01_DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int inputDay = int.Parse(Console.ReadLine());

            if (inputDay < 1 || inputDay > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(days[inputDay - 1]);
            }
        }
    }
}