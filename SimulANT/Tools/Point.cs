using System;
using System.Collections.Generic;
using System.Text;

namespace SimulANT.Tools
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(Point old)
        {
            X = old.X;
            Y = old.Y;
        }
    }
}
