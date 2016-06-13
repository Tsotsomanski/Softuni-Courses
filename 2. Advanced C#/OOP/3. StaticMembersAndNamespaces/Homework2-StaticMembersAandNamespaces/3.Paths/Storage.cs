using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Point3D;

namespace Paths
{
    static class Storage
    {
        private const string PathMatcher = @"Path:\s+((?:Point\s*\((?:.*?),\s*(?:.*?),\s*(?:.*?)\)\s*)+)";
        private const string PointMatcher = @"Point\s*\((.*?),\s*(.*?),\s*(.*?)\)";


        public static void SavePathToFile(string fileLocation, Path3d path)
        {
            File.WriteAllText(fileLocation, path.ToString());
        }



        public static Path3d LoadPathFromFile(string fileLocation)
        {
            string input = File.ReadAllText(fileLocation);
            if (!Regex.IsMatch(input, PathMatcher))
            {
                throw new ArgumentNullException("input", "File does not contain Path3D data.");
            }


            string pathAsString = Regex.Match(input, PathMatcher).Groups[1].Value;
            var pointsInPath = new List<_3DPoint>();
            foreach (Match match in Regex.Matches(pathAsString, PointMatcher))
            {
                double xCoordinate = double.Parse(match.Groups[1].Value);
                double yCoordinate = double.Parse(match.Groups[2].Value);
                double zCoordinate = double.Parse(match.Groups[3].Value);
                pointsInPath.Add(new _3DPoint(xCoordinate, yCoordinate, zCoordinate));
            }


            Path3d pathFromFile = new Path3d(pointsInPath);
            return pathFromFile;
        }
    }
}
