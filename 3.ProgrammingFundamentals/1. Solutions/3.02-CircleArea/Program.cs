namespace _3._02_CircleArea
{
    using System;

    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = (Math.PI * radius * radius);

            Console.WriteLine("{0:f12}", area);
        }
    }
}
