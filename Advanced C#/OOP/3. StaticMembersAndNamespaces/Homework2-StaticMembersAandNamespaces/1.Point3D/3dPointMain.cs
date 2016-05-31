namespace Point3D
{
    using System;

    class _3dPointMain
    {
        static void Main()
        {
            _3DPoint point1 = new _3DPoint(1, 1, 1);
            _3DPoint point2 = new _3DPoint(2.5, -0.5, 12.01);

            Console.WriteLine(point1);
            Console.WriteLine(point2);
        }
    }
}