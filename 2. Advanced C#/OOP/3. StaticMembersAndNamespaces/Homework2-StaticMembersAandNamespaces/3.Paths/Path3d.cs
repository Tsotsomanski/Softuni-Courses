using System;
using System.Collections.Generic;
using Point3D;

namespace Paths
{
    class Path3d
    {
        private List<_3DPoint> path = new List<_3DPoint>();

        public Path3d(List<_3DPoint> path = null)
        {
            this.path = path;
        }

        public List<_3DPoint> Path
        {
            get { return this.path; }
            set
            {
                this.path = value ?? new List<_3DPoint>();
            }
        }

        public void AddPointToPath(_3DPoint point)
        {
            var currentPath = this.Path;
            currentPath.Add(point);
            this.Path = currentPath;
        }

        public override string ToString()
        {
            string result = "Path \r\n";
            foreach (var point in this.Path)
            {
                result += "\t" + point.ToString() + "\r\n";
            }
            return result;
        }
    }
}
