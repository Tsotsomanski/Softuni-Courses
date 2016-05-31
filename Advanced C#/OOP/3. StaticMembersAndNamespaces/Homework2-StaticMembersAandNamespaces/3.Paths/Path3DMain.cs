using System;
using System.Collections.Generic;
using Point3D;

namespace Paths
{
    class Path3DMain
    {
        static void Main()
        {   
        List<_3DPoint> sequenceOfPoints = new List<_3DPoint>();
            sequenceOfPoints.Add(_3DPoint.StartingPoint);
            sequenceOfPoints.Add(new _3DPoint(0, 1, 2));
            sequenceOfPoints.Add(new _3DPoint(1.5, -3.4, 0));
            sequenceOfPoints.Add(new _3DPoint(-3.1, 0, 4));

            Path3d path = new Path3d(sequenceOfPoints);
            path.AddPointToPath(new _3DPoint(0, -1, 1.1111));
            Console.WriteLine(path);

            string fileLocation = "Path3d.txt";
            Storage.SavePathToFile(fileLocation, path);

            Path3d pathFromFile = Storage.LoadPathFromFile(fileLocation);
            Console.WriteLine(pathFromFile);
        }
    }
}
