using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasky1
{
    class Point
    {
        public readonly double X;
        public readonly double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static bool operator ==(Point point1, Point point2)
        {
            return (point1.X == point2.X && point1.Y == point2.Y);
        }

        public static bool operator !=(Point point1, Point point2)
        {
            return (point1.X != point2.X && point1.Y != point2.Y);
        }

    }
}
