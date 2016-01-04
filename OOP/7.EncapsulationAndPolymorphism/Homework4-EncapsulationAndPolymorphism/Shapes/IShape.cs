using System;
using System.Runtime.Remoting.Messaging;

namespace Shapes
{
    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }
}
