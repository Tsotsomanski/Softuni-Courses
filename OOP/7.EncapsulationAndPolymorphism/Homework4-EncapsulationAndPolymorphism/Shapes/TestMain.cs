using System.Collections.Generic;
using System;

namespace Shapes
{
    class TestMain
    {
        static void Main()
        {
            var shapes = new IShape[]
            {
                new Rectangle(8, 4),
                new Rectangle(4, 3),
                new Rhombus(4, 4),
                new Rhombus(7,9),
            };
            List<Circle> circles = new List<Circle>()
            {
                new Circle(4),
                new Circle(7),
                new Circle(9),
            };
            foreach (var circ in circles)
            {
                Console.WriteLine(String.Format("Circle area: {0:.00} sm.; Circle perimeter: {1:.00} sm.", circ.CalculateArea(), circ.CalculatePerimeter()));
            }
            foreach (var shape in shapes)
            {
                Console.WriteLine(String.Format("Shapes area: {0} sm.; Shape  perimeter: {1} sm.", shape.CalculateArea(), shape.CalculatePerimeter()));
            }
        }
    }
}
