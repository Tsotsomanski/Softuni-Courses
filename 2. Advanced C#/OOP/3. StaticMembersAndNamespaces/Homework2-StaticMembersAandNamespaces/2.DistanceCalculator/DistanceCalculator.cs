using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace DistanceCalculator
{
    class DistanceCalculator
    {
        static void CalcDistance(_3DPoint p1, _3DPoint p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            double deltaZ = p2.Z - p1.Z;

            double distance = (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            Console.WriteLine("The distance between the point is: {0}", distance);

        }
    }
}