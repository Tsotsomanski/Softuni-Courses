using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._04_DistanceBetweenPoints
{ 
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            Point p1 = new Point();
            Point p2 = new Point();

            List<int> firstCoordinates = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondCoordinates = Console.ReadLine().Split().Select(int.Parse).ToList();

            p1.X = firstCoordinates[0];
            p1.Y = firstCoordinates[1];

            p2.X = secondCoordinates[0];
            p2.Y = secondCoordinates[1];

            double distance = CalcDistance(p1, p2);
            Console.WriteLine("{0:0.000}", distance);
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double p1x = p1.X - p2.X;
            double p2x = p1.Y - p2.Y;
            double distance = (p1x * p1x) + (p2x * p2x);
            double sqrtDistance = Math.Sqrt(distance);

            return sqrtDistance;
        }
    }
}