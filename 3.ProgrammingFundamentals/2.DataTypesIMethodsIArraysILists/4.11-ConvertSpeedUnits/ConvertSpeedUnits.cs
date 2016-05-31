using System;

namespace _4._11_ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float hourTime = hours + minutes/60.0f + seconds/3600.0f;

            float kilometersPerHour = (distance / 1000.0f) / hourTime;
            float meterPerSecond = kilometersPerHour / 3.6f;
            float milesPerHour = (distance / 1609.0f) / hourTime;

            Console.WriteLine(meterPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}