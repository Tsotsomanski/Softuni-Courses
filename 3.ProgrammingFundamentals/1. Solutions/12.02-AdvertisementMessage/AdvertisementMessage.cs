using System;
using System.Linq;

namespace _12._02_AdvertisementMessage
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            int[] firstCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point centerA = new Point()
            {
                X = firstCircle[0],
                Y = firstCircle[1]
            };
            Point centerB = new Point()
            {
                X = secondCircle[0],
                Y = secondCircle[1]
            };
            Circle circleA = new Circle()
            {
                Center = centerA,
                Radius = firstCircle[2]
            };
            Circle circleB = new Circle()
            {
                Center = centerB,
                Radius = secondCircle[2]
            };

            if (Intesect(circleA, circleB))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Intesect(Circle c1, Circle c2)
        {
            double distanceBetweenCenters = CalcDistance(c1.Center, c2.Center);
            double sumOfRadiuses = c1.Radius + c2.Radius;
            if (distanceBetweenCenters > sumOfRadiuses)
            {
                return false;
            }

            return true;
        }

        static double CalcDistance(Point a, Point b)
        {
            double deltaX = b.X - a.X;
            double deltaY = b.Y - a.Y;
            double distance = Math.Sqrt(deltaX*deltaY + deltaY*deltaY);

            return distance;
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}