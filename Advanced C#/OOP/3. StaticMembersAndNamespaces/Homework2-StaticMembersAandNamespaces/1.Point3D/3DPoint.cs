using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class _3DPoint
    {
        static readonly _3DPoint startingPoint = new _3DPoint(0, 0, 0);

        private double x;
        private double y;
        private double z;

        public static _3DPoint StartingPoint
        {
            get { return startingPoint; }
        }
        public _3DPoint(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }



        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }



        public override string ToString()
        {
            return String.Format("Point with coordinats X = {0}, Y = {1}, Z = {2}", this.X, this.Y, this.Z);
        }
    }
}