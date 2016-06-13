using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._05_ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int pointsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointsCount; i++)
            {
                string[] firstPointInfo = Console.ReadLine().Split();
                int pointX = int.Parse(firstPointInfo[0]);
                int pointY = int.Parse(firstPointInfo[1]);

                Point point = new Point();
            }
        }

        public static void FindShortestDistance(List<Point> points)
        {
            double shortestDistance = double.MaxValue;
            Point firstPoint = new Point();
            Point secondPoint = new Point();

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double currentDistance = points[i].CalcDistance(points[j]);

                    if (shortestDistance > currentDistance)
                    {
                        shortestDistance = currentDistance;
                        firstPoint = points[i];
                        secondPoint = points[j];

                    }
                }
            }

            Console.WriteLine("{0:F3}", shortestDistance);
            Console.WriteLine("{0}, {1}", firstPoint.X, firstPoint.Y);
            Console.WriteLine("{0}, {1}", secondPoint.X, secondPoint.Y);
        }
    }


    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double CalcDistance(Point secondPoint)
        {
            double firstDif = (this.X - secondPoint.X) * (this.X - secondPoint.Y);
            double secondDif = (this.Y - secondPoint.Y) * (this.Y - secondPoint.Y);
            
            double sqrt = Math.Sqrt(firstDif + secondDif);

            return sqrt;
        }
    }
}